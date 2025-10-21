using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public class Student : User
    {
        private string studentId;
        private string professorId;

        private string enumber;

        public Student()
        {
            studentId = "";
            professorId = "";

            enumber = "";
        }

        public string StudentID
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string ProfessorID
        {
            get { return professorId; }
            set { professorId = value; }
        }

        public string ENumber
        {
            get { return enumber; }
            set { enumber = value; }
        }
    }
}
