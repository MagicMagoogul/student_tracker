# Developer Manual
## Glossary (of important terms)
    -Important Terms-
    -
    -
    -
---    
## Development environment & setup
The development environment and setup for this project is the 

---
## Coding standards
The coding standard for this project 

---
## Development standards


---
## Data dictionary

### Users Table

| Column Name | Type | NotNull | Primary Key | Foreign Key |
| ----  | ---- | ---- | ---- | ---- |
| UserId | INTEGER | True | True | False |
| EmailAddr | TEXT | False | False | False |
| FirstName | TEXT | True | False | False |
| LastName | TEXT | True | False | False |
| Password | TEXT | True | False | False |
| CreatedAt | TEXT | True | False | False |
| UpdatedAt | TEXT | True | False | False |
| Role | TEXT | True | False | False |

### Professors Table

| Column Name | Type | NotNull | Primary Key | Foreign Key |
| ----  | ---- | ---- | ---- | ---- |
| ProfessorId | INTEGER | True | True | False |
| UserId | INTEGER | True | False | True |

### Admins Table

| Column Name | Type | NotNull | Primary Key | Foreign Key |
| ----  | ---- | ---- | ---- | ---- |
| AdminId | INTEGER | True | True | False |
| UserId | INTEGER | True | False | True |

### Students Table

| Column Name | Type | NotNull | Primary Key | Foreign Key |
| ----  | ---- | ---- | ---- | ---- |
| StudentId | INTEGER | True | True | False |
| ENumber | TEXT | True | False | False |
| UserId | INTEGER | True | False | True |
| ProfessorId | INTEGER | True | False | True |

### Hours Logged Table

| Column Name | Type | NotNull | Primary Key | Foreign Key |
| ----  | ---- | ---- | ---- | ---- |
| HoursLoggedId | INTEGER | True | True | False |
| StudentId | INTEGER | False | False | True |
| Hours | TEXT | True | False | False |
| Location | TEXT | True | False | False |
| ShiftDate | TEXT | True | False | False |
| LoggingDate | TEXT | True | False | False |

### Additional Notes

All ID fields are auto-incremented.

---
## Link to the Architectural design document 

---
## Link to the Detailed design document (Class model; Data Flow Diagrams; ...)

---
## Test process, link to Test plans, link to test scripts, test execution tools, etc. 

---
## Issue tracking tool

---
## Project management tool

---
## Build and Deployment (Procedure)

---
## Rationale behind specific design decisions

---
## Troubleshooting guide (Any specific helpful information regarding known issues)
If the need for troubleshooting occurs, some possible issues you will run into is:
        Q: No connection between the database and website.
        A: You probably have not started the API, run the API run program.
        -
        Q: I cannot create a user, or access any admin pages.
        A: You have probably not signed in as an admin user, you will need to sign into a user with admin priveleges.
        -
        Q: I run into a error logging student hours. 
        A: You have probably not signed into a user account yet. Sign into a user account and your problem will probably be finished.
        
---






































This is what was here before

---
---
---
---
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
