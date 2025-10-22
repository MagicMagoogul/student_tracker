using System.Security.Cryptography;
using System.Text;
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
            set
            {
                    password = value;
                    HashPassword();
            }
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

        public void HashPassword()
        {
            password = GetHashString(password);
        }

        public void UpdatePassword(string newPassword)
        {
            //Some manner of login to make sure that the updated password is being updated by a valid user
            //Possible Admin login as well?
            password = newPassword;
            HashPassword();
        }

        private static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
