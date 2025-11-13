using System.Text.Json;
using System.Text.Json.Nodes;

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

        // Users

        public static async Task<string> CreateUserAsync(UserJson user)
        {
            var response = await _httpClient.PostAsJsonAsync("users/", user);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<List<UserJson>> GetUsersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<UserJson>>($"users/");
            return response;
        }

        public static async Task<UserJson> GetUserAsync(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<UserJson>($"users/{userId}");
            return response;
        }

        public static async Task<string> UpdateUserAsync(int userId, UserJson user)
        {
            var response = await _httpClient.PutAsJsonAsync($"users/{userId}", user);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteUserAsync(int userId)
        {
            var response = await _httpClient.DeleteAsync($"users/{userId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        // Students

        public static async Task<string> CreateStudentAsync(StudentJson student)
        {
            var response = await _httpClient.PostAsJsonAsync("students/", student);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<List<StudentJson>> GetStudentsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<StudentJson>>($"students/");
            return response;
        }

        public static async Task<StudentJson> GetStudentAsync(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<StudentJson>($"students/{userId}");
            return response;
        }

        public static async Task<string> UpdateStudentAsync(int userId, StudentJson student)
        {
            var response = await _httpClient.PutAsJsonAsync($"students/{userId}", student);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteStudentAsync(int userId)
        {
            var response = await _httpClient.DeleteAsync($"students/{userId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        // Teacher

        public static async Task<string> CreateTeacherAsync(TeacherJson teacher)
        {
            var response = await _httpClient.PostAsJsonAsync("professors/", teacher);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<List<TeacherJson>> GetTeachersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<TeacherJson>>($"professors/");
            return response;
        }

        public static async Task<TeacherJson> GetTeacherAsync(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<TeacherJson>($"professors/{userId}");
            return response;
        }

        public static async Task<string> UpdateTeacherAsync(int userId, TeacherJson teacher)
        {
            var response = await _httpClient.PutAsJsonAsync($"professors/{userId}", teacher);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteTeacherAsync(int userId)
        {
            var response = await _httpClient.DeleteAsync($"professors/{userId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        // Admin

        public static async Task<string> CreateAdminAsync(AdminJson admin)
        {
            var response = await _httpClient.PostAsJsonAsync("admins/", admin);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<List<AdminJson>> GetAdminAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<AdminJson>>($"admins/");
            return response;
        }

        public static async Task<AdminJson> GetAdminsAsync(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<AdminJson>($"admins/{userId}");
            return response;
        }

        public static async Task<string> UpdateAdminAsync(int userId, AdminJson admin)
        {
            var response = await _httpClient.PutAsJsonAsync($"admins/{userId}", admin);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteAdminAsync(int userId)
        {
            var response = await _httpClient.DeleteAsync($"admins/{userId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        // HoursLogged

        public static async Task<string> CreateHoursLoggedAsync(HoursLoggedJson hoursLogged)
        {
            var response = await _httpClient.PostAsJsonAsync("hourslogged/", hoursLogged);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<List<HoursLoggedJson>> GetHoursLoggedAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<HoursLoggedJson>>($"hourslogged/");
            return response;
        }

        public static async Task<HoursLoggedJson> GetHoursLoggedAsync(int hoursLoggedId)
        {
            var response = await _httpClient.GetFromJsonAsync<HoursLoggedJson>($"hourslogged/hoursLoggedId/{hoursLoggedId}");
            return response;
        }

        public static async Task<HoursLoggedJson> GetHoursLoggedByStudentAsync(int studentId)
        {
            var response = await _httpClient.GetFromJsonAsync<HoursLoggedJson>($"hourslogged/students/{studentId}");
            return response;
        }

        public static async Task<string> UpdateHoursLoggedAsync(int hoursLoggedId, HoursLoggedJson hoursLogged)
        {
            var response = await _httpClient.PutAsJsonAsync($"hourslogged/{hoursLoggedId}", hoursLogged);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteHoursLoggedAsync(int hoursLoggedId)
        {
            var response = await _httpClient.DeleteAsync($"hourslogged/{hoursLoggedId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
