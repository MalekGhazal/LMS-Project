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
    public partial class UserBooks : Form
    {
        public string UserFirstName { get; set; }
        public int currentUserID { get; set; }

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

        public UserBooks()
        {
            InitializeComponent();
            // Rounded Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.lMSDataSet.Book);

            // Rounded buttons styling
            userMemberBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, userMemberBtn.Width, userMemberBtn.Height, 15, 15));
            staffMembersBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffMembersBtn.Width, staffMembersBtn.Height, 15, 15));
            userBorrowBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, userBorrowBtn.Width, userBorrowBtn.Height, 15, 15));
            returnBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, returnBookBtn.Width, returnBookBtn.Height, 15, 15));

            userSearchByCB.SelectedIndex = 0;
            userFNameTxt.Text = UserFirstName;
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
        /// <summary>
        /// The search logic and filtering the data grid by the column selected by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userSearchTxtBox.Text))
            {
                bookBindingSource.Filter = string.Empty;
            }
            else
            {
                string columnName = userSearchByCB.Text;
                string searchValue = userSearchTxtBox.Text;
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
        /// <summary>
        /// The user selected a row in the data grid ( Book record ) then presses Borrow, its going to change the Book's isBorrowed field in the DB to True
        /// and it will assign the current user ID to the User_ID field in the Book table in that record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userBorrowBtn_Click(object sender, EventArgs e)
        {
            // Check if a book record is selected
            if (userBooksList.SelectedRows.Count > 0)
            {
                // Retrieve the book ID from the selected row
                int bookID = Convert.ToInt32(userBooksList.SelectedRows[0].Cells["Book_ID"].Value);

                // Check if the book is available for borrowing
                BookRepository bookRepository = new BookRepository();
                bool isAvailable = bookRepository.CheckBookAvailability(bookID);

                if (isAvailable)
                {
                    // Update the book's information in the database
                    bool success = bookRepository.BorrowBook(bookID, currentUserID);

                    if (success)
                    {
                        MessageBox.Show("You have successfully borrowed the book.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Refresh
                        this.bookTableAdapter.Fill(this.lMSDataSet.Book);
                    }
                    else
                    {
                        MessageBox.Show("Failed to borrow the book. Please try again.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This book is not available for borrowing at the moment.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// When a user clicks on Return a Book, the books he borrowed will be retrieved from the DB and he selects which book he wants to return
        /// then the book record of which he returned will remove his User_ID and change isBorrowed field back to False indicating that this book is available again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.FillByUserID(this.lMSDataSet.Book, currentUserID);

            // Check if the user has any books borrowed
            if (userBooksList.Rows.Count == 0)
            {
                MessageBox.Show("You haven't borrowed any books.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh
                this.bookTableAdapter.Fill(this.lMSDataSet.Book);
                return;
            }

            // Check if any book record is selected
            if (userBooksList.SelectedRows.Count > 0)
            {
                // Retrieve the book ID from the selected row
                int bookID = Convert.ToInt32(userBooksList.SelectedRows[0].Cells["Book_ID"].Value);

                // Prompt the user to confirm returning the book
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to return this book?", "Return Book Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Update the book's information in the database
                    BookRepository bookRepository = new BookRepository();
                    bool success = bookRepository.ReturnBook(bookID, currentUserID);

                    if (success)
                    {
                        MessageBox.Show("You have successfully returned the book.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to return the book. Please try again.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Refresh the data grid view
            this.bookTableAdapter.Fill(this.lMSDataSet.Book);
        }
        /// <summary>
        /// When a user clicks on this button, the user will apply for a membership, it will check first if he is already a member
        /// if he is not, a new record will be added to the MembershipAppication table in the DB with Pending status
        /// waiting for a staff member to accept it or reject it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userMemberBtn_Click(object sender, EventArgs e)
        {
            // Check if the user is already a member
            UserRepository userRepository = new UserRepository();
            bool isMember = userRepository.CheckIfUserIsMember(currentUserID);

            if (isMember)
            {
                MessageBox.Show("You are already a member.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Prompt the user with a yes/no question
                DialogResult dialogResult = MessageBox.Show("Do you want to apply for membership?", "Membership Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Call the ApplyForMembership method in UserRepository
                    bool success = userRepository.ApplyForMembership(currentUserID);

                    if (success)
                    {
                        MessageBox.Show("Your membership application has been submitted.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit your membership application. Please try again.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //
    }
}
