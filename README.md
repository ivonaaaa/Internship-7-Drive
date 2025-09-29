# INTERNSHIP
> 7th ASSIGNMENT

### DumpDrive App 💿

The DumpDrive App is a console application made to mimic a real disk drive where users can manage their content, including what's shared with them by other users. The project is built using C# in Visual Studio and is based on a three-tier software architecture. PostgreSQL database is integrated through PgAdmin, while the app communicates with it through LINQ queries and EF Core ORM. While coding this app I also used OOP concepts and some other design patterns.<br>

### Features
- Dynamic console UI
- User Authentication
- Folder and file management
- Specific logic integrated for shared content
- Profile management

### Technologies used
- **Language:** C#
- **Framework:** .NET 9.0
- **Database:** PostgreSQL
- **ORM:** Entity Framework Core
- **Tools:** Visual Studio, PgAdmin

### Packages
The project utilizes the following NuGet packages:
- Microsoft.EntityFrameworkCore
- Npgsql.EntityFrameworkCore.PostgreSQL
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design

## Installation and running
To get started with this project, you need to have the following installed on your machine:

1. **.NET 9.0 SDK**: You can download the .NET 9.0 SDK from the official [.NET website](https://dotnet.microsoft.com/en-us/download/dotnet/9.0).
2. **Visual Studio**: If you haven't already, download and install it [here](https://visualstudio.microsoft.com/).
3. **PostgreSQL**: Install [PostgreSQL](https://www.postgresql.org/download/) and set up your database. Use [PgAdmin](https://www.pgadmin.org/) for managing your PostgreSQL database.

Steps to Install the Project:
1. **Clone and open the Repository**:
   Open a terminal (or command prompt on your machine) and run the following commands:

   ```bash
   git clone https://github.com/ivonaaaa/Internship-7-Drive.git
   ```
   ```bash
   cd Internship-7-Drive
   ```
2. **Restore packages**:
   Restore the NuGet packages required for the project:
   ```bash
   dotnet restore
   ```
3. **Create the database in PGAdmin:** In this step you will need to connect to your PostgreSQL server. While doing so, remeber the usernane and password as you will need them later on.
4. **Configure connection strring:** In the App.config.xml, set your connection string with the right values.
5. **Apply migrations and seed data:**
   ```bash
   cd DumpDrive.Data
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
6. **Navigate to the startup layer**:
   ```bash
   cd ../DumpDrive.Presentation
   ```
7. **Run the code**:
   ```bash
   dotnet run
   ```
   
   
