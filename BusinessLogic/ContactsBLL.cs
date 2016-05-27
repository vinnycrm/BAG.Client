using System.IO;
using System.Net;
using BAG.CustomObject;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System;

namespace BAG.BusinessLogic
{
    public class ContactsBLL
    {
        public string Import_Google(GoogleContacts[] ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/ImportContacts");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch(Exception ex)
            {
                return string.Empty;
            }
        }

        public GoogleContacts[] GetUserContacts(string Id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/GetUserContact/" + Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(GoogleContacts[]));

                GoogleContacts[] obj = serializer.ReadObject(readStream.BaseStream) as GoogleContacts[];

                return obj;
            }
            catch
            {
                return null;
            }
        }

        public string CreateUserGroup(GroupDetails ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/CreateGroup");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public GroupDetails[] GetUserGroups(string Id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/GetUserGroups/" + Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(GroupDetails[]));

                GroupDetails[] obj = serializer.ReadObject(readStream.BaseStream) as GroupDetails[];

                return obj;
            }
            catch
            {
                return null;
            }
        }

        public string EditGroup(GroupDetails ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/EditGroup");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string DeleteGroup(string Id)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/DeleteGroup/" + Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch
            {
                return null;
            }
        }

        public GoogleContacts[] GetGroupContacts(string Id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/GetGroupContacts/" + Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(GoogleContacts[]));

                GoogleContacts[] obj = serializer.ReadObject(readStream.BaseStream) as GoogleContacts[];

                return obj;
            }
            catch
            {
                return null;
            }
        }

        public string AddContactsToGroups(ContactsSummary ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/AddGroupContacts");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string DeleteContact(DeleteContact ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/DeleteContact");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string DeleteGroupContact(DeleteContact ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/RemoveGroupContact");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string EditContact(EditContact ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/ContactsService.svc/EditContact");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

    }
}
