using System.Text.Json.Serialization;

namespace Student_Tracker_Blazor
{
    public class TeacherJson
    {
        [JsonPropertyName("professor_id")]
        public int professorId { get; set; }

        [JsonPropertyName("user_id")]
        public int userId { get; set; }

        public TeacherJson()
        {
            professorId = -1;
            userId = -1;
        }
    }
}
