using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.BusinessLogic;
using BAG.CustomObject;
using BrewAgift.App_Code;

namespace BrewAgift.Controllers
{
    public class EventDetailsController : Controller
    {
        public ActionResult Index(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                EventsBLL oeventBLL = new EventsBLL();
                var details = oeventBLL.GetEventDetails(id, Convert.ToString(Session["UserId"]));
                return View("EventOrganiser",details);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Wishlists(string Event_id)
        {
            EventsBLL oeventBLL = new EventsBLL();
            var details = oeventBLL.GetEventsWishlist(Event_id);
            return PartialView("_wishlist", details);
            
        }

        public ActionResult CreateWishlist(WishList obj)
        {
            EventsBLL oeventBLL = new EventsBLL();
            var details = oeventBLL.CreateWishlist(obj);
            if (details == "1")
            {
                return Content("Wishlist Created Sucessfully", "text/html");
            }
            else
            {
                return Content("Wishlist Creation Falied", "text/html");
            }
        }

        public ActionResult DeleteWishlist(string Id)
        {
            EventsBLL oeventBLL = new EventsBLL();
            var details = oeventBLL.DeleteWishlist(Id);
            if (details == "1")
            {
                return Content("Wishlist Deleted Sucessfully", "text/html");
            }
            else
            {
                return Content("Wishlist Deletion Falied", "text/html");
            }
        }

        public ActionResult Eventsummary(string wishlist_id)
        {
            EventsBLL oeventBLL = new EventsBLL();
            EventSummary osummary = new EventSummary();
            osummary = oeventBLL.GetWishlistDetails(wishlist_id, Convert.ToString(Session["UserId"]));
            foreach(var items in osummary.ItemList)
            {
                osummary.total += Convert.ToInt32(items.Item_Tentative_Cost);
            }
            return PartialView("_EventDetails",osummary);
        }

        public ActionResult AddItemsToWishlist(EventDetails obj)
        {
            EventsBLL oeventsBLL = new EventsBLL();
            List<ItemsList> odetails = new List<ItemsList>();
            foreach(var item in obj.ItemList)
            {
                if(item.Selected==true)
                {
                    odetails.Add(new ItemsList(
                        item.Item_Id,
                        item.Item_Tentative_Cost,
                        item.Selected,
                        obj.EventMaster.Event_Id,
                        obj.CreateWishlist.Id
                        ));
                }
            } 
            oeventsBLL.AddItemsToWishlist(odetails.ToArray());
            return Content("Items Added Successfully", "text/html");
        }

        public ActionResult UpdateWishlist(WishList obj)
        {
            EventsBLL oeventBLL = new EventsBLL();
            var details = oeventBLL.UpdateWishlist(obj);
            if (details == "1")
            {
                return Content("Wishlist Updated Sucessfully", "text/html");
            }
            else
            {
                return Content("Wishlist Updation Falied", "text/html");
            }
        }

        public ActionResult SendInvites(InviteContacts obj)
        {
            EventsBLL oeventsBLL = new EventsBLL();
            List<InviteMembers> odetails = new List<InviteMembers>();
            Global ogl = new Global();
            foreach (var item in obj.InvitedMembers)
            {
                if (item.Selected == true)
                {
                    string rnd= Global.RandomString(6);
                    odetails.Add(new InviteMembers(
                        item.EmailID,
                        Convert.ToString(Session["UserId"]),
                        item.ContactNo,
                        rnd,
                        false));
                      ogl.sendMail("", item.EmailID, "Invitation to an Event", "http://" + Global.MainLink + "/Account/Index?Code=" + rnd);
                }
            }
            obj.InvitedMembers = odetails.ToArray();
            var status = oeventsBLL.InviteMembers(obj);
            if (status == "1")
            {
                return Content("Contact Invited Successfully", "text/html");
            }
            else
            {
                return Content("Failed to Invite Contacts", "text/html");
            }
        }

        public ActionResult EventContributer(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                EventsBLL oeventBLL = new EventsBLL();
                var details = oeventBLL.GetEventDetails(id, Convert.ToString(Session["UserId"]));
                return View("EventContributer", details);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Contributer_Wishlists(string Event_id)
        {
            EventsBLL oeventBLL = new EventsBLL();
            var details = oeventBLL.GetCNTWishlist(Event_id, Convert.ToString(Session["UserId"]));
            return PartialView("_Cnt_WishlistDetails", details);

        }

        public ActionResult Contributer_Eventsummary(string wishlist_id)
        {
            EventsBLL oeventBLL = new EventsBLL();
            EventSummary osummary = new EventSummary();
            osummary = oeventBLL.GetWishlistDetails(wishlist_id, Convert.ToString(Session["UserId"]));
            foreach(var items in osummary.ItemList)
            {
                osummary.total = Convert.ToInt32(items.Item_Tentative_Cost);
            }
            return PartialView("_Cnt_EventDetails", osummary);
        }

        public ActionResult P_CreateWishlist(string Id)
        {
            WishList obj = new WishList();
            obj.Id = Id;
            return PartialView("_CreateWishlist", obj);
        }

        public ActionResult P_EditWishlist(string Id)
        {
            WishList obj = new WishList();
            obj.Id = Id;
            return PartialView("_EditWishlist", obj);
        }

        public ActionResult P_InviteMembers(string wishlist_id, string Event_id)
        {
            ContactsBLL ocntsBLL = new ContactsBLL();
            var obj = ocntsBLL.GetUserContacts(Session["UserId"].ToString());
            InviteContacts osummary = new InviteContacts();
            List<InviteMembers> olist = new List<InviteMembers>();
            foreach (var item in obj)
            {
                olist.Add(new InviteMembers(
                    item.EmailID,
                    item.UserId,
                    item.ContactNo,
                    "",
                    false));
            }
            osummary.wishlist_Id = wishlist_id;
            osummary.Event_Id = Event_id;
            osummary.InvitedMembers = olist.ToArray();
            return PartialView("_InviteMembers", osummary); ;
        }

        public ActionResult P_DeleteWishlist(string Id, string Name)
        {
            WishList obj = new WishList();
            obj.Id = Id;
            obj.WList_Name = Name;
            return PartialView("_DeleteWishlist", obj);
        }

        public ActionResult P_AddItems(string Id, string WList_Id)
        {
            EventsBLL oeventBLL = new EventsBLL();
            WishList obj=new WishList();
            obj.Id=WList_Id;
            var details = oeventBLL.GetEventDetails(Id, Convert.ToString(Session["UserId"]));
            details.CreateWishlist = obj;
            return PartialView("_AddItems", details);
        }
	}
}