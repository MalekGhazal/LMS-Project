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
    public partial class LendUser : Form
    {
        private int userID;
        private string username;

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

        public LendUser(int userID, string username)
        {
            InitializeComponent();
            // Rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.userID = userID;
            this.username = username;
        }

        private void SuppSellBook_Load(object sender, EventArgs e)
        {
            LoadBookData();
            // Rounded Buttons
            lendBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, lendBtn.Width, lendBtn.Height, 15, 15));
            cancelBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 15, 15));
        }
        /// <summary>
        /// Loading the all the Book table records into the Data grid
        /// </summary>
        private void LoadBookData()
        {
            BookRepository bookRepository = new BookRepository();
            List<Book> books = bookRepository.GetAllBooks();

            lendUserList.DataSource = books;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Lend button with checking and validation
        /// using ( CheckIfBookIsBorrowed ) & ( LendBook ) methods from the BookRepository
        /// based on the selected row in the data grid ( Book_ID )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lendBtn_Click(object sender, EventArgs e)
        {
            // Check if a book is selected
            if (lendUserList.SelectedRows.Count > 0)
            {
                // Get the selected book information
                int bookID = Convert.ToInt32(lendUserList.SelectedRows[0].Cells["Book_ID"].Value);

                // Check if the book is already borrowed
                BookRepository bookRepository = new BookRepository();
                bool isBorrowed = bookRepository.CheckIfBookIsBorrowed(bookID);

                if (isBorrowed)
                {
                    MessageBox.Show("This book is not available. Please come back later.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update the book's information in the database
                    bool success = bookRepository.LendBook(bookID, userID);

                    if (success)
                    {
                        MessageBox.Show("Book has been successfully lent.", "Lend Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to lend the book.", "Lend Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book first.", "Select Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
