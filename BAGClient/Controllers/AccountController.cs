using ASPSnippets.FaceBookAPI;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BAG.CustomObject;
using BrewAgift.App_Code;
using System.Net;
using System;
using System.IO;
using Newtonsoft.Json;
using BAG.BusinessLogic;
using System.Text;

namespace BrewAgift.Controllers
{
    
    public class AccountController : Controller
    {
        public ActionResult Index(string Code)
        {
            if (!string.IsNullOrEmpty(Code))
            {
                Session["Code"] = Code;
                UpdateEventInvites();
            }
            
            return View();
        }
        
        public ActionResult Register(Registration obj)
        {
            try
            {
                AccountsBLL obll = new AccountsBLL();
                string status = obll.Registration(obj);
                string message = string.Empty;
                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "0")
                    {
                        message = "Registration failed,Please try again.";
                    }
                    else if (status == "2")
                    {
                        message = "Entered Email-Id is Already registered please try with new one. ";
                    }
                    else if(status!="")
                    {
                        Sendmail(status, obj.Email_Id);
                        message = "Registration Successfull, Please verify your Email to Login";
                    }
                    else
                    {
                            message = "Registration failed,Please try again."; 
                    }
                }
                ModelState.Clear();
                return Content(message, "text/html");
            }
            catch
            {
                return Content("Registration failed,Please try again.", "text/html");
            }
        }

        public string ManualLogin(string EmailId, string Password)
        {
            try
            {
                U_USR_Lgn ologin = new U_USR_Lgn();
                AccountsBLL oacc = new AccountsBLL();
                Login odetail = oacc.Login(EmailId, Password);
                if (odetail != null)
                {
                    if (!string.IsNullOrEmpty(odetail.Id) & !string.IsNullOrEmpty(odetail.First_Name))
                    {
                        Session["UserId"] = odetail.Id;
                        Session["UserName"] = odetail.First_Name;
                        UpdateEventInvites();
                        return "1";
                    }
                    return "0";
                }
                else
                {
                    return "0";
                }
            }
            catch
            {
                return "0";
            }
        }

        [HttpPost]
        public ActionResult FacebookLogin()
        {
            try
            {
                FaceBookConnect.API_Key = "427708607436982";
                FaceBookConnect.API_Secret = "bf759b99251fde4f361078090dda63ba";
                FaceBookConnect.Authorize("user_photos,email", Request.Url.AbsoluteUri.Split('?')[0]);
                return View("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult FacebookLogin(string code)
        {
            try
            {
                string data = FaceBookConnect.Fetch(code, "me");
                FaceBookUser faceBookUser = new JavaScriptSerializer().Deserialize<FaceBookUser>(data);
                faceBookUser.PictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type=large", faceBookUser.Id);

                SocialRegistration obj = new SocialRegistration();
                obj.Id = faceBookUser.Id;
                obj.Email_Id = string.IsNullOrEmpty(faceBookUser.Email)? faceBookUser.Id+"@BAG.com": faceBookUser.Email;
                obj.First_Name = faceBookUser.Name;
                obj.Phone_No = string.Empty;
                obj.Profile_Pic = faceBookUser.PictureUrl;
                AccountsBLL obll = new AccountsBLL();
                Login status = obll.Registration_ThirdParty(obj);
                if (status!=null)
                {
                    if (!string.IsNullOrEmpty(status.Id))
                    {
                        Session["UserId"] = status.Id;
                        Session["UserName"] = status.First_Name;
                        UpdateEventInvites();

                    }
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index", "Account");
                }
            }
            catch
            {
                return RedirectToAction("Index","Home");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LoginWithGoogle()
        {
            string googleplus_client_id = "936649599657-s9akus1uv18lo7b103ji7t3cu1ljlfjb.apps.googleusercontent.com";
            string googleplus_redirect_url = "http://"+Global.MainLink+"/Account/GoogleLogin";
            var Googleurl = "https://accounts.google.com/o/oauth2/auth?response_type=code&redirect_uri=" + googleplus_redirect_url + "&scope=https://www.googleapis.com/auth/userinfo.email%20https://www.googleapis.com/auth/userinfo.profile&client_id=" + googleplus_client_id;
            Response.Redirect(Googleurl);
            return View("Index");
        }

        public ActionResult GoogleLogin()
        {
            string googleplus_client_id = "936649599657-s9akus1uv18lo7b103ji7t3cu1ljlfjb.apps.googleusercontent.com";
            string googleplus_client_sceret = "w5nmQnac-A2gBLR8dh2YWGqk";
            string googleplus_redirect_url = "http://"+Global.MainLink+"/Account/GoogleLogin";
            string Parameters;
            var url = Request.Url.Query;
            if (url != "")
            {
                string queryString = url.ToString();
                char[] delimiterChars = { '=' };
                string[] words = queryString.Split(delimiterChars);
                string code = words[1];

                if (code != null)
                {
                    //get the access token 
                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
                    webRequest.Method = "POST";
                    Parameters = "code=" + code + "&client_id=" + googleplus_client_id + "&client_secret=" + googleplus_client_sceret + "&redirect_uri=" + googleplus_redirect_url + "&grant_type=authorization_code";
                    byte[] byteArray = Encoding.UTF8.GetBytes(Parameters);
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

                    if (serStatus != null)
                    {
                        string accessToken = string.Empty;
                        accessToken = serStatus.access_token;

                        if (!string.IsNullOrEmpty(accessToken))
                        {
                            string JSONDATA = "";
                            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token=" + accessToken);
                            httpWebRequest.Method = "GET";
                            httpWebRequest.ContentType = @"application/json; charset=utf-8";

                            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                JSONDATA = streamReader.ReadToEnd();
                            }
                            var json_serializer = new JavaScriptSerializer();
                            GooglePlusLogin Profile = JsonConvert.DeserializeObject<GooglePlusLogin>(JSONDATA);
                            SocialRegistration obj = new SocialRegistration();
                            obj.Id = Profile.id;
                            obj.Email_Id = string.IsNullOrEmpty(Profile.email)?Profile.id+"@BAG.com": Profile.email;
                            obj.First_Name = Profile.name;
                            obj.Phone_No = string.Empty;
                            obj.Profile_Pic = Profile.picture;
                            AccountsBLL obll = new AccountsBLL();
                            Login status = obll.Registration_ThirdParty(obj);
                            if (status!=null)
                            {
                                if (!string.IsNullOrEmpty(status.Id))
                                {
                                    Session["UserId"] = status.Id;
                                    Session["UserName"] = status.First_Name;
                                    UpdateEventInvites();
                                    return RedirectToAction("Index", "Dashboard");
                                }
                            }
                            else
                            {
                                return RedirectToAction("Index", "Account");
                            }
                        }
                        else
                        { }
                    }
                    else
                    { }
                }
                else
                { }
            }

            return View("Index");
        }

        public class GooglePlusAccessToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string id_token { get; set; }
            public string refresh_token { get; set; }
        }

        public class GooglePlusLogin
        {
            public string id { get; set; }
            public string email { get; set; }
            public string verified_email { get; set; }
            public string name { get; set; }
            public string given_name { get; set; }
            public string family_name { get; set; }
            public string link { get; set; }
            public string picture { get; set; }
            public string gender { get; set; }
            public string locale { get; set; }
        }

        public ActionResult AccountActivation(string id)
        {
            AccountsBLL ouser = new AccountsBLL();
            ouser.AccountActivation(Global.Base64Decode(id));
            return View("response");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Send_Pwd_rest_Link(Profile obj)
        {
            AccountsBLL oBLL = new AccountsBLL();
            var status = oBLL.GetUserId(obj.Email_Id);
            if(!string.IsNullOrEmpty(status))
            {
                Global o = new Global();
                o.sendMail("", obj.Email_Id, "BAG Password Reset Link", "http://"+Global.MainLink+"/Account/ResetPassword?Id=" + status + "");
                return Content("Password Reset Link Sent To Your Main-Id","text/html");
            }
            else
            { 
                return Content("Please Contact Admin","text/html");
            }
        }

        public ActionResult ResetPassword(string Id)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                ProfileSecurity obj = new ProfileSecurity();
                obj.Usr_Id = Id;
                return View(obj);
            }
            else
            {
                return RedirectToAction("ForgotPassword");
            }
        }

        public ActionResult Reset_Password(ProfileSecurity obj)
        {
            AccountsBLL oBLL = new AccountsBLL();
            var status=oBLL.ResetPassword(obj.Usr_Id,obj.New_Password);
            if (status == "1")
            {
                return Content("Password Changed Sucessfully", "text/html");
            }
            else
            {
                return Content("Please contact Admin","text/html");
            }
        }

        public string UpdateEventInvites()
        {
            try
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["Code"])) & !string.IsNullOrEmpty(Convert.ToString(Session["UserId"])))
                {
                    EventsBLL obll = new EventsBLL();
                    return obll.UpdateEventInvites(Session["Code"].ToString(), Session["UserId"].ToString());
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
            finally
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["Code"])) & !string.IsNullOrEmpty(Convert.ToString(Session["UserId"])))
                {
                    Session["Code"] = null;
                }
            }
        }

        protected void Sendmail(string id,string EmailId)
        {
            try
            {
                Global oglobal = new Global();
                string _FilePath = HttpContext.Server.MapPath("~/Xml/Activation.txt");
                StreamReader sr = new StreamReader(_FilePath);
                string body = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                body = body.Replace("[Link]", "http://"+Global.MainLink+"/Account/accountactivation?id=" + Global.Base64Encode(id));
                body = body.Replace("[HLink]", "http://" + Global.MainLink + "/Account/accountactivation?id=" + Global.Base64Encode(id));
                string status = oglobal.sendMail("info@BrewAgift.com", EmailId, "BrewAGift Activation Link", body);
                if (status == "1")
                {
                    ViewBag.Message = "Registered Successfully,Please verify your E-mail to Login";
                }
                else
                {
                    ViewBag.Message = "Registered Successfully,Error in sending Activation Link " + status;
                }
            }
            catch
            {

            }
        }
    }
}