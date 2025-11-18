using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public class ManageUsers
    {
        private readonly NavigationManager navMan;

        public ManageUsers(NavigationManager nav)
        {
            navMan = nav;
        }


        public void AddUser(string role)
        {
            switch (role)
            {
                //void MethodToTriggerURL()
                    //NavigationManager.NavigateTo("PageToRedirect");
                case "admin":
                    navMan.NavigateTo("/Adminaddadmin");
                    break;
                case "student":
                    break;
                case "professor":
                    break;
            }
        }

        public void AddAdmin(string emailAddr, string password, string firstName, string lastName)
        {
            AdminJson admin = new AdminJson();

            admin.EmailAddr= emailAddr;
            admin.Password = password;
            admin.FirstName = firstName;
            admin.LastName = lastName;
            admin.CreatedAt = DateTime.Now.ToString();
            admin.UpdatedAt = DateTime.Now.ToString();
        }
    }
}
