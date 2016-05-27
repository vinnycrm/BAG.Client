using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.CustomObject
{
    public class ProfileSecurity
    {
        public ProfileSecurity()
        { }


        public string Usr_Id
        {
            get { return _Usr_Id; }
            set { _Usr_Id = value; }
        }
        private string _Usr_Id;

        public string Profile_Pic
        {
            get { return _Profile_Pic; }
            set { _Profile_Pic = value; }
        }
        private string _Profile_Pic;

        public string Old_Password
        {
            get { return _Old_Password; }
            set { _Old_Password = value; }
        }
        private string _Old_Password;

        public string New_Password
        {
            get { return _New_Password; }
            set { _New_Password = value; }
        }
        private string _New_Password;

        public string Email_Id
        {
            get { return _Email_Id; }
            set { _Email_Id = value; }
        }
        private string _Email_Id;

        public string Conf_New_Password
        {
            get { return _Conf_New_Password; }
            set { _Conf_New_Password = value; }
        }
        private string _Conf_New_Password;


        public ProfileSecurity(

            string Usr_Id,
            string Old_Password,
            string New_Password,
            string Email_Id,
            string Profile_Pic,
            string Conf_New_Password)
            {
            this._Usr_Id = Usr_Id;
            this._Old_Password = Old_Password;
            this._New_Password = New_Password;
            this._Email_Id = Email_Id;
            this._Profile_Pic = Profile_Pic;
            this._Conf_New_Password = Conf_New_Password;
        }
    }
}
