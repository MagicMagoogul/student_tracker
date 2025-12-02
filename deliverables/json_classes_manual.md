### JSON Classes

There are various classes meant to reflect the exact json returned by the database API. You can think of these as dictionaries, e.g., UserJson.emailaddr = "name@site.com" would the same as User\["emailaddr"\] = "name@site.com" if we were using actual dictionaries.

### User

__async Task<string> CreateUserAsync(UserJson user)__<br/>
Given user.userId is ignored.<br/>
_returns_: UserJson object containing id assigned by the database. Returns a UserJson object with -1 id on failure.<br/>

__async Task<List<UserJson>> GetUsersAsync()__<br/>
_returns_: list containing all users in the database.<br/>

__async Task<UserJson> GetUserAsync(int userId)__<br/>
_returns_: User corresponding to given userId.<br/>

__async Task<string> UpdateUserAsync(int userId, UserJson user)__<br/>
Updates user corresponding to userId with the values from given UserJson.<br/>
_returns_: string containing response code.<br/>

__async Task<string> DeleteUserAsync(int userId)__<br/>
Deletes user corresponding to userId.<br/>
_returns_: string containing response code.<br/>


### Student

__async Task<string> CreateStudentAsync(StudentJson student)__<br/>
Given student.userId and student.studentId is ignored.<br/>
_returns_: StudentJson object containing id assigned by the database. Returns a StudentJson object with -1 id on failure.<br/>

__async Task<bool> CreateStudentAsync(UserJson user, StudentJson student)__<br/>
Given user.userId, user.role, student.userId, and student.studentId is ignored.
_returns_: True on success, false on failure.<br/>

__async Task<List<StudentJson>> GetStudentsAsync()__<br/>
_returns_: list containing all student in the database.<br/>

__async Task<StudentJson> GetStudentAsync(int userId)__<br/>
_returns_: Student corresponding to given userId.<br/>

__async Task<string> UpdateStudentAsync(int userId, StudentJson student)__<br/>
_returns_: string containing response code.<br/>
Updates student corresponding to userId with the values from given StudentJson.<br/>

__async Task<string> DeleteStudentAsync(int userId)__<br/>
_returns_: string containing response code.<br/>
Deletes student corresponding to userId.<br/>


### Teacher

__async Task<string> CreateTeacherAsync(TeacherJson teacher)__<br/>
Given student.userId and student.studentId is ignored.<br/>
_returns_: StudentJson object containing id assigned by the database. Returns a StudentJson object with -1 id on failure.<br/>

__async Task<bool> CreateStudentAsync(UserJson user, StudentJson student)__<br/>
Given user.userId, user.role, teacher.userId, and teacher.professorId is ignored.<br/>
_returns_: True on success, false on failure.<br/>

__async Task<List<TeacherJson>> GetTeachersAsync()__<br/>
_returns_: list containing all teachers in the database.<br/>

__async Task<TeacherJson> GetTeacherAsync(int teacherId)__<br/>
_returns_: Teacher corresponding to given teacherId.<br/>

__async Task<string> UpdateTeacherAsync(int teacherId, TeacherJson teacher)__<br/>
_returns_: string containing response code.<br/>
Updates teacher corresponding to teacherId with the values from given TeacherJson.<br/>

__async Task<string> DeleteTeacherAsync(int teacherId)__<br/>
_returns_: string containing response code.<br/>
Deletes teacher corresponding to teacherId.<br/>


### Admin

__async Task<string> CreateAdminAsync(AdminJson admin)__<br/>
Given admin.userId and admin.adminId is ignored.<br/>
_returns_: AdminJson object containing id assigned by the database. Returns a AdminJson object with -1 id on failure.<br/>

__async Task<bool> CreateAdminAsync(UserJson user, AdminJson admin)__<br/>
Given user.userId, user.role, admin.userId, and admin.adminId is ignored.<br/>
_returns_: True on success, false on failure.<br/>

__async Task<List<AdminJson>> GetAdminsAsync()__<br/>
_returns_: list containing all admins in the database.<br/>

__async Task<AdminJson> GetAdminAsync(int adminId)__<br/>
_returns_: Admin corresponding to given adminId.<br/>

__async Task<string> UpdateAdminAsync(int adminId, AdminJson admin)__<br/>
_returns_: string containing response code.<br/>
Updates admin corresponding to adminId with the values from given AdminJson.<br/>

__async Task<string> DeleteAdminAsync(int adminId)__<br/>
_returns_: string containing response code.<br/>
Deletes admin corresponding to adminId.<br/>
