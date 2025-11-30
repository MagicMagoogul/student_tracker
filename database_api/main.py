from fastapi import FastAPI, Request
from database_operations import *
from models import *

app = FastAPI()

@app.get("/")
async def root():
    return { "message": "this is the student tracker app API" }


# User

@app.get("/users/")
async def read_users():
    users = get_users()
    if not users:
        return
    user_list = list()
    for user in users:
        user_list.append(user.json())
    return user_list


@app.get("/users/{userId}")
async def read_user(userId: str = ""):
    user = get_user(int(userId))
    if not user:
        return
    return user.json()


@app.put("/users/{userId}", response_model=dict)
async def update_user(userId: str, updated_user: dict):
    user = user_update(int(userId), updated_user)
    return user.json()


@app.post("/users/", response_model=dict)
async def create_user(new_user: dict):
    try:
        print(new_user)
        user = user_create(new_user)
        return user.json()
    except Exception as e:
        print(f"create_user failed: {e}")
        return


@app.delete("/users/{userId}")
async def delete_user(userId: str):
    user_delete(int(userId))


# Student

@app.get("/students/")
async def read_students():
    students = get_students()
    if not students:
        return
    student_list = list()
    for student in students:
        student_list.append(student.json())
    return student_list


@app.get("/students/{userId}")
async def read_student(userId: str = ""):
    student = get_student(int(userId))
    if not student:
        return
    return student.json()


@app.get("/students/enumber/{enumber}")
async def read_student_by_enumber(enumber: str = ""):
    student = get_student(int(userId))
    if not student:
        return
    return student.json()


@app.put("/students/{studentId}", response_model=dict)
async def update_student(studentId: str, updated_student: dict):
    student = student_update(int(studentId), updated_student)
    return student.json()


@app.post("/students/", response_model=dict)
async def create_student(new_student: dict):
    try:
        student = student_create(new_student)
        return student.json()
    except Exception as e:
        print(f"create_student failed: {e}")
        return


@app.delete("/students/{studentId}")
async def delete_student(studentId: str):
    student_delete(int(studentId))


# Professor

@app.get("/professors/")
async def read_professors():
    professors = get_professors()
    if not professors:
        return
    professor_list = list()
    for professor in professors:
        professor_list.append(professor.json())
    return professor_list


@app.get("/professors/{userId}")
async def read_professor(userId: str = ""):
    professor = get_professor(int(userId))
    if not professor:
        return
    return professor.json()


@app.get("/professors/students/{userId}")
async def read_professor_students(userId: str = ""):
    students = get_professor_students()
    if not students:
        return
    student_list = list()
    for student in students:
        student_list.append(student.json())
    return student_list


@app.put("/professors/{professorId}", response_model=dict)
async def update_professor(professorId: str, updated_professor: dict):
    professor = professor_update(int(professorId), updated_professor)
    return professor.json()


@app.post("/professors/", response_model=dict)
async def create_professor(new_professor: dict):
    try:
        professor = professor_create(new_professor)
        return professor.json()
    except Exception as e:
        print(f"create_professor failed: {e}")
        return


@app.delete("/professors/{professorId}")
async def delete_professor(professorId: str):
    professor_delete(int(professorId))


# Admin

@app.get("/admins/")
async def read_admins():
    admins = get_admins()
    if not admins:
        return
    admin_list = list()
    for admin in admins:
        admin_list.append(admin.json())
    return admin_list


@app.get("/admins/{userId}")
async def read_admin(userId: str = ""):
    admin = get_admin(int(userId))
    if not admin:
        return
    return admin.json()


@app.put("/admins/{adminId}", response_model=dict)
async def update_admin(adminId: str, updated_admin: dict):
    admin = admin_update(int(adminId), updated_admin)
    return admin.json()


@app.post("/admins/", response_model=dict)
async def create_admin(new_admin: dict):
    try:
        admin = admin_create(new_admin)
        return admin.json()
    except Exception as e:
        print(f"create_admin failed: {e}")
        return


@app.delete("/admins/{adminId}")
async def delete_admin(adminId: str):
    admin_delete(int(adminId))


# HoursLogged

@app.get("/hourslogged/")
async def read_all_hours_logged():
    hours_logged = get_all_hours_logged()
    if not hours_logged:
        return
    hours_logged_list = list()
    for hours in hours_logged:
        hours_logged_list.append(hours.json())
    return hours_logged_list


@app.get("/hourslogged/hoursLoggedId/{hoursLoggedId}")
async def read_hours_logged(hoursLoggedId: str = ""):
    hours_logged = get_hours_logged(int(hoursLoggedId))
    if not hours_logged:
        return
    return hours_logged.json()


@app.get("/hourslogged/students/{studentId}")
async def read_hours_logged_by_students(studentId: str = ""):
    hours_logged = get_hours_logged_for_student(int(studentId))
    if not hours_logged:
        return
    hours_logged_list = list()
    for hours in hours_logged:
        hours_logged_list.append(hours.json())
    return hours_logged_list


@app.put("/hourslogged/{hoursLoggedId}", response_model=dict)
async def update_hours_logged(hoursLoggedId: str, updated_hours_logged: dict):
    hours_logged = hours_logged_update(int(hoursLoggedId), update_hours_logged)
    return hours_logged.json()


@app.post("/hourslogged/", response_model=dict)
async def create_hours_logged(new_hours_logged: dict):
    try:
        hours_logged = hours_logged_create(new_hours_logged)
        return hours_logged.json()
    except Exception as e:
        print(f"create_hours_logged failed: {e}")
        return


@app.delete("/hourslogged/{hoursLoggedId}")
async def delete_hours_logged(hoursLoggedId: str):
    hours_logged_delete(int(hoursLoggedId))


def main():
    database_init()


main()
