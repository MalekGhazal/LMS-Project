using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LMS_Project.Classes;
using LMS_Project.DAL;

namespace LMS_Project.Forms
{
    public partial class StaffMembersForm : Form
    {
        public string UserFirstName { get; set; }

        // Rounded Corners
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

        // dragging bar
        public Point mouseLocation;

        public StaffMembersForm()
        {
            InitializeComponent();
            // Rounded Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            LoadUserData();

            // Rounded Buttons
            staffBooksBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffBooksBtn.Width, staffBooksBtn.Height, 15, 15));
            staffMembersBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffMembersBtn.Width, staffMembersBtn.Height, 15, 15));
            lendUserBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, lendUserBtn.Width, lendUserBtn.Height, 15, 15));
            addMemberBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, addMemberBtn.Width, addMemberBtn.Height, 15, 15));
            applicationsBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, applicationsBtn.Width, applicationsBtn.Height, 15, 15));

            userFnameLabel.Text = UserFirstName;
        }
        /// <summary>
        /// Loading all the User table records into the data grid
        /// </summary>
        private void LoadUserData()
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAllUsers();

            staffUsersList.DataSource = users;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // X button (close)
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // - button (minimize)
            WindowState = FormWindowState.Minimized;
        }

        // Dragging bar settings and mouse movement
        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void staffBooksBtn_Click(object sender, EventArgs e)
        {
           StaffBooksForm sbf = new StaffBooksForm();
            sbf.UserFirstName = UserFirstName;
            this.Close();
            sbf.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            this.Close();
            login.Show();
        }
        /// <summary>
        /// Adding the selected user ( row ) from teh data grid as a Member
        /// and inserting a new record into the Member table with the selected user's ID
        /// using the ( AddMember ) method from the UserRepository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            // Check if a user is selected
            if (staffUsersList.SelectedRows.Count > 0)
            {
                // Get the selected User_ID
                int userID = Convert.ToInt32(staffUsersList.SelectedRows[0].Cells["User_ID"].Value);

                // Insert a new record into the Member table
                UserRepository memberRepository = new UserRepository();
                bool success = memberRepository.AddMember(userID);

                if (success)
                {
                    MessageBox.Show("User is now a member!", "Add as Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add the user as a member.", "Add as Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user.", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lendUserBtn_Click(object sender, EventArgs e)
        {
            // Check if a user is selected
            if (staffUsersList.SelectedRows.Count > 0)
            {
                // Get the selected user information
                int userID = Convert.ToInt32(staffUsersList.SelectedRows[0].Cells["User_ID"].Value);
                string userName = staffUsersList.SelectedRows[0].Cells["Username"].Value.ToString();

                // Open the LendUserForm and pass the user information
                LendUser lendUserForm = new LendUser(userID, userName);
                lendUserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a user first.", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void applicationsBtn_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            applications.Show();
        }
        //
    }
}
