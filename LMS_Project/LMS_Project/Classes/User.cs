using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS_Project.Classes
{
    internal class User : Person
    {
        private bool membership;
        private ArrayList bookList = new ArrayList();

        public User()
        {
        }

        public User(int id, string lastName, string firstName, string phone, string email, string userRole, string username, string password) : base(id, lastName, firstName, phone, email, userRole, username, password)
        {
        }

        public void borrowBook (Book book)
        {
        }
        public void returnBook (Book book)
        {
        }
        public bool Membership { get => membership; set => membership = value; }


    }
}
