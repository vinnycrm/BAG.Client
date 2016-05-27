using ASPSnippets.FaceBookAPI;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BAG.CustomObject;
using BrewAgift.App_Code;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using BAG.BusinessLogic;
using System.Text;
using System;

namespace BrewAgift.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult MyEvents()
        {
            EventsBLL oeventsBLL = new EventsBLL();
            var details= oeventsBLL.GetMyEvents(Convert.ToString(Session["UserId"]));
            return View(details);
        }

        public ActionResult MyInvites()
        {
            EventsBLL oeventsBLL = new EventsBLL();
            var details = oeventsBLL.GetMyInvites(Convert.ToString(Session["UserId"]));
            return View(details);
        }

        public ActionResult InvitedEvents()
        {
            return View();
        }

        public ActionResult Create()
        {
            EventsBLL oeventsbll = new EventsBLL();
            var Event_type = oeventsbll.GetEventtypes();
            Create_Event ogroup = new Create_Event();
            ogroup.EventTypes = Event_type;
            return View(ogroup);
        }

        public ActionResult Event_Images(string Id)
        {
            EventsBLL oeventsbll = new EventsBLL();
          //  var Event_type = oeventsbll.GetEventtypeImage(Id);
            return Content("","text/html");
        }

        public ActionResult CreateEvent(Create_Event obj)
        {
            try
            {
                EventsBLL oeventbll = new EventsBLL();
                string message = "";
                 obj.CreateEvent.User_Id = Convert.ToString(Session["UserId"]);
                var status = oeventbll.CreateEvent(obj.CreateEvent);
                if (status == "1")
                {
                    ModelState.Clear();
                    message = "Event Created Successfully";
                }
                else
                {
                    message = "Event Creation Failed,Please try again.";
                }
                return Content(message, "text/html");
            }
            catch
            {
                return Content("Event Creation Failed, Please try again.", "text/html");
            }
            
        }
    }
}