using System.IO;
using System.Net;
using BAG.CustomObject;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System;

namespace BAG.BusinessLogic
{
    public class AccountsBLL
    {
        public Login Login(string Email_Id,string Password)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/Login/" + Email_Id + "/" + Password);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Login));

                Login obj = serializer.ReadObject(readStream.BaseStream) as Login;

                return obj;
            }
            catch
            {
                return null;
            }
        }

        public string Registration(Registration ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/Register");
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
            catch
            {
                return string.Empty;
            }
        }

        public string AccountActivation(string Id)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/Activation/" + Id);
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
                return string.Empty;
            }
        }

        public Login Registration_ThirdParty(SocialRegistration ouser)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/RegisterThirdParty");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Login));

                Login obj = serializer.ReadObject(readStream.BaseStream) as Login;

                return obj;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Profile GetUserProfile(string User_Id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/GetUserProfile/" + User_Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Profile));

                Profile obj = serializer.ReadObject(readStream.BaseStream) as Profile;

                return obj;
            }
            catch
            {
                return null;
            }
        }

        public string UpdateProfile(Profile ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/UpdateProfile");
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
            catch
            {
                return string.Empty;
            }
        }

        public string ChangePassword(ProfileSecurity ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/ChangePassword");
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
            catch
            {
                return string.Empty;
            }
        }

        public string GetUserId(string EmailId)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/GETUserId/" + EmailId);
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
                return string.Empty;
            }
        }

        public string ResetPassword(string LoginId,string Pwd)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AccountService.svc/ResetPassword/" + LoginId + "/"+Pwd);
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
                return string.Empty;
            }
        }
    }
}
