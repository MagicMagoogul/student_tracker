using Student_Tracker_Blazor;

namespace Student_Tracker_Blazor
{
    public class Login
    {
        public UserJson? currentUser { get; private set; }

        public void LogInUser(UserJson user)
        {
            currentUser = user;
        }

        public void LogOutUser()
        {
            currentUser = null;
        }
    }
}
