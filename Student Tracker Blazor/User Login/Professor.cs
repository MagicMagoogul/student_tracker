using Student_Tracker_Blazor.Components;

namespace Student_Tracker_Blazor
{
    public class Professor : User
    {
        private string professorId;

        public Professor()
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
