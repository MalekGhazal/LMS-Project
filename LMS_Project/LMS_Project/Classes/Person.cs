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


        public Person()
        {
        }
        public Person(int id, string lastName, string firstName, string phone, string email, string username, string password)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.phone = phone;
            this.email = email;
            this.username = username;
            this.password = password;
        }
        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

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
