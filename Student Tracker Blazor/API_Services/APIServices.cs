namespace Student_Tracker_Blazor
{
    public class APIServices
    {
        private readonly HttpClient _httpClient;

        public APIServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:8000/");
        }

        //public async Task<List<User>> GetUsersAsync()
        //{
        //
        //}
    }
}
