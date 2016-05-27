using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.CustomObject
{
    public class GoogleContacts
    {
        public GoogleContacts()
        {

        }
        public string EmailID
        {
            get { return _EmailID; }
            set { _EmailID = value; }
        }
        private string _EmailID;

        public bool Selected
        {
            get { return _Selected; }
            set { _Selected = value; }
        }
        private bool _Selected;

        public string ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }
        private string _ContactNo;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Name;

        public string GroupId
        {
            get { return _GroupId; }
            set { _GroupId = value; }
        }
        private string _GroupId;

        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        private string _UserId;

        public GoogleContacts(

         string EmailId,
         string UserId)
        {
            this._EmailID = EmailId;
            this._UserId = UserId;
        }

        public GoogleContacts(

         string EmailId,
         string UserId,
         bool Selected,
         string GroupId)
        {
            this._EmailID = EmailId;
            this._UserId = UserId;
            this._Selected = Selected;
            this._GroupId = GroupId;
        }

        public GoogleContacts(

        string UserId,
        string EmailID,
        string Name,
        string ContactNo)
        {

            this._UserId = UserId;
            this._EmailID = EmailID;
            this._Name = Name;
            this._ContactNo = ContactNo;
        }
    }
}
