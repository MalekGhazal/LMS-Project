using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Project.Classes;
using LMS_Project.DAL;

namespace LMS_Project.Forms
{
    public partial class StaffBooksForm : Form
    {
        public string UserFirstName { get; set; }
        private List<Book> allBooks;


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

        public StaffBooksForm()
        {
            InitializeComponent();
            // Rounded Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            LoadBooksIntoDataGridView();

            // Rounded Buttons
            staffBooksBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffBooksBtn.Width, staffBooksBtn.Height, 15, 15));
            staffMembersBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, staffMembersBtn.Width, staffMembersBtn.Height, 15, 15));
            addBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, addBookBtn.Width, addBookBtn.Height, 15, 15));
            updateBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, updateBookBtn.Width, updateBookBtn.Height, 15, 15));
            deleteBookBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, deleteBookBtn.Width, deleteBookBtn.Height, 15, 15));

            searchByCB.SelectedIndex = 0;
            userFnameLabel.Text = UserFirstName;
        }
        /// <summary>
        /// Loading the Book table records into the Data grid
        /// </summary>
        private void LoadBooksIntoDataGridView()
        {
            BookRepository bookRepository = new BookRepository();
            allBooks = bookRepository.GetAllBooks();

            staffBooksList.DataSource = allBooks;

            if (staffBooksList.Columns.Contains("UserID"))
            {
                staffBooksList.Columns["UserID"].Visible = false;
            }
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

        private void staffMembersBtn_Click(object sender, EventArgs e)
        {
            StaffMembersForm smf = new StaffMembersForm();
            smf.UserFirstName = UserFirstName;
            this.Close();
            smf.Show();
        }
        /// <summary>
        /// Adding a new book after entering the book's info
        /// using the ( AddNewBook ) methed from the BookRepository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            BookRepository bookRepository = new BookRepository();

            string title = titleTxtBox.Text;
            string author = authorTxtBox.Text;
            string isbn = isbnTxtBox.Text;
            string category = categoryComBox.SelectedItem?.ToString();

            // Validate the input
            if (!ValidateBookInput(title, author, isbn, category))
            {
                return;
            }

            bool success = bookRepository.AddNewBook(title, author, isbn, category);

            if (success)
            {
                MessageBox.Show("New book added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add the new book.");
            }

            // Refresh the data source with the updated book list
            staffBooksList.DataSource = bookRepository.GetAllBooks();

            // Clear the input fields
            titleTxtBox.Text = string.Empty;
            authorTxtBox.Text = string.Empty;
            isbnTxtBox.Text = string.Empty;
            categoryComBox.SelectedIndex = -1;
        }
        /// <summary>
        /// Updating the selected book ( row ) after entering the book's new info
        /// using the ( UpdateBook ) methed from the BookRepository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateBookBtn_Click(object sender, EventArgs e)
        {
            BookRepository bookRepository = new BookRepository();

            // Get the selected book ID from the data grid
            if (staffBooksList.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(staffBooksList.SelectedRows[0].Cells["Book_ID"].Value);

                // Get the updated values from the input fields
                string title = titleTxtBox.Text;
                string author = authorTxtBox.Text;
                string isbn = isbnTxtBox.Text;
                string category = categoryComBox.SelectedItem?.ToString();

                // Validate the input
                if (!ValidateBookInput(title, author, isbn, category))
                {
                    return;
                }

                bool success = bookRepository.UpdateBook(bookId, title, author, isbn, category);

                if (success)
                {
                    MessageBox.Show("Book updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update the book.");
                }

                // Refresh the data source with the updated book list
                staffBooksList.DataSource = bookRepository.GetAllBooks();

                // Clear the input fields
                titleTxtBox.Text = string.Empty;
                authorTxtBox.Text = string.Empty;
                isbnTxtBox.Text = string.Empty;
                categoryComBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select a book to update.");
            }
        }
        /// <summary>
        /// Deleting the selected book ( row ) from the Book table and Data grid
        /// using the ( DeleteBook ) method from BookRepository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            BookRepository bookRepository = new BookRepository();

            // Get the selected book ID from the data grid
            if (staffBooksList.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(staffBooksList.SelectedRows[0].Cells["Book_ID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool success = bookRepository.DeleteBook(bookId);

                    if (success)
                    {
                        MessageBox.Show("Book deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the book.");
                    }

                    // Refresh the data source with the updated book list
                    staffBooksList.DataSource = bookRepository.GetAllBooks();

                    // Clear the input fields
                    titleTxtBox.Text = string.Empty;
                    authorTxtBox.Text = string.Empty;
                    isbnTxtBox.Text = string.Empty;
                    categoryComBox.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
        /// <summary>
        /// The search logic in the text box and filtering the data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staffBookSearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(staffBookSearchTxt.Text))
            {
                staffBooksList.DataSource = allBooks;
            }
            else
            {
                string columnName = searchByCB.Text;
                string searchValue = staffBookSearchTxt.Text.Trim().ToLower();

                List<Book> filteredBooks = allBooks;

                switch (columnName)
                {
                    case "Book_ID":
                        if (int.TryParse(searchValue, out int bookId))
                        {
                            filteredBooks = allBooks.Where(book => book.Book_ID == bookId).ToList();
                        }
                        else
                        {
                            // Book_ID input validation
                            MessageBox.Show("Book ID must be a number");
                        }
                        break;

                    case "Title":
                        filteredBooks = allBooks.Where(book => book.Title.ToLower().Contains(searchValue)).ToList();
                        break;

                    case "Author":
                        filteredBooks = allBooks.Where(book => book.Author.ToLower().Contains(searchValue)).ToList();
                        break;

                    case "ISBN":
                        if (long.TryParse(searchValue, out long isbn))
                        {
                            filteredBooks = allBooks.Where(book => book.ISBN.ToLower().Contains(searchValue)).ToList();
                        }
                        else
                        {
                            // ISBN input validation
                            MessageBox.Show("ISBN must be a valid number.");
                        }
                        break;

                    case "Category":
                        filteredBooks = allBooks.Where(book => book.Category.ToLower().Contains(searchValue)).ToList();
                        break;

                    default:
                        MessageBox.Show("Invalid column name selected.");
                        break;
                }

                staffBooksList.DataSource = filteredBooks;
            }
        }
        /// <summary>
        /// This method checks and validate if any of the input fields are empty before adding or updating a book
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        private bool ValidateBookInput(string title, string author, string isbn, string category)
        {
            // Check if any of the input fields are empty or invalid
            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(isbn) ||
                string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all the book details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        //
    }
}
