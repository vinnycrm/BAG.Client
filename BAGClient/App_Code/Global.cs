using System;
using System.IO;
using System.Web.UI.WebControls;
using System.Xml;
using Mandrill;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Net.Mail;
using BAG.CustomObject;

namespace BrewAgift.App_Code
{
    public class Global
    {
                public static string MainLink = "localhost:50227";
            //  public static string MainLink = "brewagift.prayogis.com";

            public string sendMail(string from, string to, string subject, string messageBody)
            {
                string sReferal = messageBody;
                try
                {
                    MandrillApi api = new MandrillApi("p2CJLw9clOTIbN-QNHzwBA");

                    EmailMessage message = new EmailMessage();

                    message.from_email = "info@BrewAgift.com";

                    message.from_name = "Brew A Gift";

                    message.html = string.Format(sReferal);

                    message.subject = subject;// "E-mail Activation Mail from MSI";

                    message.to = new List<EmailAddress>()
            {
              new Mandrill.EmailAddress(to,"GUEST")
            };
                    List<EmailResult> emailResults = api.SendMessage(message);
                    foreach (var result in emailResults)
                    {

                        if (result.Status == Mandrill.EmailResultStatus.Sent)
                        {
                            return "1";
                        }
                    }
                    return "";
                }
                catch (Exception ex)
                {
                    return "";
                }
            }

            public static bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            public static string UploadImage(FileUpload Imageurl)
            {
                try
                {
                    string filePath = System.Web.HttpContext.Current.Server.MapPath("~/images/") + Guid.NewGuid().ToString() + ".jpeg";

                    if (Imageurl.PostedFile.FileName != null & Imageurl.PostedFile.FileName != string.Empty)
                    {
                        if (!string.IsNullOrEmpty(Imageurl.ToString()))
                        {
                            if (Imageurl.PostedFile.ContentLength < 2480000)
                            {
                                Imageurl.PostedFile.SaveAs(filePath);
                                return "images/" + Path.GetFileName(filePath);
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch
                {

                }
                return string.Empty;
            }

            public static string getConfigElement(string Element)
            {
                try
                {
                    XmlDocument objConfig = new XmlDocument();
                    objConfig.Load(AppDomain.CurrentDomain.BaseDirectory + @"/Xml/Configuration.config");
                    return objConfig.GetElementsByTagName(Element)[0].InnerText;
                }
                catch
                {
                    return "";
                }
            }

            public static string Base64Encode(string plainText)
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }

            public static string Base64Decode(string base64EncodedData)
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }

            public static string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random();
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }

            public static List<YesNo> getismarried()
            {
                var olist = new List<YesNo>
            {
            new YesNo{Id=0 , title = "No"},
            new YesNo{Id=1 , title = "Yes"} 
            };
                return olist;
            }

            public static List<YesNo> getGender()
            {
                var olist = new List<YesNo>
            {
            new YesNo{Id=1 , title = "Male"},
            new YesNo{Id=0 , title = "Female"} 
            };
                return olist;
            }

    }
}
