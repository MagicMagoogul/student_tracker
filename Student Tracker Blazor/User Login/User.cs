using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public abstract class User
    {
        public string username;  //username
        public string enumber;      //Enumber 
        public string emailaddr; //emailaddr
        public string password;  //password
        public bool[] permissions; //bool array for permissions. Probably change to dictionary 

        public User()
        {
            username = null;
            enumber = null;
            emailaddr = null;
            password = null;
            permissions = new bool[10];
        }
        public string Username { get; set; } //Username getter and setter
        public string Enum { get; set; } //Enum getter and setter
        public string Emailaddr { get; set; } //Email address getter and setter
        public string Password { get; set; } //Password getter and setter
        public bool[] Permissions { get; set; } //Permissions getter and setter
    }
}
