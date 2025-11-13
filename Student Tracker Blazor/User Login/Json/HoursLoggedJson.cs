using System.Text.Json.Serialization;

namespace Student_Tracker_Blazor
{
    public class HoursLoggedJson
    {
        [JsonPropertyName("hours_logged_id")]
        public int hoursLoggedId { get; set; }

        [JsonPropertyName("student_id")]
        public int studentId { get; set; }

        [JsonPropertyName("hours")]
        public string hours { get; set; }

        [JsonPropertyName("location")]
        public string location { get; set; }

        [JsonPropertyName("shift_date")]
        public string shiftDate { get; set; }

        [JsonPropertyName("logging_date")]
        public string loggingDate { get; set; }

        public HoursLoggedJson()
        {
            hoursLoggedId = -1;
            studentId = -1;
            hours = "";
            location = "";
            shiftDate = "";
            loggingDate = "";
        }
    }
}
