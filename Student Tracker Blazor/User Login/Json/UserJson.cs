using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace Student_Tracker_Blazor
{
    public class UserJson
    {
        private string _password;

        [JsonPropertyName("user_id")]
        public int userId { get; set; }

        [JsonPropertyName("emailaddr")]
        public string emailaddr { get; set; }

        [JsonPropertyName("password")]
        public string password
        {
            get => _password;
            set 
            {
                _password = value;
            }
        }


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
            _password = "";

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

        public void HashPassword()
        {
            _password = GetHashString(_password);
        }

        private static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
