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
        private string username;
        private string password;
        private string role;


        public Person()
        {
        }
        public Person(int id, string lastName, string firstName, string phone, string email, string username, string password, string role)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.phone = phone;
            this.email = email;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public bool login(string username, string password) 
        {
            return true;
        }

        public bool logOut(string username)
        {
            return true;
        }

        public bool searchBookById(string bookId)
        {
            return false;
        }
        public bool searchBookByTitle(string title)
        {
            return false;
        }
        public bool searchBookByISBN(string ISBN)
        {
            return false;
        }
        public bool searchBookByAuthor(string author)
        {
            return false;
        }

    }
}
