import sqlalchemy
from sqlalchemy import Column, ForeignKey, String, Integer, Boolean, create_engine
from sqlalchemy.orm import declarative_base, sessionmaker
from pydantic import BaseModel

Base = declarative_base()

class User(Base):
    __tablename__ = "Users"

    UserId = Column(Integer, primary_key=True, nullable=True, autoincrement=True)

    EmailAddr = Column(String)
    Password = Column(String)

    FirstName = Column(String)
    LastName = Column(String)

    CreatedAt = Column(String)
    UpdatedAt = Column(String)

    Role = Column(String)

    def __init__(self, user_id: int, emailaddr: str, password: str, firstname: str, lastname: str, created_at: str, updated_at: str, role: str):
        self.UserId = user_id
        self.EmailAddr = emailaddr
        self.Password = password
        self.FirstName = firstname
        self.LastName = lastname
        self.CreatedAt = created_at
        self.UpdatedAt = updated_at
        self.Role = role


    def __repr__(self):
        return f"""{self.UserId}
{self.EmailAddr}
{self.Password}
{self.FirstName}
{self.LastName}
{self.CreatedAt}
{self.UpdatedAt}
{self.Role}"""

    def json(self):
        json = dict()
        json["user_id"] = self.UserId
        json["emailaddr"] = self.EmailAddr
        json["password"] = ""
        json["first_name"] = self.FirstName
        json["last_name"] = self.LastName
        json["created_at"] = self.CreatedAt
        json["updated_at"] = self.UpdatedAt
        json["role"] = self.Role
        return json


class Student(Base):
    __tablename__ = "Students"

    StudentId = Column(Integer, primary_key=True)
    UserId = Column(Integer, ForeignKey(User.UserId))
    ENumber = Column(String)
    ProfessorId = Column(Integer)

    def __init__(self, student_id: int, user_id: int, enumber: str, professor_id: int):
        self.StudentId = student_id
        self.UserId = user_id
        self.ENumber = enumber
        self.ProfessorId = professor_id

    def __repr__(self):
        return f"""{self.StudentId}
{self.UserId}
{self.ENumber}
{self.ProfessorId}"""

    def json(self):
        json = dict()
        json["student_id"] = self.StudentId
        json["user_id"] = self.UserId
        json["enumber"] = self.ENumber
        json["professor_id"] = self.ProfessorId
        return json


class Professor(Base):
    __tablename__ = "Professors"

    ProfessorId = Column(Integer, primary_key=True)
    UserId = Column(Integer, ForeignKey(User.UserId))

    def __init__(self, professor_id: int, user_id: int):
        self.ProfessorId = professor_id
        self.UserId = user_id

    def __repr__(self):
        return f"""{self.ProfessorId}
{self.UserId}"""

    def json(self):
        json = dict()
        json["professor_id"] = self.ProfessorId
        json["user_id"] = self.UserId
        return json


class Admin(Base):
    __tablename__ = "Admins"

    AdminId = Column(Integer, primary_key=True)
    UserId = Column(Integer, ForeignKey(User.UserId))

    def __init__(self, admin_id: int, user_id: int):
        self.AdminId = admin_id
        self.UserId = user_id

    def __repr__(self):
        return f"""{self.AdminId}
{self.UserId}"""

    def json(self):
        json = dict()
        json["admin_id"] = self.AdminId
        json["user_id"] = self.UserId
        return json


class HoursLogged(Base):
    __tablename__ = "HoursLogged"

    HoursLoggedId = Column(Integer, primary_key=True)
    StudentId = Column(Integer, ForeignKey(Student.StudentId))
    Hours = Column(String)
    Location = Column(String)
    ShiftDate = Column(String)
    LoggingDate = Column(String)

    def __init__(self, hours_logged_id: int, student_id: int, hours: str, location: str, shift_date: str, logging_date: str):
        self.HoursLoggedId = hours_logged_id
        self.StudentId = student_id
        self.Hours = hours
        self.Location = location
        self.ShiftDate = shift_date
        self.LoggingDate = logging_date

    def __repr__(self):
        return f"""{self.HoursLoggedId}
{self.StudentId}
{self.Hours}
{self.Location}
{self.ShiftDate}
{self.LoggingDate}"""

    def json(self):
        json = dict()
        json["hours_logged_id"] = self.HoursLoggedId
        json["student_id"] = self.StudentId
        json["hours"] = self.Hours
        json["location"] = self.Location
        json["shift_date"] = self.ShiftDate
        json["logging_date"] = self.LoggingDate
        return json
