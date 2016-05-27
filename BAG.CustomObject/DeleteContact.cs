using System;

namespace BAG.CustomObject
{
    public class DeleteContact
    {

        public DeleteContact()
        { }


        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;

        public string Contact_Id
        {
            get { return _Contact_Id; }
            set { _Contact_Id = value; }
        }
        private string _Contact_Id;


        public DeleteContact(

            string Id,
            string Role_Name)
        {


            this._Id = Id;
            this._Contact_Id = Contact_Id;
        }
    }
}