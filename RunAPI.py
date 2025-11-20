import os
import subprocess

def install_module(name: str):
    subprocess.run(f"pip install {name}")

def main():
    try:
        import fastapi
    except ImportError:
        print("installing fastapi...")
        install_module("fastapi")
    
    try:
        import sqlalchemy
    except ImportError:
        print("installing sqlalchemy...")
        install_module("sqlalchemy")

    try:
        import uvicorn
    except ImportError:
        print("installing uvicorn...")
        install_module("uvicorn")

    os.chdir("./database_api/")
    subprocess.run("python -m uvicorn main:app --host localhost --port 8000")

main()
