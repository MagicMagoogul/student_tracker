using System.Text.Json.Serialization;

namespace Student_Tracker_Blazor
{
    public class UserJson
    {
        [JsonPropertyName("user_id")]
        public int userId { get; set; }

        [JsonPropertyName("emailaddr")]
        public string emailaddr { get; set; }

        [JsonPropertyName("password")]
        public string password { get; set; }

        [JsonPropertyName("first_name")]
        public string firstName { get; set; }
        [JsonPropertyName("last_name")]
        public string lastName { get; set; }

        [JsonPropertyName("created_at")]
        public string createdAt { get; set; }
        [JsonPropertyName("updated_at")]
        public string updatedAt { get; set; }

        [JsonPropertyName("role")]
        public string role { get; set; }

        public UserJson()
        {
            userId = -1;

            emailaddr = "";
            password = "";

            firstName = "";
            lastName = "";

            createdAt = "";
            updatedAt = "";

            role = "";
        }

        public override string ToString()
        {
            return $"{userId}\n{emailaddr}\n{firstName}\n{lastName}\n{createdAt}\n{updatedAt}\n{role}";
        }
    }
}
