using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LMS_Project.Classes
{
    public class Book
    {
        public int Book_ID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public bool IsBorrowed { get; set; }
    }
}
