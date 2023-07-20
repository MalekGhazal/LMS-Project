using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_Project.Classes;

namespace LMS_Project.DAL
{
    public class BookRepository
    {
        /// <summary>
        /// Retrieves the Book table from the DB
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                List<Book> books = new List<Book>();

                string query = "SELECT * FROM Book";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                Book_ID = reader.GetInt32(reader.GetOrdinal("Book_ID")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Author = reader.GetString(reader.GetOrdinal("Author")),
                                ISBN = reader.GetString(reader.GetOrdinal("ISBN")),
                                Category = reader.GetString(reader.GetOrdinal("Category")),
                                IsBorrowed = reader.GetBoolean(reader.GetOrdinal("isBorrowed"))
                            };

                            books.Add(book);
                        }
                    }
                }

                return books;
            }
        }
        /// <summary>
        /// Adds a new Book to the Book table in the DB
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool AddNewBook(string title, string author, string isbn, string category)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Book (Title, Author, ISBN, Category, isBorrowed) " +
                                   "VALUES (@Title, @Author, @ISBN, @Category, @IsBorrowed)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@IsBorrowed", false);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Updates a book record in the Book table in the DB
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="isbn"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool UpdateBook(int bookId, string title, string author, string isbn, string category)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Book " +
                                   "SET Title = @Title, Author = @Author, ISBN = @ISBN, Category = @Category " +
                                   "WHERE Book_ID = @BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@BookID", bookId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Deletes a Book record in the DB from the Book table based on the Book's ID
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public bool DeleteBook(int bookId)
        {
            using (SqlConnection conn = new MyDB().GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Book WHERE Book_ID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                } catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Updates the (isBorrowed) field to True at the selected Book record..
        /// and inserting the User_ID of which the book has been lent to ( selected )
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool LendBook(int bookID, int userID)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Book SET IsBorrowed = 1, User_ID = @UserID WHERE Book_ID = @BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookID);
                        command.Parameters.AddWithValue("@UserID", userID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Checking if the (isBorrowed) field at the selected book record is already True
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool CheckIfBookIsBorrowed(int bookID)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "SELECT IsBorrowed FROM Book WHERE Book_ID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    bool isBorrowed = Convert.ToBoolean(command.ExecuteScalar());

                    return isBorrowed;
                }
            }
        }
        /// <summary>
        /// Updates the (isBorrowed) field to True at the selected Book record..
        /// and inserting the current user's ID that is using the form ( Logged in )
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool BorrowBook(int bookID, int userID)
        {
            bool isAvailable = CheckBookAvailability(bookID);

            if (isAvailable)
            {
                using (SqlConnection connection = new MyDB().GetConnection())
                {
                    string query = "UPDATE Book SET IsBorrowed = 1, User_ID = @UserID WHERE Book_ID = @BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookID);
                        command.Parameters.AddWithValue("@UserID", userID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checking if the (isBorrowed) field at the selected book record is already True
        /// and if it has any User_ID assigned to it
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool CheckBookAvailability(int bookID)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "SELECT IsBorrowed FROM Book WHERE Book_ID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    return result != null && result != DBNull.Value && !Convert.ToBoolean(result);
                }
            }
        }
        /// <summary>
        /// Updates (isBorrowed) back to False and removing the assigned User_ID
        /// {{ The opposite of lending a book }}
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool ReturnBook(int bookID, int userID)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "UPDATE Book SET IsBorrowed = 0, User_ID = NULL WHERE Book_ID = @BookID AND User_ID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        /// <summary>
        /// Retrieving the Book records where the User_ID field has the current user's ID
        /// so getting the books of which the user has borrowed
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<Book> GetUserBooks(int userID)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                List<Book> userBooks = new List<Book>();

                string query = "SELECT * FROM Book WHERE User_ID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                Book_ID = reader.GetInt32(reader.GetOrdinal("Book_ID")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Author = reader.GetString(reader.GetOrdinal("Author")),
                                ISBN = reader.GetString(reader.GetOrdinal("ISBN")),
                                Category = reader.GetString(reader.GetOrdinal("Category")),
                                IsBorrowed = reader.GetBoolean(reader.GetOrdinal("IsBorrowed")),
                                UserID = (int)(reader.IsDBNull(reader.GetOrdinal("User_ID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("User_ID")))
                            };

                            userBooks.Add(book);
                        }
                    }
                }

                return userBooks;
            }
        }


    }
}
