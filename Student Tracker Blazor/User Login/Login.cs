using Student_Tracker_Blazor;

namespace Student_Tracker_Blazor
{

    //DEV NOTE FROM AURORA:
    // How to use currentUser:
    // make a Login object (ex. Login loginChecker = new();)
    // to know if someone is logged in, check with if loginChecker.currentUser == null;
    // to know their details, remember currentUser returns a JSON object!!
    // but you can just get loginChecker.currentUser.firstName or whatever.


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
