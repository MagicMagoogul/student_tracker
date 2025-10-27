import sqlalchemy
from sqlalchemy import Column, ForeignKey, String, Integer, Boolean, create_engine
from sqlalchemy.orm import declarative_base, sessionmaker
from pydantic import BaseModel

Base = declarative_base()

class User():
    __tablename__ = "users"

    Id = Column(Integer, primary_key=True)

    EmailAddr = Column(String)
    Password = Column(String)

    FirstName = Column(String)
    LastName = Column(String)

    CreatedAt = Column(String)
    UpdatedAt = Column(String)


class Student():
    __tablename__ = "students"

    StudentId = Column(Integer, primary_key=True)

    UserId = Column(Integer, ForeignKey(User.Id))
    

    def __repr__(self):
        return f"""{self.UserId}"""