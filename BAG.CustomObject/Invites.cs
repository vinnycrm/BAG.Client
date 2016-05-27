using System;

namespace BAG.CustomObject
{
    public class Invites
    {
        /// <summary>
        /// Default Contructor
        /// <summary>
        public Invites()
        { }


        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;

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

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        private string _Status;

        public Invites(

            string Id,
            string Email_Id,
            string Phone_No,
            string Status)
        {


            this._Id = Id;
            this._Email_Id = Email_Id;
            this._Phone_No = Phone_No;
            this._Status = Status;
        }
    }
}