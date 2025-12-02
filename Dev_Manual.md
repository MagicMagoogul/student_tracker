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
We also use our development discord server for our issue tracking.

---
## Project management tool
We use Miro for managing our project.

---
## Build and Deployment (Procedure)
First, ensure that python is installed and run RunAPI.bat. It will automatically install any missing dependencies and begin running the database API. Next, open the .sln file and hit run to automatically build and run the web application.

---
## Rationale behind specific design decisions
We opted to have our database operations be cleanly separated from the Blazor server application for the sake of simplicity. The database API is written in python for ease of development, and it handles all transactions via json.<br/>
Blazor and C# were chosen for the front-end for their fast development workflow and wealth of networking-related functionalities.

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
