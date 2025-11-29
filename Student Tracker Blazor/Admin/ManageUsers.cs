using System.ComponentModel;
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

        public async Task<List<UserJson>> FindAdmin(string firstName, string lastName, string emailAddr)
        {
            List<AdminJson> admins = await APIServices.GetAdminAsync();
            List<UserJson> users = new List<UserJson>();

            foreach (AdminJson admin in admins)
            {
                UserJson user = await APIServices.GetUserAsync(admin.userId);
                if ((user.firstName == firstName || string.IsNullOrEmpty(firstName)) && (user.lastName == lastName || string.IsNullOrEmpty(lastName)) && (user.emailaddr == emailAddr || string.IsNullOrEmpty(emailAddr)))
                {
                    users.Add(user);
                }
            }
            return users;
        }

        public async Task<List<UserJson>> FindStudent(string firstName, string lastName, string emailAddr, string enumber)
        {
            List<StudentJson> students = await APIServices.GetStudentsAsync();
            List<UserJson> users = new List<UserJson>();

            foreach (StudentJson student in students)
            {
                UserJson user = await APIServices.GetUserAsync(student.userId);
                if ((user.firstName == firstName || string.IsNullOrEmpty(firstName)) && (user.lastName == lastName || string.IsNullOrEmpty(lastName)) && (user.emailaddr == emailAddr || string.IsNullOrEmpty(emailAddr)) && (student.enumber == enumber || string.IsNullOrEmpty(enumber)))
                {
                    users.Add(user);
                }
            }
            return users;
        }

        public async Task<List<UserJson>> FindProfessor(string firstName, string lastName, string emailAddr)
        {
            List<TeacherJson> teachers = await APIServices.GetTeachersAsync();
            List<UserJson> users = new List<UserJson>();

            foreach (TeacherJson teacher in teachers)
            {
                UserJson user = await APIServices.GetUserAsync(teacher.userId);
                if ((user.firstName == firstName || string.IsNullOrEmpty(firstName)) && (user.lastName == lastName || string.IsNullOrEmpty(lastName)) && (user.emailaddr == emailAddr || string.IsNullOrEmpty(emailAddr)))
                {
                    users.Add(user);
                }
            }
            return users;
        }

        public async Task<List<UserJson>> FindUnsure(string firstName, string lastName, string emailAddr)
        {
            List<UserJson> users = new List<UserJson>();
            users = await APIServices.GetUsersAsync();

            List<UserJson> usersRet = new List<UserJson>();

            foreach (UserJson user in users)
            {
                if ((user.firstName == firstName || string.IsNullOrEmpty(firstName)) && (user.lastName == lastName || string.IsNullOrEmpty(lastName)) && (user.emailaddr == emailAddr || string.IsNullOrEmpty(emailAddr)))
                {
                    usersRet.Add(user);
                }
            }
            return usersRet;
        }

        public async Task DeleteAdmin(int id)
        {
            AdminJson admin = new();
            admin = await APIServices.GetAdminsAsync(id);

            await APIServices.DeleteAdminAsync(admin.adminId);
            await APIServices.DeleteUserAsync(id);

        }

        public async Task DeleteStudent(int id)
        {
            StudentJson student = new();
            student = await APIServices.GetStudentAsync(id);

            await APIServices.DeleteStudentAsync(student.studentId);
            await APIServices.DeleteUserAsync(id);

        }

        public async Task DeleteProfessor(int id)
        {
            TeacherJson teacher = new();
            teacher = await APIServices.GetTeacherAsync(id);

            await APIServices.DeleteTeacherAsync(teacher.professorId);
            await APIServices.DeleteUserAsync(id);

        }
    }
}
