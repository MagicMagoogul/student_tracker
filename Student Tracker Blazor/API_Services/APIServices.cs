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

        /// <summary>Given user.userId is ignored.</summary>
        /// <returns>UserJson object containing id assigned by the database.
        ///  Returns a UserJson object with -1 id on failure.</returns>
        public static async Task<UserJson> CreateUserAsync(UserJson user)
        {
            var response = await _httpClient.PostAsJsonAsync("users/", user);
            response.EnsureSuccessStatusCode();
            Task<UserJson> userJson = response.Content.ReadFromJsonAsync<UserJson>();
            if (userJson != null)
            {
                return userJson.Result;
            }
            return new UserJson();
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

        public static async Task<bool> CheckUserPassword(int userId, string password_hash)
        {
            var response = await _httpClient.GetFromJsonAsync<bool>($"users/password/{userId}?password={password_hash}");
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

        /// <summary>Given student.userId and student.studentId is ignored.</summary>
        /// <returns>StudentJson object containing id assigned by the database.
        ///  Returns a StudentJson object with -1 id on failure.</returns>
        public static async Task<StudentJson> CreateStudentAsync(StudentJson student)
        {
            var response = await _httpClient.PostAsJsonAsync("students/", student);
            response.EnsureSuccessStatusCode();
            Task<StudentJson> studentJson = response.Content.ReadFromJsonAsync<StudentJson>();
            if (studentJson != null)
            {
                return studentJson.Result;
            }
            return new StudentJson();
        }

        /// <summary>Given user.userId, user.role, student.userId, and student.studentId is ignored.</summary>
        /// <returns>True on success, false on failure.</returns>
        public static async Task<bool> CreateStudentAsync(UserJson user, StudentJson student)
        {
            user.role = "student";
            UserJson userJson = await CreateUserAsync(user);
            student.userId = userJson.userId;
            StudentJson studentJson = await CreateStudentAsync(student);
            if (studentJson.studentId != -1)
            {
                return true;
            }
            return false;
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

        /// <summary>Given teacher.userId and teacher.professorId is ignored.</summary>
        /// <returns>TeacherJson object containing id assigned by the database.
        ///  Returns a TeacherJson object with -1 id on failure.</returns>
        public static async Task<TeacherJson> CreateTeacherAsync(TeacherJson teacher)
        {
            var response = await _httpClient.PostAsJsonAsync("professors/", teacher);
            response.EnsureSuccessStatusCode();
            Task<TeacherJson> teacherJson = response.Content.ReadFromJsonAsync<TeacherJson>();
            if (teacherJson != null)
            {
                return teacherJson.Result;
            }
            return new TeacherJson();
        }

        /// <summary>Given user.userId, user.role, teacher.userId, and teacher.professorId is ignored.</summary>
        /// <returns>True on success, false on failure.</returns>
        public static async Task<bool> CreateTeacherAsync(UserJson user, TeacherJson teacher)
        {
            user.role = "professor";
            UserJson userJson = await CreateUserAsync(user);
            teacher.userId = userJson.userId;
            TeacherJson teacherJson = await CreateTeacherAsync(teacher);
            if (teacherJson.professorId != -1)
            {
                return true;
            }
            return false;
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

        /// <summary>Given admin.userId and admin.adminId is ignored.</summary>
        /// <returns>AdminJson object containing id assigned by the database.
        ///  Returns a AdminJson object with -1 id on failure.</returns>
        public static async Task<AdminJson> CreateAdminAsync(AdminJson admin)
        {
            var response = await _httpClient.PostAsJsonAsync("admins/", admin);
            Task<AdminJson> adminJson = response.Content.ReadFromJsonAsync<AdminJson>();
            if (adminJson != null)
            {
                return adminJson.Result;
            }
            return new AdminJson();
        }

        /// <summary>Given user.userId, user.role, admin.userId, and admin.adminId is ignored.</summary>
        /// <returns>True on success, false on failure.</returns>
        public static async Task<bool> CreateAdminAsync(UserJson user, AdminJson admin)
        {
            user.role = "admin";
            UserJson userJson = await CreateUserAsync(user);
            admin.userId = userJson.userId;
            AdminJson adminJson = await CreateAdminAsync(admin);
            if (adminJson.adminId != -1)
            {
                return true;
            }
            return false;
        }

        public static async Task<List<AdminJson>> GetAdminsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<AdminJson>>($"admins/");
            return response;
        }

        public static async Task<AdminJson> GetAdminAsync(int userId)
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

        public static async Task<List<HoursLoggedJson>> GetHoursLoggedByStudentAsync(int studentId)
        {
            var response = await _httpClient.GetFromJsonAsync<List<HoursLoggedJson>>($"hourslogged/students/{studentId}");
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
