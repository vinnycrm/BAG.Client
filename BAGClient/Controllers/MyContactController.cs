using System.Collections.Generic;
using System.Web.Mvc;
using Google.Contacts;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Contacts;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using BAG.BusinessLogic;
using BAG.CustomObject;
using BrewAgift.App_Code;

namespace BrewAgift.Controllers
{
    public class MyContactController : Controller
    {
        //
        // GET: /MyContact/
        public ActionResult Index(string msg)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var obj= ocntsBLL.GetUserContacts(Session["UserId"].ToString());
            MyContacts ocon = new MyContacts();
            ocon.UserContacts = obj;
            ViewBag.Message = msg;
            return View(ocon);
        }

        public ActionResult CreateGroups(MyContacts obj)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            obj.CreateGroup.User_Id = Session["UserId"].ToString();
            var status= ocntsBLL.CreateUserGroup(obj.CreateGroup);
            if (status == "1")
            {
                return Content("Group Created Successfully", "text/html");
            }
            else
            {
                return Content("Group Createation Failed", "text/html");
            }
        }

        public ActionResult EditGroups(GroupDetails obj)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            obj.User_Id = Session["UserId"].ToString();
            var status = ocntsBLL.EditGroup(obj);
            if (status == "1")
            {
                return Content("Group Name Updated Successfully", "text/html");
            }
            else
            {
                return Content("Group Name Updation Failed", "text/html");
            }
        }

        public ActionResult DeleteGroups(string Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var status = ocntsBLL.DeleteGroup(Id);
            if (status == "1")
            {
                return Content("Group Deleted Successfully", "text/html");
            }
            else
            {
                return Content("Group Deletion Failed", "text/html");
            }
        }

        public ActionResult GroupSummary(string GroupId)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var obj = ocntsBLL.GetGroupContacts(GroupId);
            foreach (var items in obj)
            {
                items.GroupId = GroupId;
            }
            return PartialView("_ContactsList", obj);
        }

        public ActionResult AddGroupContact(ContactsSummary obj)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            EventsBLL oeventsBLL = new EventsBLL();
            List<GoogleContacts> odetails = new List<GoogleContacts>();
            foreach (var item in obj.UserContacts)
            {
                if (item.Selected == true)
                {
                    odetails.Add(new GoogleContacts(
                        item.EmailID,
                        item.UserId,
                        item.Selected,
                        item.GroupId
                        ));
                }
            }
            obj.UserContacts = odetails.ToArray();
            obj.createrId = Session["UserId"].ToString();
            var status = ocntsBLL.AddContactsToGroups(obj);
            if (status == "1")
            {
                return Content("Contact Added Successfully", "text/html");
            }
            else
            {
                return Content("Contact Adding Failed", "text/html");
            }
        }

        public ActionResult SelectGroups()
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var details = ocntsBLL.GetUserGroups(Session["UserId"].ToString());
            return PartialView("_Groups", details);
        }

        public ActionResult Delete_Contact(string Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            DeleteContact ocnt = new DeleteContact();
            ocnt.Id = Session["UserId"].ToString();
            ocnt.Contact_Id = Id;
            var details = ocntsBLL.DeleteContact(ocnt);
            return Content("Contact Deleted Sucessfully", "text/html");
        }

        public ActionResult Delete_GroupContact(string Id, string Contact_Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            DeleteContact ocnt = new DeleteContact();
            ocnt.Id = Id;
            ocnt.Contact_Id = Contact_Id;
            var status = ocntsBLL.DeleteGroupContact(ocnt);
            if (status == "1")
            {
                return Content("Contact Removed Sucessfully", "text/html");
            }
            else
            {
                return Content("Failed to remove Contact", "text/html");
            }

        }

        public ActionResult EditContact_Details(EditContact obj)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var status = ocntsBLL.EditContact(obj);
            if (status == "1")
            {
                return Content("Contact Updated Sucessfully", "text/html");
            }
            else
            {
                return Content("Failed to Update Contact", "text/html");
            }

        }

        public ActionResult AllContacts()
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var obj = ocntsBLL.GetUserContacts(Session["UserId"].ToString());
            return PartialView("_AllContacts", obj);
        }

        public ActionResult Import()
        {
            string clientId = "936649599657-s9akus1uv18lo7b103ji7t3cu1ljlfjb.apps.googleusercontent.com";
            string redirectUrl = "http://" + Global.MainLink + "/MyContact/AddGoogleContacts";
            Response.Redirect("https://accounts.google.com/o/oauth2/auth?redirect_uri=" + redirectUrl + "&amp&response_type=code&amp&client_id=" + clientId + "&amp&scope=https://www.google.com/m8/feeds/&amp;approval_prompt=force&amp;access_type=offline");
            return View();
        }

        public ActionResult AddGoogleContacts()
        {
            ContactsBLL ocontactsBLL = new ContactsBLL();
            string code = Request.QueryString["code"];
            if (!string.IsNullOrEmpty(code))
            {
                var contacts = GetAccessToken().ToArray();
                List<GoogleContacts> olist = new List<GoogleContacts>();
                foreach (var item in contacts)
                {
                    if (!string.IsNullOrEmpty(item.EmailID))
                    {
                        olist.Add(new GoogleContacts(
                            Session["UserId"].ToString(),
                            item.EmailID,
                            string.Empty,
                            string.Empty));
                    }
                }
                string status = ocontactsBLL.Import_Google(olist.ToArray());
            }
            return RedirectToAction("Index", "MyContact", new { msg = "Contact Imported Sucessfully" });
        }

        public List<GmailContacts> GetAccessToken()
        {
            string code = Request.QueryString["code"];
            string google_client_id = "936649599657-s9akus1uv18lo7b103ji7t3cu1ljlfjb.apps.googleusercontent.com";
            string google_client_sceret = "w5nmQnac-A2gBLR8dh2YWGqk";
            string google_redirect_url = "http://" + Global.MainLink + "/MyContact/AddGoogleContacts";


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
            webRequest.Method = "POST";
            string parameters = "code=" + code + "&client_id=" + google_client_id + "&client_secret=" + google_client_sceret + "&redirect_uri=" + google_redirect_url + "&grant_type=authorization_code";
            byte[] byteArray = Encoding.UTF8.GetBytes(parameters);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            Stream postStream = webRequest.GetRequestStream();
            // Add the post data to the web request
            postStream.Write(byteArray, 0, byteArray.Length);
            postStream.Close();
            WebResponse response = webRequest.GetResponse();
            postStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(postStream);
            string responseFromServer = reader.ReadToEnd();
            GooglePlusAccessToken serStatus = JsonConvert.DeserializeObject<GooglePlusAccessToken>(responseFromServer);
            /*End*/
            return GetContacts(serStatus);
        }

        public List<GmailContacts> GetContacts(GooglePlusAccessToken serStatus)
        {
            string google_client_id = "936649599657-s9akus1uv18lo7b103ji7t3cu1ljlfjb.apps.googleusercontent.com";
            string google_client_sceret = "w5nmQnac-A2gBLR8dh2YWGqk";
            /*Get Google Contacts From Access Token and Refresh Token*/
            // string refreshToken = serStatus.refresh_token;
            string accessToken = serStatus.access_token;
            string scopes = "https://www.google.com/m8/feeds/contacts/default/full/";
            OAuth2Parameters oAuthparameters = new OAuth2Parameters()
            {
                ClientId = google_client_id,
                ClientSecret = google_client_sceret,
                RedirectUri = "http://" + Global.MainLink + "/MyContact/AddGoogleContacts",
                Scope = scopes,
                AccessToken = accessToken,
                //  RefreshToken = refreshToken
            };


            RequestSettings settings = new RequestSettings("Group Gifts ", oAuthparameters);
            ContactsRequest cr = new ContactsRequest(settings);
            ContactsQuery query = new ContactsQuery(ContactsQuery.CreateContactsUri("default"));
            query.NumberToRetrieve = 5000;
            Feed<Contact> ContactList = cr.GetContacts();

            List<GmailContacts> olist = new List<GmailContacts>();
            foreach (Contact contact in ContactList.Entries)
            {
                foreach (EMail email in contact.Emails)
                {
                    GmailContacts gc = new GmailContacts();
                    gc.EmailID = email.Address;
                    var a = contact.Name.FullName;
                    olist.Add(gc);
                }
            }
            return olist;
        }

        public ActionResult AddContactManually(EditContact details)
        {
            ContactsBLL ocontactsBLL = new ContactsBLL();
            List<GoogleContacts> olist = new List<GoogleContacts>();

            if (!string.IsNullOrEmpty(details.EmailId) & !string.IsNullOrEmpty(details.Phone_No))
            {
                olist.Add(new GoogleContacts(
                    Session["UserId"].ToString(),
                    details.EmailId,
                    details.Name,
                    details.Phone_No));

                string status = ocontactsBLL.Import_Google(olist.ToArray());
                return Content("Contact Added Sucessfully", "text/html");
            }
            else
            {
                return Content("Contact Adding Falied", "text/html");
            }
        }

        public ActionResult P_DeleteContact(string Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            DeleteContact ocnt = new DeleteContact();
            ocnt.Id = Id;
            return PartialView("_DeleteContact", ocnt);
        }

        public ActionResult P_DeleteGroupContact(string Id, string Contact_Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            DeleteContact ocnt = new DeleteContact();
            ocnt.Id = Id;
            ocnt.Contact_Id = Contact_Id;
            return PartialView("_RemoveGroupContact", ocnt);
        }
        public ActionResult P_DeleteGroups(string Id,string Name)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            GroupDetails obj = new GroupDetails();
            obj.Group_Id = Id;
            obj.Group_Name = Name;
            return PartialView("_DeleteGroup",obj);
        }
        public ActionResult P_EditGroups(string Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            GroupDetails obj = new GroupDetails();
            obj.Group_Id = Id;
            return PartialView("_EditGroup", obj);
        }
        public ActionResult P_AddContact(string Group_Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var obj = ocntsBLL.GetUserContacts(Session["UserId"].ToString());
            ContactsSummary osummary = new ContactsSummary();
            osummary.UserContacts = obj;
            osummary.groupId = Group_Id;
            return PartialView("_AddGroupContacts", osummary);;
        }
        public ActionResult P_EditContact(string Id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            EditContact ocnt = new EditContact();
            ocnt.Id = Id;
            return PartialView("_EditContact", ocnt);
        }

        public ActionResult P_AddManualContacts()
        {
            return PartialView("_AddManualContacts");
        }

        public ActionResult P_CreateGroup()
        {
            return PartialView("_CreateGroup");
        }

	}
}