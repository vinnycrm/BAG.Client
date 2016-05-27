using System;

namespace BAG.CustomObject
{
    public class Registration
    {
        public Registration()
        { }
        
        public string First_Name
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }
        private string _First_Name;

        public string Email_Id
        {
            get { return _Email_Id; }
            set { _Email_Id = value; }
        }
        private string _Email_Id;

        public string Phone_No
        {
            get { return _Phone_No; }
            set { _Phone_No = value; }
        }
        private string _Phone_No;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _Password;

        public string Cfm_Password
        {
            get { return _Cfm_Password; }
            set { _Cfm_Password = value; }
        }
        private string _Cfm_Password;

        public Registration(
            
        string First_Name,
        string EmailId,
        string Phone_No,
        string Password)
        {
            this._First_Name = First_Name;
            this._Email_Id = Email_Id;
            this._Phone_No = Phone_No;
            this._Password = Password;
        }
    }


    public class SocialRegistration
    {
        public SocialRegistration()
        { }

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;

        public string First_Name
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }
        private string _First_Name;

        public string Email_Id
        {
            get { return _Email_Id; }
            set { _Email_Id = value; }
        }
        private string _Email_Id;

        public string Phone_No
        {
            get { return _Phone_No; }
            set { _Phone_No = value; }
        }
        private string _Phone_No;

        public string Profile_Pic
        {
            get { return _Profile_Pic; }
            set { _Profile_Pic = value; }
        }
        private string _Profile_Pic;

        public SocialRegistration(

        string First_Name,
        string EmailId,
        string Profile_Pic)
        {
            this._First_Name = First_Name;
            this._Email_Id = Email_Id;
            this._Phone_No = Phone_No;
            this._Profile_Pic = Profile_Pic;
        }
    }

    public class ActivationDetails
    {
        public ActivationDetails()
        { }

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;

        public string First_Name
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }
        private string _First_Name;

        public string Email_Id
        {
            get { return _Email_Id; }
            set { _Email_Id = value; }
        }
        private string _Email_Id;        

        public ActivationDetails(

        string First_Name,
        string EmailId)
        {
            this._First_Name = First_Name;
            this._Email_Id = Email_Id;
        }
    }
    
}