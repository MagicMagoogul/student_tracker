using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public abstract class User
    {
        private string userId;

        private string emailaddr;
        private string password;

        private string firstName;
        private string lastName;

        private string createdAt;
        private string updatedAt;

        public User()
        {
            userId = "";

            emailaddr = "";
            password = "";

            firstName = "";
            lastName = "";

            createdAt = "";
            updatedAt = "";

        }

        public string UserID
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Emailaddr
        {
            get { return emailaddr; }
            set { emailaddr = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FirstName
        {
          get { return firstName; }
          set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public string UpdatedAt
        {
            get { return updatedAt; }
            set { updatedAt = value; }
        }
    }
}
