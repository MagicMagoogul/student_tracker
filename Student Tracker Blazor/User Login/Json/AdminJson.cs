using System.Text.Json.Serialization;

namespace Student_Tracker_Blazor
{
    public class AdminJson
    {
        [JsonPropertyName("admin_id")]
        public int adminId { get; set; }

        [JsonPropertyName("user_id")]
        public int userId { get; set; }

        public AdminJson()
        {
            adminId = -1;
            userId = -1;
        }
    }
}
