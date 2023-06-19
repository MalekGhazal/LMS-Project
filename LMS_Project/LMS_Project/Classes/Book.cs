using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Project.Classes
{
    internal class Book
    {
        private String bookId;
        private String title;
        private String author;
        private String ISBN;
        private String category;
        private int userId;
        private DateTime timeOfStatusChange;
        private bool isBorrowed;

        public Book()
        {

        }

        public Book(string bookId, string title, string author, string iSBN, string category)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            ISBN = iSBN;
            this.category = category;
            this.timeOfStatusChange = DateTime.Now;
            this.isBorrowed = false;

        }

    }
}
