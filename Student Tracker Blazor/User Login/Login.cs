using Student_Tracker_Blazor;

namespace Student_Tracker_Blazor
{
    public class Login
    {
        public void LoginThing()
        {
            Console.WriteLine("Hello World! Imma make a student, an admin, and a teacher!");
            Student student = new Student();
            student.FirstName = "Sarah";
            student.LastName = "Bigbrain";
            student.ENumber = "E1";
            student.Emailaddr = "thingy@email.com.gov";
            student.Password = "123";

            Admin admin = new Admin();
            admin.FirstName = "Bobby Bigbrain";
            admin.Emailaddr = "useless@email.net.dev";
            admin.Password = "456";

            Teacher teacher = new Teacher();
            teacher.FirstName = "Tiara Bigbrain";
            teacher.Emailaddr = "pointless@email.gov.thing";
            teacher.Password = "789";

            Console.WriteLine($"Here is the student!\nName: {student.FirstName}\nEnumber: {student.ENumber}\nEmail: {student.Emailaddr}\nPassword: {student.Password}\n");
            Console.WriteLine($"Here is the admin!\nName: {admin.FirstName}\nEmail: {admin.Emailaddr}\nPassword: {admin.Password}\n");
            Console.WriteLine($"Here is the teacher!\nName: {teacher.FirstName}\nEmail: {teacher.Emailaddr}\nPassword: {teacher.Password}\n");
        }
    }
}
