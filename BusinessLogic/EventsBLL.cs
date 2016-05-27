using System.IO;
using System.Net;
using BAG.CustomObject;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;

namespace BAG.BusinessLogic
{
    public class EventsBLL
    {
        public EventTypes[] GetEventtypes()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETEventTypes");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(EventTypes[]));

                EventTypes[] obj = serializer.ReadObject(readStream.BaseStream) as EventTypes[];

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        

        public string CreateEvent(CreateEvent ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/CreateEvent");
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

        public Group_HeaderEvent GetHeaderEvents(string UserId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETHeaderEvent/" + UserId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Group_HeaderEvent));

                Group_HeaderEvent obj = serializer.ReadObject(readStream.BaseStream) as Group_HeaderEvent;

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public WishList[] GetEventsWishlist(string EventId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETEventsWishlist/" + EventId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(WishList[]));

                WishList[] obj = serializer.ReadObject(readStream.BaseStream) as WishList[];

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public WishList[] GetCNTWishlist(string EventId,string UserId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETCNTWishlist/" + EventId + "/" + UserId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(WishList[]));

                WishList[] obj = serializer.ReadObject(readStream.BaseStream) as WishList[];

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public EventDetails GetEventDetails(string EventId, string UserId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETEventDetails/" + EventId + "/" + UserId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(EventDetails));

                EventDetails obj = serializer.ReadObject(readStream.BaseStream) as EventDetails;

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string CreateWishlist(WishList ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/CreateWishlist");
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

        public string DeleteWishlist(string Id)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/DeleteWishlist/" + Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public EventSummary GetWishlistDetails(string wishlist_Id, string UserId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GetWishlistDetails/" + wishlist_Id + "/" + UserId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(EventSummary));

                EventSummary obj = serializer.ReadObject(readStream.BaseStream) as EventSummary;

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string AddItemsToWishlist(ItemsList[] ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/AddItemsToWishlist");
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

        public string UpdateWishlist(WishList ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/UpdateWishlist");
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

        public EventsList[] GetMyEvents(string UserId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETMYEventsList/" + UserId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(EventsList[]));

                EventsList[] obj = serializer.ReadObject(readStream.BaseStream) as EventsList[];

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public EventsList[] GetMyInvites(string UserId)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/GETMYInviteList/" + UserId);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(EventsList[]));

                EventsList[] obj = serializer.ReadObject(readStream.BaseStream) as EventsList[];

                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string InviteMembers(InviteContacts ouser)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/InviteMembers");
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

        public string UpdateEventInvites(string code,string Id)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/EventService.svc/UpdateEventInvites/" + code+"/"+Id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result.Replace("\"", "");
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
