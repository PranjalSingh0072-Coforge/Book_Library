📚 Book Library – C# Application with Docker
The Book Library project is a clean and simple C# (.NET) application designed to store, manage, and retrieve book information.
The entire application is containerized using Docker, allowing it to run consistently across any environment without manual setup.

🚀 Features

📖 Add, update, delete, and view books
🧱 Built using C# / .NET
🐳 Fully containerized using Docker
🔄 Consistent behavior on any machine
📦 Lightweight and easy to deploy
🧪 Supports environment configuration
🗂️ Can use SQL Server / SQLite / in‑memory storage (based on your implementation)


🛠️ Tech Stack

C# / .NET 6+ or .NET 7
Docker
Optional:

SQL Server / SQLite
Entity Framework Core




📂 Project Structure (example)
Book_Library/
│── Program.cs                 # Application entry point
│── Models/                    # Book model classes
│── Services/                  # Business logic
│── Dockerfile                 # Docker build file
│── appsettings.json           # Configuration
│── Book_Library.csproj        # C# project file
│── README.md                  # Documentation
│── .gitignore                 # Ignored files

(Modify directories if your structure is slightly different.)

🐳 Running the Application Using Docker
✔️ 1. Build the Docker Image
Shelldocker build -t book-library .Show more lines
✔️ 2. Run the Container
Shelldocker run -it book-libraryShow more lines
✔️ 3. Run with Port Mapping (if your project has APIs)
Example:
Shelldocker run -p 5000:80 book-libraryShow more lines
Now open:
http://localhost:5000


▶️ Running the Application Without Docker
Shelldotnet restoredotnet builddotnet runShow more lines

📘 Example Output (Console App)
Welcome to Book Library!
1. Add Book
2. View Books
3. Delete Book
4. Exit
Enter your choice:


📈 Future Enhancements

Add REST API using ASP.NET Core
Add SQL Server support with EF Core
Add authentication
Add UI using Angular or React
Add Docker Compose multi-service architecture
Add logging + error tracking


🤝 Contributing
Pull requests and suggestions are welcome!

📜 License
This project is licensed under the MIT License.

👤 Author
Pranjal Singh
C# | .NET Developer
Coforge Limited
