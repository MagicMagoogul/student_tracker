using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public class Admin : User
    {
        public Admin()
        {
            username = null;
            enumber = null;
            emailaddr = null;
            password = null;
            permissions = new bool[10];
        }
        private string Username
        {
            get { return username; }
            set { username = value; }
        } //Username getter and setter
        public string Enum
        {
            get { return username; }
            set { username = value; }
        } //Enum getter and setter
        public string Emailaddr
        {
            get { return emailaddr; }
            set { emailaddr = value; }
        } //Email address getter and setter
        public string Password
        {
            get { return password; }
            set { password = value; }
        } //Password getter and setter
        public bool[] Permissions
        {
            get { return permissions; }
            set { permissions = value; } //Needs to be changed
        } //Permissions getter and setter
    }
}
