using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
                case "admin":
                    navMan.NavigateTo("/adminaddadmin");
                    break;
                case "student":
                    navMan.NavigateTo("/adminaddstudent");
                    break;
                case "professor":
                    navMan.NavigateTo("/adminaddprofessor");
                    break;
            }
        }

        public async void AddAdmin(string emailAddr, string password, string firstName, string lastName)
        {
            UserJson user = new UserJson();

            user.emailaddr = emailAddr;
            user.password = password;
            user.firstName = firstName;
            user.lastName = lastName;
            user.createdAt = DateTime.Now.ToString();
            user.updatedAt = DateTime.Now.ToString();


            AdminJson andmin = new AdminJson();

           
            await APIServices.CreateAdminAsync(user, andmin);
        }

        public async void AddProfessor(string emailAddr, string password, string firstName, string lastName)
        {
            UserJson user = new UserJson();

            user.emailaddr = emailAddr;
            user.password = password;
            user.firstName = firstName;
            user.lastName = lastName;
            user.createdAt = DateTime.Now.ToString();
            user.updatedAt = DateTime.Now.ToString();


            TeacherJson professor = new TeacherJson();
 

            await APIServices.CreateTeacherAsync(user, professor);
        }

        public async void AddStudent(string emailAddr, string password, string firstName, string lastName, string enumber, int professorId)
        {
            UserJson user = new UserJson();

            user.emailaddr = emailAddr;
            user.password = password;
            user.firstName = firstName;
            user.lastName = lastName;
            user.createdAt = DateTime.Now.ToString();
            user.updatedAt = DateTime.Now.ToString();


            StudentJson student = new StudentJson();
            student.enumber = enumber;
            student.professorId = professorId;

            await APIServices.CreateStudentAsync(user, student);
        }



    }
}
