# Student Management System

A desktop **Student Management System** built with **C# (WinForms)** and **SQL Server**. It provides separate login flows for administrators and students, and lets an admin manage student records, courses, marks, and results from a simple dashboard.

## Features

- 🔐 **Login System** — separate access for Admin and Students
  - Admin login uses a fixed username/password
  - Student login is verified against student records stored in the database
- 🏠 **Dashboard** — central hub after login for navigating the system
- 🎓 **Student Management** — add, view, and manage student records
- 📚 **Course Management** — manage course information
- 📝 **Marks Management** — record and manage student marks
- 📊 **Results** — view generated student results

## Tech Stack

- **Language:** C#
- **UI Framework:** Windows Forms (.NET)
- **Database:** Microsoft SQL Server (via `Microsoft.Data.SqlClient`)

## Project Structure

```
Student-Management-System/
├── LoginForm.cs / .Designer.cs / .resx     # Login screen (Admin & Student)
├── Dashboard.cs / .Designer.cs / .resx     # Main dashboard after login
├── Students.cs / .Designer.cs / .resx      # Student records management
├── Course.cs / .Designer.cs / .resx        # Course management
├── Marks.cs / .Designer.cs / .resx         # Marks entry/management
├── Result.cs / .Designer.cs / .resx        # Result view
├── Program.cs                              # Application entry point
├── Student Mangement System.csproj         # Project file
├── Student Mangement System.slnx           # Solution file
└── icons8-graduate-100.ico                 # App icon
```

## Prerequisites

- Windows OS
- [.NET SDK](https://dotnet.microsoft.com/download) (compatible with the project's target framework)
- Visual Studio 2022 (recommended) with the **.NET Desktop Development** workload
- **SQL Server** (Express or higher) with a database matching the app's connection string

## Database Setup

The app connects to SQL Server using a connection string similar to:

```
Server=SMS\SQLEXPRESS;Database=StdForm;Trusted_Connection=True;TrustServerCertificate=True;
```

1. Install SQL Server Express (or update the server name in the code to match your instance).
2. Create a database named `StdForm`.
3. Create a `Students` table that includes at least `StudentName` and `StudentID` columns, since these are used to authenticate student logins.
4. Update the connection string in `LoginForm.cs` (and any other files that connect to the database) if your server/database name differs.

> ⚠️ **Note:** The admin credentials are currently hard-coded in the source. Before deploying or sharing this project, move credentials and connection strings to a secure configuration (e.g. `appsettings.json`, environment variables, or Windows Credential Manager) rather than leaving them in source code.

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/mrdanial526/student-management-system.git
   ```
2. Open `Student Mangement System.slnx` in Visual Studio.
3. Restore NuGet packages (including `Microsoft.Data.SqlClient`).
4. Set up your SQL Server database as described above.
5. Build and run the project (F5).

## Usage

- **Admin Login:** Sign in with the admin credentials to access the Dashboard and manage students, courses, and marks.
- **Student Login:** Students sign in using their student name and ID to view their results.

## Roadmap / Possible Improvements

- Move hard-coded credentials to a secure, external configuration
- Add password hashing for student/admin authentication
- Add CRUD screens for editing/deleting students, courses, and marks
- Add input validation and unit tests
- Package as an installer for easier distribution

## License

No license has been specified yet. Consider adding one (e.g. MIT) if you'd like others to use or contribute to this project.

## Author

**mrdanial526**
