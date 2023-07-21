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
    public partial class SuppSellBook : Form
    {
        
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

        public SuppSellBook()
        {
            InitializeComponent();
            // Rounded Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SuppSellBook_Load(object sender, EventArgs e)
        {
            // Rounded Buttons
            sellBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, sellBtn.Width, sellBtn.Height, 15, 15));
            cancelBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 15, 15));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// After filling up the Book's details, pressing on the Sell button will add the book the Book table in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the values entered by the user
            string title = suppTitleTxt.Text;
            string author = suppAuthorTxt.Text;
            string isbn = isbnSuppTxt.Text;
            string category = suppCategoryTxt.SelectedItem.ToString();

            // Create an instance of the BookRepository
            BookRepository bookRepository = new BookRepository();

            // Add the new book to the database
            bool success = bookRepository.AddNewBook(title, author, isbn, category);

            if (success)
            {
                MessageBox.Show("Book sold successfully!");
            }
            else
            {
                MessageBox.Show("Failed to sell the book.");
            }
            
            // Close the SellBookForm
            this.Close();
        }
    }
}
