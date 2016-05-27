using System;

namespace BAG.CustomObject
{
    public class CreateEvent
    {
        public CreateEvent()
        {

        }
        public string Event_Name
        {
            get { return _Event_Name; }
            set { _Event_Name = value; }
        }
        private string _Event_Name;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private string _Description;

        public DateTime Start_Date
        {
            get { return _Start_Date; }
            set { _Start_Date = value; }
        }
        private DateTime _Start_Date;

        public DateTime End_Date
        {
            get { return _End_Date; }
            set { _End_Date = value; }
        }
        private DateTime _End_Date;

        public string Event_Location
        {
            get { return _Event_Location; }
            set { _Event_Location = value; }
        }
        private string _Event_Location;

        public string User_Id
        {
            get { return _User_Id; }
            set { _User_Id = value; }
        }
        private string _User_Id;

        public string Type_Id
        {
            get { return _Type_Id; }
            set { _Type_Id = value; }
        }
        private string _Type_Id;

        public CreateEvent(

         string Event_Name,
         string Description,
         DateTime Start_Date,
         DateTime End_Date,
         string Event_Location,
         string User_Id,
         string Type_Id)
        {
            this._Event_Name = Event_Name;
            this._Description = Description;
            this._Start_Date = Start_Date;
            this._End_Date = End_Date;
            this._Event_Location = Event_Location;
            this._User_Id = User_Id;
            this._Type_Id = Type_Id;
        }
    }
}