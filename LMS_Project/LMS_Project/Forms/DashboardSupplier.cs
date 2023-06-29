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
    public partial class DashboardSupplier : Form
    {
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
            // dashboard buttons (rounded)
            suppSellBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, suppSellBtn.Width, suppSellBtn.Height, 15, 15));

            searchByCB.SelectedIndex = 0;
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

        // Search Book's list Method (Text Changed event)
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

                if (columnName == "Book_ID")
                {
                    if (int.TryParse(searchValue, out int bookId))
                    {
                        filterExpression = string.Format("{0} = {1}", columnName, bookId);
                    }
                    else
                    {
                        // Book_ID input validation
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
