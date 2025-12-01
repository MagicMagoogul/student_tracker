

# Student Tracker Application
## Authors: Aurora Liles, Joshua Belfield, Sam Collins, Melanie Magno, and Riley Owen
### Table of Contents
- [Project Overview](#project-overview)
- [Vision](#vision)
- [Directory Breakdown](#directory-breakdown)
---
# Project Overview
We have created a student tracking application that allows student users to log their hours as they work on their clinicals, and allows instructors to view those student logs. We have also created a functionality that allows users to communicate with the instructors and vice versa. Finally, an admin user is able to create and edit all users and information on the web application.

---
# Vision
Our Minimum viable product for this project is that we will have a fully functioning web application that allows nursing students to clock-in/clock-out and mark hours and location on their hospital jobs, and allows teachers to view these records. It will also allow logged in students and teachers to communicate with each other.

---
# Directory Breakdown
    
    /Student Tracker Blazor
    /StudentTracker
    /database_api
      L The full api system to connect the frontend to the backend.
        Contains:
          - database_operations.py: The Data Access Layer (DAL).
          - main.py: creates a FastAPI REST API.
          - models.py: defines all database models (tables).
    /src
      L A src file for VS 2025 functionality
