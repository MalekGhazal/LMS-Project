using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Project.Classes
{
    internal class Staff : Person
    {
        public Staff()
        {
        }

        public Staff(int id, string lastName, string firstName, string phone, string email, string username, string password) : base(id, lastName, firstName, phone, email, username, password)
        {
        }

        public void addBook(Book newBook)
        {
            
        }

        public void markBookReserved(Book book, bool isReserved)
        {

        }

        public void modifyBookInfo(Book book, Book newBook)
        {

        }

        public void lendBook(Book book, int userId)
        {

        }

        public void addMember(int userId)
        {

        }
    }
}
