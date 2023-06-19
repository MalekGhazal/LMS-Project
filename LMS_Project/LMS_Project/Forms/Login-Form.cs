using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project.Forms
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Clear button in Login form

            usernameTxtBox.Text = string.Empty;
            passwordTxtBox.Text = string.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTxtBox_Enter(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "Your Username")
            {
                usernameTxtBox.Text = "";
                usernameTxtBox.ForeColor = Color.Black;
            }
        }

        private void usernameTxtBox_Leave(object sender, EventArgs e)
        {
            if ( usernameTxtBox.Text == "")
            {
                usernameTxtBox.Text = "Your Username";
                usernameTxtBox.ForeColor = Color.LightGray;
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Your Password")
            {
                passwordTxtBox.Text = "";
                passwordTxtBox.ForeColor = Color.Black;
            }
        }

        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if ( passwordTxtBox.Text == "")
            {
                passwordTxtBox.Text = "Your Password";
                passwordTxtBox.ForeColor= Color.LightGray;
            }
        }
    }
}
