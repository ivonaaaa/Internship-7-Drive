# INTERNSHIP
> 7th ASSIGNMENT

### DumpDrive App

The DumpDrive App is a console application built using C# in Visual Studio. The project utilizes a three-tier software architecture (Presentation, Domain, Data) and integrates a PostgreSQL database managed through PgAdmin. It is designed to mimic the functionality of a real disk drive, including features such as user authentication, file and folder management, sharing, and more. The project employs object-oriented programming (OOP) concepts and LINQ methods to ensure efficient and maintainable code.<br>
On a side note, I have gained valuable experience in Object-Oriented Programming (OOP), LINQ methods, and the three-tier architecture. Additionally, I have focused on refactoring code to make it more readable and maintainable, which has significantly improved my coding practices.

### Features
<li>Dynamic console UI</li>
<li>User Authentication</li>
<li>Folder and file management</li>
<li>Sharing logic</li>
<li>Mutual editing and commenting shared files</li>
<li>Profile management</li>

### Technologies used
<li>Language: C#</li>
<li>Framework: .NET 9.0</li>
<li>Database: PostgreSQL</li>
<li>ORM: Entity Framework Core</li>
<li>Tools: Visual Studio, PgAdmin</li>

### Packages
The project utilizes the following NuGet packages:
<li>Microsoft.EntityFrameworkCore</li>
<li>Npgsql.EntityFrameworkCore.PostgreSQL</li>
<li>Microsoft.EntityFrameworkCore.Tools</li>
<li>Microsoft.EntityFrameworkCore.Design</li>

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
3. **Navigate to the startup layer**:
   ```bash
   cd DumpDrive.Presentation
   ```
4. **Run the code**:
   ```bash
   dotnet run
   ```

   
   
