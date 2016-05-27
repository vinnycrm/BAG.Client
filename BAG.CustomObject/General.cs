using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.CustomObject
{
    public class FaceBookUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
    }

    public class GmailContacts
    {
        public string EmailID
        {
            get { return _EmailID; }
            set { _EmailID = value; }
        }
        private string _EmailID;
    }
}
