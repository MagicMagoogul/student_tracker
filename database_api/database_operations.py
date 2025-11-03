import sqlalchemy
from sqlalchemy import Column, String, Integer, create_engine
from sqlalchemy.orm import declarative_base, sessionmaker

from models import User, Student, Professor, Admin

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


def user_update(user_id: int, updated_user: dict):
    try:
        global session
        user = session.query(User).where(User.UserId == user_id).first()
        user.UserId = int(updated_user["user_id"])
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
        user = User(int(new_user["user_id"]), new_user["emailaddr"], new_user["password"], new_user["first_name"], new_user["last_name"], new_user["created_at"], new_user["updated_at"], new_user["role"])
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


def get_student(student_id: int):
    try:
        global session
        return session.query(Student).where(Student.StudentId == student_id).first()
    except Exception as e:
        print(f"get_student failed: {e}")


def get_student_by_user_id(user_id: int):
    try:
        global session
        return session.query(Student).where(Student.UserId == user_id).first()
    except Exception as e:
        print(f"get_student_by_user_id failed: {e}")


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
        student = Student(int(new_student["student_id"]), int(new_student["user_id"]), new_student["enumber"], int(new_student["professor_id"]))
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


def get_professor(professor_id: int):
    try:
        global session
        return session.query(Professor).where(Professor.ProfessorId == professor_id).first()
    except Exception as e:
        print(f"get_professor failed: {e}")


def get_professor_by_user_id(user_id: int):
    try:
        global session
        return session.query(Professor).where(Professor.UserId == user_id).first()
    except Exception as e:
        print(f"get_professor_by_user_id failed: {e}")


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
        professor = Professor(int(new_professor["professor_id"]), int(new_professor["user_id"]))
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


def get_admin(admin_id: int):
    try:
        global session
        return session.query(Admin).where(Admin.AdminId == admin_id).first()
    except Exception as e:
        print(f"get_admin failed: {e}")


def get_admin_by_user_id(user_id: int):
    try:
        global session
        return session.query(Admin).where(Admin.UserId == user_id).first()
    except Exception as e:
        print(f"get_admin_by_user_id failed: {e}")


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
        admin = Admin(int(new_admin["admin_id"]), int(new_admin["user_id"]))
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


def database_init():
    DATABASE_URL = "sqlite:///./StudentTracker.db"

    engine = create_engine(DATABASE_URL, pool_size=5, pool_recycle=1800, pool_pre_ping=True)

    session_factory = sessionmaker(autoflush=False, bind=engine)

    global session
    session = session_factory()

    new_user = dict()
    new_user["user_id"] = "1"
    new_user["emailaddr"] = "loel@gov.com"
    new_user["password"] = "tjdlkagwerokfn"
    new_user["first_name"] = "Me"
    new_user["last_name"] = "Johnson"
    new_user["created_at"] = "Right Now"
    new_user["updated_at"] = "Never"
    new_user["role"] = "Student"
    #user_create(new_user)
