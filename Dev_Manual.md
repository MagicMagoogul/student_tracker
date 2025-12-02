# Developer Manual
## Glossary (of important terms)
    -Important Terms-
    -
    -
    -
---    
## Development environment & setup
The development environment and setup for this project requires Microsoft Visual Studio 2022 with the Blazor development package installed, as well as a standard installation of python. Missing python dependencies are installed automatically.

---
## Coding standards
The coding standard for this project are quite typical, we follow the regular capitalization standards that are recommended for C# development, as well as the typical standards for python, in the case of our database API written in python. We also stick to the same way of organizing C# classes, especially in the case of getters and setters.

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
- see the architecture doc: located in a sub-folder
---
## Link to the Detailed design document (Class model; Data Flow Diagrams; ...)
- see the detailed design doc: located in a sub-folder
---
## Test process, link to Test plans, link to test scripts, test execution tools, etc. 
Unit Tests–
- Test 1: Used console commands to test user class object functionality.
- Test 2: Tested API code for proper conversion from user classes to JSON format.
- Test 3: Tested Blazor site routing for Admin management pages.
- Test 4: Tested database table structure by creating dummy data.

Integration Tests–
- Test 1: Tested for correct interactions between Log Hours page and Hours Logged database table, as facilitated by API.
- Test 2: Ensured Admin Manage Users page properly creates and pushes new users to the database through API. 
- Test 3: Determined that the View Student Records page is pulling correct information from the database tables.
- Test 4: Tested user logging in and matching hashed password to database password hash.

System Tests–
- Walked through software to ensure that users can log in, admin users can create, update and delete users, instructors can view records of and message their students, and students can log their working hours.

---
## Issue tracking tool
We also use our development discord server for our issue tracking.

---
## Project management tool
We use Miro for managing our project.

---
## Build and Deployment (Procedure)
First, ensure that python is installed and run RunAPI.bat. It will automatically install any missing dependencies and begin running the database API. Next, open the .sln file and hit run to automatically build and run the web application.

---
## Rationale behind specific design decisions
 In the design of this application, we decided to go with a frog (“phog”) image as our mascot on the tab design. Our company name is “Phog Unlimited LLC - a protected series LLC undetermined etc” so we felt that image was in line with our mission statement of our company. We had a dark navigation menu to make it stand out more. Also, our background was a light greenish color in order to make it pleasing to the eye. Some other design choices we had were the font types throughout the application. We did try to use Times New Roman only, but some of the web pages were stuck on using the Comic Sans font even though we had tried several times to change which font it would use, but apparently it is a load bearing wall/ we were cursed so we couldn't figure out what was causing the font to keep appearing.
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
