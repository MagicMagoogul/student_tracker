namespace Student_Tracker_Blazor
{
    public static class APIServices
    {
        private static readonly HttpClient _httpClient;

        static APIServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:8000/");
        }

        public static async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<User>>($"users/");
            foreach (var user in response)
            {
                Console.WriteLine(user.FirstName);
            }
            return response;
        }
    }
}
