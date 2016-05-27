using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.CustomObject;
using BAG.BusinessLogic;
using BrewAgift.App_Code;
using System.IO;

namespace BrewAgift.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult MyProfile()
        {
            AccountsBLL oAccBLL = new AccountsBLL();
            var odetails = oAccBLL.GetUserProfile(Convert.ToString(Session["UserId"]));
            return View(odetails);
        }
        public ActionResult EditProfile()
        {
            AccountsBLL oAccBLL = new AccountsBLL();
            MemberProfile oprofile = new MemberProfile();
            var odetails = oAccBLL.GetUserProfile(Convert.ToString(Session["UserId"]));
            oprofile.EditProfile = odetails;
            oprofile.IsMarriedList = Global.getismarried();
            oprofile.Gender = Global.getGender();
            return View(oprofile);
        }

        public ActionResult EditProfileDetails(MemberProfile obj,HttpPostedFileBase file)
        {
            AccountsBLL oAccBLL = new AccountsBLL();
            string Images = "";
            if (Request.Files.Count > 0)
            {
                int i = 0;
                foreach (string requestFile in Request.Files)
                {
                    HttpPostedFileBase files = Request.Files[i];
                    if (files.ContentLength > 0)
                    {
                        string filestoragename = Guid.NewGuid().ToString() + file.FileName.Replace(" ", "");
                        string directory = Server.MapPath("~/Images/");
                        string path = Path.Combine(directory, filestoragename);
                        files.SaveAs(path);
                        Images = Images + "," + filestoragename;
                    }
                    i++;
                }
            }
            obj.EditProfile.Media_Id_Img = string.IsNullOrEmpty(Images.TrimStart(',', ' '))?string.Empty:"/Images/"+Images.TrimStart(',', ' ');
            obj.EditProfile.Usr_Id = Convert.ToString(Session["UserId"]);
            var status = oAccBLL.UpdateProfile(obj.EditProfile);
            return RedirectToAction("MyProfile", "Profile");
        }

        public ActionResult ChangePassword()
        {
            ProfileSecurity osec = new ProfileSecurity();
            AccountsBLL oAccBLL = new AccountsBLL();
            var odetails = oAccBLL.GetUserProfile(Convert.ToString(Session["UserId"]));
            osec.Profile_Pic = odetails.Media_Id_Img;
            return View(osec);
        }

        public ActionResult Change_Password(ProfileSecurity obj)
        {
            AccountsBLL oAccBll = new AccountsBLL();
            obj.Usr_Id = Convert.ToString(Session["UserId"]);
            obj.Old_Password = string.IsNullOrEmpty(obj.Old_Password) ? string.Empty : obj.Old_Password;
            var status= oAccBll.ChangePassword(obj);
            if (status == "1")
            {
                return Content("Password Changed Sucessfully", "text/html");
            }
            else
            {
                return Content("Please Enter Valid Password", "text/html");
            }
        }
    }
}