using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.CustomObject
{
    public class InviteMembers
    {
        public InviteMembers()
        {

        }
        public string EmailID
        {
            get { return _EmailID; }
            set { _EmailID = value; }
        }
        private string _EmailID;

        public string INV_Code
        {
            get { return _INV_Code; }
            set { _INV_Code = value; }
        }
        private string _INV_Code;

        public string ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }
        private string _ContactNo;

        public bool Selected
        {
            get { return _Selected; }
            set { _Selected = value; }
        }
        private bool _Selected;

        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        private string _UserId;

        public InviteMembers(

         string EmailID,
         string UserId,
         string ContactNo,
         string INV_Code,
         bool Selected)
        {
            this._EmailID = EmailID;
            this._UserId = UserId;
            this._ContactNo = ContactNo;
            this._INV_Code = INV_Code;
            this._Selected = Selected;
        }
    }
}
