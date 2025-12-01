import sqlalchemy
from sqlalchemy import Column, String, Integer, create_engine
from sqlalchemy.orm import declarative_base, sessionmaker

from models import User, Student, Professor, Admin, HoursLogged

# User

def get_users():
    try:
        global session
        return session.query(User).all()
    except Exception as e:
        print(f"get_users failed: {e}")


def get_user(user_id: int):
    try:
        global session
        return session.query(User).where(User.UserId == user_id).first()
    except Exception as e:
        print(f"get_user failed: {e}")


def get_user_by_first_name(first_name: int):
    try:
        global session
        return session.query(User).where(User.FirstName == first_name)
    except Exception as e:
        print(f"get_user_by_first_name failed: {e}")


def get_user_by_last_name(last_name: int):
    try:
        global session
        return session.query(User).where(User.LastName == last_name)
    except Exception as e:
        print(f"get_user_by_last_name failed: {e}")


def user_check_password(userId: int, password: str):
    try:
        global session
        user = session.query(User).where(User.UserId == userId).where(User.Password == password).first()
        if user:
            return True
        else:
            return False
    except Exception as e:
        print(f"user_check_password failed: {e}")


def user_update(user_id: int, updated_user: dict):
    try:
        global session
        user = session.query(User).where(User.UserId == user_id).first()
        #user.UserId = int(updated_user["user_id"])
        user.EmailAddr = updated_user["emailaddr"]
        user.Password = updated_user["password"]
        user.FirstName = updated_user["first_name"]
        user.LastName = updated_user["last_name"]
        user.CreatedAt = updated_user["created_at"]
        user.UpdatedAt = updated_user["updated_at"]
        user.Role = updated_user["role"]
        session.commit()
        return user
    except Exception as e:
        print(f"user_update failed: {e}")


def user_create(new_user: dict):
    try:
        global session
        user = User(None, new_user["emailaddr"], new_user["password"], new_user["first_name"], new_user["last_name"], new_user["created_at"], new_user["updated_at"], new_user["role"])
        session.add(user)
        session.commit()
        return user
    except Exception as e:
        print(f"user_create failed: {e}")


def user_delete(user_id: int):
    try:
        global session
        user = session.query(User).where(User.UserId == user_id).first()
        session.delete(user)
        session.commit()
    except Exception as e:
        print(f"user_delete failed: {e}")


# Student

def get_students():
    try:
        global session
        return session.query(Student).all()
    except Exception as e:
        print(f"get_students failed: {e}")


def get_student(user_id: int):
    try:
        global session
        return session.query(Student).where(Student.UserId == user_id).first()
    except Exception as e:
        print(f"get_student failed: {e}")


def get_student_by_enumber(enumber: int):
    try:
        global session
        return session.query(Student).where(Student.ENumber == enumber).first()
    except Exception as e:
        print(f"get_student_by_enumber failed: {e}")


def get_student_by_first_name(first_name: int):
    try:
        global session
        user = get_user_by_first_name(first_name)

        #return session.query(Student).where(Student.UserId == ).first()
    except Exception as e:
        print(f"get_student_by_enumber failed: {e}")


def student_update(student_id: int, updated_student: dict):
    try:
        global session
        student = session.query(Student).where(Student.StudentId == student_id).first()
        student.StudentId = int(updated_student["student_id"])
        student.UserId = int(updated_student["user_id"])
        student.ENumber = int(updated_student["enumber"])
        student.ProfessorId = int(updated_student["professor_id"])
        session.commit()
        return student
    except Exception as e:
        print(f"student_update failed: {e}")


def student_create(new_student: dict):
    try:
        global session
        student = Student(None, int(new_student["user_id"]), new_student["enumber"], int(new_student["professor_id"]))
        session.add(student)
        session.commit()
        return student
    except Exception as e:
        print(f"student_create failed: {e}")


def student_delete(student_id: int):
    try:
        global session
        student = session.query(Student).where(Student.StudentId == student_id).first()
        session.delete(student)
        session.commit()
    except Exception as e:
        print(f"student_delete failed: {e}")


# Professors

def get_professors():
    try:
        global session
        return session.query(Professor).all()
    except Exception as e:
        print(f"get_professors failed: {e}")


def get_professor(user_id: int):
    try:
        global session
        return session.query(Professor).where(Professor.UserId == user_id).first()
    except Exception as e:
        print(f"get_professor failed: {e}")


def get_professor_students(user_id: int):
    try:
        global session
        professor = get_professor(user_id)
        return session.query(Student).where(Student.ProfessorId == professor.ProfessorId)
    except Exception as e:
        print(f"get_professor_students failed: {e}")


def professor_update(professor_id: int, updated_professor: dict):
    try:
        global session
        professor = session.query(Professor).where(Professor.ProfessorId == professor_id).first()
        professor.ProfessorId = int(updated_professor["professor_id"])
        professor.UserId = int(updated_professor["user_id"])
        session.commit()
        return professor
    except Exception as e:
        print(f"professor_update failed: {e}")


def professor_create(new_professor: dict):
    try:
        global session
        professor = Professor(None, int(new_professor["user_id"]))
        session.add(professor)
        session.commit()
        return professor
    except Exception as e:
        print(f"professor_create failed: {e}")


def professor_delete(professor_id: int):
    try:
        global session
        professor = session.query(Professor).where(Professor.ProfessorId == professor_id).first()
        session.delete(professor)
        session.commit()
    except Exception as e:
        print(f"professor_delete failed: {e}")


# Admin

def get_admins():
    try:
        global session
        return session.query(Admin).all()
    except Exception as e:
        print(f"get_admins failed: {e}")


def get_admin(user_id: int):
    try:
        global session
        return session.query(Admin).where(Admin.UserId == user_id).first()
    except Exception as e:
        print(f"get_admin failed: {e}")


def admin_update(admin_id: int, updated_admin: dict):
    try:
        global session
        admin = session.query(Admin).where(Admin.AdminId == admin_id).first()
        admin.AdminId = int(updated_admin["admin_id"])
        admin.UserId = int(updated_admin["user_id"])
        session.commit()
        return admin
    except Exception as e:
        print(f"admin_update failed: {e}")


def admin_create(new_admin: dict):
    try:
        global session
        admin = Admin(None, int(new_admin["user_id"]))
        session.add(admin)
        session.commit()
        return admin
    except Exception as e:
        print(f"admin_create failed: {e}")


def admin_delete(admin_id: int):
    try:
        global session
        admin = session.query(Admin).where(Admin.AdminId == admin_id).first()
        session.delete(admin)
        session.commit()
    except Exception as e:
        print(f"admin_delete failed: {e}")


# HoursLogged

def get_all_hours_logged():
    try:
        global session
        return session.query(HoursLogged).all()
    except Exception as e:
        print(f"get_all_hours_logged failed: {e}")


def get_hours_logged(hours_logged_id: int):
    try:
        global session
        return session.query(HoursLogged).where(HoursLogged.HoursLoggedId == hours_logged_id).first()
    except Exception as e:
        print(f"get_hours_logged failed: {e}")


def get_hours_logged_for_student(student_id: int):
    try:
        global session
        return session.query(HoursLogged).where(HoursLogged.StudentId == student_id)
    except Exception as e:
        print(f"get_hours_logged_for_student failed: {e}")


def hours_logged_update(hours_logged_id: int, updated_hours_logged: dict):
    try:
        global session
        hours_logged = session.query(HoursLogged).where(HoursLogged.HoursLoggedId == hours_logged_id).first()
        hours_logged.HoursLoggedId = int(updated_hours_logged["hours_logged_id"])
        hours_logged.StudentId = int(updated_hours_logged["student_id"])
        hours_logged.Hours = updated_hours_logged["hours"]
        hours_logged.Location = updated_hours_logged["location"]
        hours_logged.ShiftDate = updated_hours_logged["shift_date"]
        hours_logged.LoggingDate = updated_hours_logged["logging_date"]
        session.commit()
        return hours_logged
    except Exception as e:
        print(f"hours_logged_update failed: {e}")


def hours_logged_create(new_hours_logged: dict):
    try:
        global session
        hours_logged = HoursLogged(None, int(new_hours_logged["student_id"]), new_hours_logged["hours"], new_hours_logged["location"], new_hours_logged["shift_date"], new_hours_logged["logging_date"])
        session.add(hours_logged)
        session.commit()
        return hours_logged
    except Exception as e:
        print(f"hours_logged_create failed: {e}")


def hours_logged_delete(hours_logged_id: int):
    try:
        global session
        hours_logged = session.query(HoursLogged).where(HoursLogged.HoursLoggedId == hours_logged_id).first()
        session.delete(hours_logged)
        session.commit()
    except Exception as e:
        print(f"hours_logged_delete failed: {e}")


def database_init():
    DATABASE_URL = "sqlite:///../Student Tracker Blazor/Data/StudentTracker.db"

    engine = create_engine(DATABASE_URL, pool_size=5, pool_recycle=1800, pool_pre_ping=True)

    session_factory = sessionmaker(autoflush=False, bind=engine)

    global session
    session = session_factory()
