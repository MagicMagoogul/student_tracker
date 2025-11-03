from fastapi import FastAPI, Request
from database_operations import database_init, get_users, get_user, user_update, user_create, user_delete, get_students, get_student, get_student_by_user_id, student_create, student_delete, student_update, professor_create, professor_delete, professor_update, get_professor, get_professors, get_professor_by_user_id, admin_create, admin_delete, admin_update, get_admin, get_admin_by_user_id, get_admins
from models import User

app = FastAPI()

@app.get("/")
async def root():
    return { "message": "this is the student tracker app API" }


# User

@app.get("/users/")
async def read_users():
    users = get_users()
    user_list = list()
    for user in users:
        user_list.append(user.json())
    return user_list


@app.get("/users/{userId}")
async def read_user(userId: str = ""):
    user = get_user(int(userId))
    return user.json()


@app.put("/users/{userId}", response_model=dict)
async def update_user(userId: str, updated_user: dict):
    user = user_update(int(userId), updated_user)
    return user.json()


@app.post("/users/", response_model=dict)
async def create_user(new_user: dict):
    try:
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
    student_list = list()
    for student in students:
        student_list.append(student.json())
    return student_list


@app.get("/students/{studentId}")
async def read_student(studentId: str = ""):
    student = get_student(int(studentId))
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
    professor_list = list()
    for professor in professors:
        professor_list.append(professor.json())
    return professor_list


@app.get("/professors/{professorId}")
async def read_professor(professorId: str = ""):
    professor = get_professor(int(professorId))
    return professor.json()


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
    admin_list = list()
    for admin in admins:
        admin_list.append(admin.json())
    return admin_list


@app.get("/admins/{adminId}")
async def read_admin(adminId: str = ""):
    admin = get_admin(int(adminId))
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


def main():
    database_init()

main()
