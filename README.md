# Library Management System
## Vanier College Project

### Overview
The Library Management System is a desktop application developed as part of the Application Development (Desktop) class at Vanier College. This project aims to create a user-friendly system to manage library operations, including book management, user membership, borrowing, and returning books. The project follows the Model-View-Controller **(MVC)** design pattern.

### Team Members
* Wei Jin
* Sean Burke
* Malek Kazal

### Features
- Login functionality for staff, suppliers, and regular users.
- Staff members can search, add, update, and remove books from the library.
- Regular users can search for and borrow books from/return books to the library.
- Membership application process for users to become library members.
- Staff members can review and accept/reject membership applications.
- Staff members can view the list of users, and grant membership to a user.
- Suppliers can search for a book, and sell a book to the library.

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



## Example Accounts Login Information (all passwords are '123456')
User		joe123       
User		aldo456	
User		alaina456
Supplier	evie789
Supplier	lara789  
Staff		Wei
Staff		Malek  

## User Walkthrough
-After logging in click on books
-You can search the book catalog by Book_ID, Title, Author, Category, or ISBN
-Select a book and click the borrow button to borrow the book (if it is available)
-To return a book click the Return a Book button
-To apply for membership click the "Become a Member" button

## Staff Walkthrough
-Through the 'Manage Books' button:
-You can search the book catalog by Book_ID, Title, Author, Category, or ISBN
-You can add a book with the data entry text boxes and the 'Add' button
-You can update a book by selecting it in the table and updating the data in the textboxes then hitting the 'Update' button
-You can delete a book by selecting it in the table and clicking the 'delete' button
-Through the 'Manage Members' button:
-You can select a user and click the "Lend a User' button to see that book catalog and select a book to lend them
-You can add them as a member by selecting them and clicking 'Add as Member'
-You can see the current list of applicants with the 'Applications' button which lets you accept or reject their application

## Supplier Walkthrough
-You can search the book catalog by Book_ID, Title, Author, Category, or ISBN
-Sell a book by clicking that button and then inputting the book information in the form

## Thanks for visiting our library!

