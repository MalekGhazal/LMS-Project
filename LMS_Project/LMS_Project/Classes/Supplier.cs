using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Project.Classes
{
    internal class Supplier : Person
    {
        public Supplier() { }

        public Supplier(int id, string lastName, string firstName, string phone, string email, string userRole, string username, string password, string role) : base(id, lastName, firstName, phone, email, userRole, username, password)
        {
        }

        public void sellBook(Book book)
        {

        }
    }
}
