using Student_Tracker_Blazor;

namespace Student_Tracker_Blazor
{
    public class Login
    {
        public void LoginThing()
        {
            Console.WriteLine("Hello World! Imma make a student, an admin, and a teacher!");
            Student student = new Student();
            student.username = "Sarah Bigbrain";
            student.enumber = "E1";
            student.emailaddr = "thingy@email.com.gov";
            student.password = "123";

            Admin admin = new Admin();
            admin.username = "Bobby Bigbrain";
            admin.enumber = "E2";
            admin.emailaddr = "useless@email.net.dev";
            admin.password = "456";

            Teacher teacher = new Teacher();
            teacher.username = "Tiara Bigbrain";
            teacher.enumber = "E2";
            teacher.emailaddr = "pointless@email.gov.thing";
            teacher.password = "789";

            Console.WriteLine($"Here is the student!\nName: {student.username}\nEnumber: {student.enumber}\nEmail: {student.emailaddr}\nPassword: {student.password}\n");
            Console.WriteLine($"Here is the admin!\nName: {admin.username}\nEnumber: {admin.enumber}\nEmail: {admin.emailaddr}\nPassword: {admin.password}\n");
            Console.WriteLine($"Here is the teacher!\nName: {teacher.username}\nEnumber: {teacher.enumber}\nEmail: {teacher.emailaddr}\nPassword: {teacher.password}\n");
        }
    }
}

