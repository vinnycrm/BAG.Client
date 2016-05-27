using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.CustomObject
{
    public class EditContact
    {

        public EditContact()
        { }


        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Name;

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }
        private string _EmailId;

        public string Phone_No
        {
            get { return _Phone_No; }
            set { _Phone_No = value; }
        }
        private string _Phone_No;


        public EditContact(

            string Id,
            string Name,
            string EmailId,
            string Phone_No)
        {


            this._Id = Id;
            this._Name = Name;
            this._EmailId = EmailId;
            this._Phone_No = Phone_No;
        }
    }
}
