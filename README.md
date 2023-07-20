# Library Management System
## Vanier College Project

### Overview
The Library Management System is a desktop application developed as part of the Application Development (Desktop) class at Vanier College. The goal of this project is to create a user-friendly system to manage library operations, including book management, user membership, borrowing, and returning books. The project follows the Model-View-Controller **(MVC)** design pattern.

### Team Members
* Wei Jin
* Sean Burke
* Malek Kazal

### Features
- Login functionality for staff, suppliers, and regular users.
- Staff members can add, update, and remove books from the library.
- Regular users can search for and borrow books from the library.
- Membership application process for users to become library members.
- Staff members can review and accept/reject membership applications.
- Books can be borrowed and returned by users with tracking of due dates.

### Technologies Used
- C# programming language
- Windows Forms for the user interface
- Microsoft SQL Server for the database

### How to Run
- Clone the repository to your local machine.
- Open the solution file (.sln) in Visual Studio.
- Set up the database and replace the connection string in the **App.config** file with yours.
- Consider changing the Connection String in **Properties/Settings.settings** file too.
```C#
<connectionStrings>
        <add name="ConnString" connectionString="Data Source=<Server Name>;Initial Catalog=<Database Name>;Integrated Security=True"
            providerName="System.Data.SqlClient" />
    </connectionStrings>
```
- Build and run the application in Visual Studio.

### Getting Help
If you encounter any issues or have questions, please feel free to contact any of the team members listed above.




