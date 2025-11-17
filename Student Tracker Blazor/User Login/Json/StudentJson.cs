using System.Text.Json.Serialization;

namespace Student_Tracker_Blazor
{
    public class StudentJson
    {
        [JsonPropertyName("student_id")]
        public int studentId { get; set; }

        [JsonPropertyName("user_id")]
        public int userId { get; set; }

        [JsonPropertyName("enumber")]
        public string enumber { get; set; }

        [JsonPropertyName("professor_id")]
        public int professorId { get; set; }

        public StudentJson()
        {
            studentId = -1;
            userId = -1;
            enumber = "";
            professorId = -1;
        }
    }
}
