using Student_Tracker_Blazor;

namespace Student_Tracker_Blazor
{
    public class Login
    {
        User currentUser;
        public User LoginInterface()
        {   /*
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
            */

            bool notLoggedIn = true;
            currentUser = new User();

            User testUser = new User();
            testUser.Password = "bingus";
            testUser.Emailaddr = "thingy@gmail.com";  // This will not be in the final product. Be sure to delete this when you're working on things. 

            while (notLoggedIn)
            {
                Console.Write("This is a login! What is your email address?\t");
                currentUser.Emailaddr = Console.ReadLine();

                Console.Write("What is your password?\t");
                currentUser.Password = Console.ReadLine();

                if ((currentUser.Emailaddr == testUser.Emailaddr) && (currentUser.Password == testUser.Password))  // Instead of this, the program should search through the database for the email address
                                                                                                     // and then compare the password hash with the database's version of the password for the email
                {
                    notLoggedIn = false;
                    Console.WriteLine("Congratulations! You logged in!");
                    //From here, the database should be referenced to load in all the user information to be used for the rest of the program.
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    return currentUser;
                }
                else
                {
                    Console.WriteLine("Something went wrong! Try again!");
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            currentUser = new User();
            return currentUser;

        }

        public User Logout()
        {
            currentUser = new User();
            return currentUser;
        }
    }
}
