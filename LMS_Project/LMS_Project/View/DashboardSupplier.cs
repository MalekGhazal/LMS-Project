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
using LMS_Project.Classes;
using LMS_Project.DAL;

namespace LMS_Project.Forms
{
    public partial class DashboardSupplier : Form
    {
        public string UserFirstName { get; set; }
        public int UserID { get; internal set; }

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

        // dragging bar
        public Point mouseLocation;

        public DashboardSupplier()
        {
            InitializeComponent();
            // Rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.lMSDataSet.Book);

            // Rounded Buttons
            suppSellBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, suppSellBtn.Width, suppSellBtn.Height, 15, 15));

            searchByCB.SelectedIndex = 0;
            suppFirstName.Text = UserFirstName;
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            this.Close();
            login.Show();
        }

        private void suppSellBtn_Click(object sender, EventArgs e)
        {
            SuppSellBook ssb = new SuppSellBook();
            ssb.Show();
        }
        /// <summary>
        /// Searching the Book's Data grid based on the column selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxtBox.Text))
            {
                bookBindingSource.Filter = string.Empty;
            }
            else
            {
                string columnName = searchByCB.Text;
                string searchValue = searchTxtBox.Text;
                string filterExpression = "";

                // Book_ID input validation
                if (columnName == "Book_ID")
                {
                    if (int.TryParse(searchValue, out int bookId))
                    {
                        filterExpression = string.Format("{0} = {1}", columnName, bookId);
                    }
                    else
                    {
                        MessageBox.Show("Book ID must be a number");
                    }
                }
                else
                {
                    filterExpression = string.Format("{0} LIKE '%{1}%'", columnName, searchValue);
                }

                bookBindingSource.Filter = filterExpression;
            }
        }

        //
    }
}
