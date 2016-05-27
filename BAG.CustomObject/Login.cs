using System;

namespace BAG.CustomObject
{
    public class Login
    {
        public Login()
        { }
        
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Id;
        
        public string First_Name
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }
        private string _First_Name;

        public Login(

        string Id,
        string First_Name)
        {
            this._Id = Id;
            this._First_Name = First_Name;
        }
    }
}