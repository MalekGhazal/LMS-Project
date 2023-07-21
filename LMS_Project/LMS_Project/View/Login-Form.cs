using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using static LMS_Project.LMSDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LMS_Project.Classes;

namespace LMS_Project.Forms
{
    public partial class Login_Form : Form
    {
        // Rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,     // x-coordinate of upper-left corner
            int nTop,      // y-coordinate of upper-left corner
            int nRight,    // x-coordinate of lower-right corner
            int nBottom,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Login_Form()
        {
            InitializeComponent();
            // Rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Rounded login button
            loginBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, loginBtn.Width, loginBtn.Height, 15, 15));
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
        // ****************************************************************
        // ****************************************************************

        // Enters & Leavers for the TextBoxes (username, password)
        // these methods acts like placeholders in the textboxes
        // so it would be easier for the user to type in his data.
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
        // ****************************************************************
        // ****************************************************************

        /// <summary>
        /// The LOGIN Logic
        /// when the user press the login button, it check if the username and password
        /// entered by the user matches any record in the DB ( User table )
        /// if it did, then it check the ( User_Role ) column in that record
        /// based on the role of the user, it opens the corresponding form accordingly
        /// it passes also the first name of the user and his ID to the other forms
        /// at the end it validates if the user is pressing Login without entering any info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            DAL.MyDB db = new DAL.MyDB();

            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = @usn AND Password = @pass", db.GetConnection());

            cmd.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                int userID = Convert.ToInt32(dt.Rows[0]["User_ID"]);
                string userRole = dt.Rows[0]["User_Role"].ToString().Trim();
                string userFirstName = dt.Rows[0]["User_Fname"].ToString().Trim();

                switch (userRole)
                {
                    case "Staff":
                        Dashboard_Form dba = new Dashboard_Form();
                        dba.UserFirstName = userFirstName;
                        dba.UserID = userID;
                        dba.Show();
                        break;
                    case "Supplier":
                        DashboardSupplier dbs = new DashboardSupplier();
                        dbs.UserFirstName = userFirstName;
                        dbs.UserID = userID;
                        dbs.Show();
                        break;
                    case "User":
                        DashboardUser dbu = new DashboardUser();
                        dbu.UserFirstName = userFirstName;
                        dbu.UserID = userID;
                        dbu.Show();
                        break;
                    default:
                        MessageBox.Show("Invalid user role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Close();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username please", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password please", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        // ****************************************************************
    }
}
