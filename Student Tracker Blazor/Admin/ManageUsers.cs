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

        public ManageUsers() { }

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
                    navMan.NavigateTo("/adminaddadmin");
                    break;
                case "student":
                    break;
                case "professor":
                    break;
            }
        }

        public void AddAdmin(string emailAddr, string password, string firstName, string lastName)
        {
            UserJson user = new UserJson();

            user.emailaddr = emailAddr;
            user.password = password;
            user.firstName = firstName;
            user.lastName = lastName;
            user.createdAt = DateTime.Now.ToString();
            user.updatedAt = DateTime.Now.ToString();


            AdminJson andmin = new AdminJson();

           
            APIServices.CreateAdminAsync(user, andmin);
        }
    }
}
