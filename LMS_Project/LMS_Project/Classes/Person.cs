using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Project.Classes
{
    internal class Person
    {
        private int id;
        private string lastName;
        private string firstName;
        private string phone;
        private string email;
        private string userRole;
        private string username;
        private string password;


        public Person()
        {
        }
        public Person(int id, string lastName, string firstName, string phone, string email, string userRole, string username, string password)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.phone = phone;
            this.email = email;
            this.userRole = userRole;
            this.username = username;
            this.password = password;
        }

        public int getId()
        {
            return id;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public String getPhone()
        {
            return phone;
        }

        public String getEmail()
        {
            return email;
        }

        public String getUserRole()
        {
            return userRole;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setUserRole(String userRole)
        {
            this.userRole= userRole;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void login(string username, string password) 
        {
            
        }

        public void logOut(string username)
        {
           
        }

        public Book searchBookById(string bookId)
        {
            return null;
        }
        public Book searchBookByTitle(string title)
        {
            return null;
        }
        public Book searchBookByISBN(string ISBN)
        {
            return null;
        }
        public Book searchBookByAuthor(string author)
        {
            return null;
        }

    }
}
