using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public class Admin : User
    {
        private string adminId;

        public Admin()
        {
            adminId = "";
        }

        public string AdminID
        {
            get { return adminId; }
            set { adminId = value; }
        }
    }
}
