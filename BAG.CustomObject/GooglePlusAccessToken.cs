using System;

namespace BAG.CustomObject
{
    public class GooglePlusAccessToken
    {
       
        public GooglePlusAccessToken()
        { }


        public string access_token
        {
            get { return _access_token; }
            set { _access_token = value; }
        }
        private string _access_token;

        public string token_type
        {
            get { return _token_type; }
            set { _token_type = value; }
        }
        private string _token_type;

        public string expires_in
        {
            get { return _expires_in; }
            set { _expires_in = value; }
        }
        private string _expires_in;

    }
}