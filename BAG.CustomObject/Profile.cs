using System;

namespace BAG.CustomObject
{
    public class Profile
    {
        public Profile()
        { }


        public string Usr_Id
        {
            get { return _Usr_Id; }
            set { _Usr_Id = value; }
        }
        private string _Usr_Id;

        public string First_Name
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }
        private string _First_Name;

        public string Last_Name
        {
            get { return _Last_Name; }
            set { _Last_Name = value; }
        }
        private string _Last_Name;

        public string Email_Id
        {
            get { return _Email_Id; }
            set { _Email_Id = value; }
        }
        private string _Email_Id;

        public string Alt_Email_Id
        {
            get { return _Alt_Email_Id; }
            set { _Alt_Email_Id = value; }
        }
        private string _Alt_Email_Id;

        public string Phone_No
        {
            get { return _Phone_No; }
            set { _Phone_No = value; }
        }
        private string _Phone_No;

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        private string _Gender;

        public System.DateTime Date_Of_Birth
        {
            get { return _Date_Of_Birth; }
            set { _Date_Of_Birth = value; }
        }
        private System.DateTime _Date_Of_Birth;

        public string About_member
        {
            get { return _About_member; }
            set { _About_member = value; }
        }
        private string _About_member;

        public short Is_married
        {
            get { return _Is_married; }
            set { _Is_married = value; }
        }
        private short _Is_married;

        public System.DateTime Wed_anniversary
        {
            get { return _Wed_anniversary; }
            set { _Wed_anniversary = value; }
        }
        private System.DateTime _Wed_anniversary;

        public string Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
        }
        private string _Rating;

        public string Address_Id
        {
            get { return _Address_Id; }
            set { _Address_Id = value; }
        }
        private string _Address_Id;

        public string Media_Id_Img
        {
            get { return _Media_Id_Img; }
            set { _Media_Id_Img = value; }
        }
        private string _Media_Id_Img;

        public string Extn
        {
            get { return _Extn; }
            set { _Extn = value; }
        }
        private string _Extn;

        public System.DateTime Created_Date
        {
            get { return _Created_Date; }
            set { _Created_Date = value; }
        }
        private System.DateTime _Created_Date;

        public System.DateTime Updated_Date
        {
            get { return _Updated_Date; }
            set { _Updated_Date = value; }
        }
        private System.DateTime _Updated_Date;

        public string Created_by
        {
            get { return _Created_by; }
            set { _Created_by = value; }
        }
        private string _Created_by;

        public string Updated_by
        {
            get { return _Updated_by; }
            set { _Updated_by = value; }
        }
        private string _Updated_by;

        public Profile(

            string Usr_Id,
            string First_Name,
            string Last_Name,
            string Email_Id,
            string Alt_Email_Id,
            string Phone_No,
            string Gender,
            System.DateTime Date_Of_Birth,
            string About_member,
            short Is_married,
            System.DateTime Wed_anniversary,
            string Rating,
            string Address_Id,
            string Media_Id_Img,
            System.DateTime Created_Date,
            System.DateTime Updated_Date,
            string Created_by,
            string Updated_by,
            string Extn)
        {


            this._Usr_Id = Usr_Id;
            this._First_Name = First_Name;
            this._Last_Name = Last_Name;
            this._Email_Id = Email_Id;
            this._Alt_Email_Id = Alt_Email_Id;
            this._Phone_No = Phone_No;
            this._Gender = Gender;
            this._Date_Of_Birth = Date_Of_Birth;
            this._About_member = About_member;
            this._Is_married = Is_married;
            this._Wed_anniversary = Wed_anniversary;
            this._Rating = Rating;
            this._Address_Id = Address_Id;
            this._Media_Id_Img = Media_Id_Img;
            this._Created_Date = Created_Date;
            this._Updated_Date = Updated_Date;
            this._Created_by = Created_by;
            this._Updated_by = Updated_by;
            this._Extn = Extn;
        }
    }
}