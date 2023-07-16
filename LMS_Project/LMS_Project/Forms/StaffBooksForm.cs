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

namespace LMS_Project.Forms
{
    public partial class StaffBooksForm : Form
    {
        public string UserFirstName { get; set; }

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

        public StaffBooksForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.lMSDataSet.Book);
            // Adimn dashboard buttons (rounded)
            staffBooksBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffBooksBtn.Width, staffBooksBtn.Height, 15, 15));
            staffMembersBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffMembersBtn.Width, staffMembersBtn.Height, 15, 15));
            addBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, addBookBtn.Width, addBookBtn.Height, 15, 15));
            searchBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, searchBookBtn.Width, searchBookBtn.Height, 15, 15));
            editBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, editBookBtn.Width, editBookBtn.Height, 15, 15));
            markBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, markBookBtn.Width, markBookBtn.Height, 15, 15));
            userFnameLabel.Text = UserFirstName;
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
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            this.Close();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard_Form dashboard = new Dashboard_Form();
            this.Close();
            dashboard.Show();
        }

        private void staffMembersBtn_Click(object sender, EventArgs e)
        {
            StaffMembersForm smf = new StaffMembersForm();
            smf.UserFirstName = UserFirstName;
            this.Close();
            smf.Show();
        }
        //
    }
}
