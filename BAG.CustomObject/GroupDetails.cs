using System;

namespace BAG.CustomObject
{
    public class GroupDetails
    {

        public GroupDetails()
        { }


        public string Group_Id
        {
            get { return _Group_Id; }
            set { _Group_Id = value; }
        }
        private string _Group_Id;

        public string Group_Name
        {
            get { return _Group_Name; }
            set { _Group_Name = value; }
        }
        private string _Group_Name;

        public string User_Id
        {
            get { return _User_Id; }
            set { _User_Id = value; }
        }
        private string _User_Id;

        public GroupDetails(

            string Group_Id,
            string Group_Name)
        {


            this._Group_Id = Group_Id;
            this._Group_Name = Group_Name;
        }

        public GroupDetails(

            string Group_Id,
            string Group_Name,
            string User_Id)
        {


            this._Group_Id = Group_Id;
            this._Group_Name = Group_Name;
            this._User_Id = User_Id;
        }
    }
}