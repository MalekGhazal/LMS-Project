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
    public class User
    {
        public int User_ID { get; set; }
        public string User_Lname { get; set; }
        public string User_Fname { get; set; }
        public string User_Phone { get; set; }
        public string User_Email { get; set; }
        public string User_Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
