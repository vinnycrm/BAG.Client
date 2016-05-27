using System;

namespace BAG.CustomObject
{
    public class EventTypes
    {
        public EventTypes()
        { }

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;

        public string Event_Name
        {
            get { return _Event_Name; }
            set { _Event_Name = value; }
        }
        private string _Event_Name;

        public EventTypes(

        string Id,
        string First_Name)
        {
            this._Id = Id;
            this._Event_Name = First_Name;
        }
    }
}