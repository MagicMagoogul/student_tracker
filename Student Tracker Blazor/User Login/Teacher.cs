using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public class Teacher : User
    {
        private string professorId;

        public Teacher()
        {
            professorId = "";
        }

        public string ProfessorID
        {
            get { return professorId; }
            set { professorId = value; }
        }
    }
}
