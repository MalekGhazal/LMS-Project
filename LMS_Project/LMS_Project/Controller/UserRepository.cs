using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Project.Classes;

namespace LMS_Project.DAL
{
    internal class UserRepository
    {
        /// <summary>
        /// Retrieving all the records from the User table in the DB
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                List<User> users = new List<User>();

                string query = "SELECT * FROM [User]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                User_ID = reader.GetInt32(reader.GetOrdinal("User_ID")),
                                User_Lname = reader.GetString(reader.GetOrdinal("User_Lname")),
                                User_Fname = reader.GetString(reader.GetOrdinal("User_Fname")),
                                User_Phone = reader.GetString(reader.GetOrdinal("User_Phone")),
                                User_Email = reader.GetString(reader.GetOrdinal("User_Email")),
                                User_Role = reader.GetString(reader.GetOrdinal("User_Role")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                            };

                            users.Add(user);
                        }
                    }
                }

                return users;
            }
        }
        /// <summary>
        /// Adding a new member record to the Member table with the selected user's ID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool AddMember(int userID)
        {
            if (CheckIfUserIsMember(userID))
            {
                MessageBox.Show("User is already a member.", "Add Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "INSERT INTO [Member] ([User_ID]) VALUES (@UserID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        /// <summary>
        /// Checking if the user is already a member by going through the Member's records
        /// if the User's ID is found or not found in the table
        /// if found then he is already a member
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool CheckIfUserIsMember(int userID)
        {
            using (SqlConnection conn = new MyDB().GetConnection())
            {
                string query = "SELECT COUNT(*) FROM [Member] WHERE [User_ID] = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        /// <summary>
        /// Adding a new record into the MembershipApplication as an application
        /// setting the initial status to pending
        /// with the current user's ID that applied
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool ApplyForMembership(int userID)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "INSERT INTO MembershipApplication (User_ID, Application_Date, Status) VALUES (@UserID, @ApplicationDate, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
                    command.Parameters.AddWithValue("@Status", "Pending");

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        /// <summary>
        /// Retrieving all the records from MembershipApplication table to review
        /// </summary>
        /// <returns></returns>
        public List<MembershipApplication> GetMembershipApplications()
        {
            List<MembershipApplication> applications = new List<MembershipApplication>();

            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "SELECT * FROM MembershipApplication";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MembershipApplication application = new MembershipApplication
                            {
                                ApplicationID = reader.GetInt32(reader.GetOrdinal("Application_ID")),
                                UserID = reader.GetInt32(reader.GetOrdinal("User_ID")),
                                Status = reader.GetString(reader.GetOrdinal("Status"))
                            };

                            applications.Add(application);
                        }
                    }
                }
            }

            return applications;
        }
        /// <summary>
        /// Updates the status field in the MembershipApplication table
        /// to demonstrate if the staff (admin) accepted or rejected the application
        /// </summary>
        /// <param name="applicationID"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public bool UpdateMembershipApplicationStatus(int applicationID, string status)
        {
            using (SqlConnection connection = new MyDB().GetConnection())
            {
                string query = "UPDATE MembershipApplication SET Status = @Status WHERE Application_ID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


    }
}
