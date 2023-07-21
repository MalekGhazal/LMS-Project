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
    public partial class Applications : Form
    {
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

        public Applications()
        {
            InitializeComponent();
            // Rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Applications_Load(object sender, EventArgs e)
        {
            LoadMembershipApplications();
            // Rounded Buttons
            acceptBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, acceptBtn.Width, acceptBtn.Height, 15, 15));
            rejectBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, rejectBtn.Width, rejectBtn.Height, 15, 15));
        }
        /// <summary>
        /// Loading the MembershipApplication table records into the Datagrid
        /// </summary>
        private void LoadMembershipApplications()
        {
            UserRepository applicationRepository = new UserRepository();
            List<MembershipApplication> applications = applicationRepository.GetMembershipApplications();

            applicationsList.DataSource = applications;
        }

        // Application accept button
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (applicationsList.SelectedRows.Count > 0)
            {
                // Get the selected user ID from the DataGridView
                int userID = Convert.ToInt32(applicationsList.SelectedRows[0].Cells["UserID"].Value);

                // Update the application status to Accepted in the database
                UserRepository userRepository = new UserRepository();
                int applicationID = Convert.ToInt32(applicationsList.SelectedRows[0].Cells["ApplicationID"].Value);
                bool success = userRepository.UpdateMembershipApplicationStatus(applicationID, "Accepted");

                if (success)
                {
                    // Add the user to the Member table
                    bool memberAdded = userRepository.AddMember(userID);

                    if (memberAdded)
                    {
                        MessageBox.Show("Membership application accepted. User has been added as a member.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Membership application accepted, but failed to add the user as a member.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to accept the membership application.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh the membership applications grid
                LoadMembershipApplications();
            }
            else
            {
                MessageBox.Show("Please select a membership application to accept.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        // Application rejection button
        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if (applicationsList.SelectedRows.Count > 0)
            {
                // Get the selected application ID
                int applicationID = Convert.ToInt32(applicationsList.SelectedRows[0].Cells["ApplicationID"].Value);

                // Update the application status to Rejected in the database
                UserRepository userRepository = new UserRepository();
                bool success = userRepository.UpdateMembershipApplicationStatus(applicationID, "Rejected");

                if (success)
                {
                    MessageBox.Show("Membership application rejected.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to reject the membership application.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh the membership applications grid
                LoadMembershipApplications();
            }
            else
            {
                MessageBox.Show("Please select a membership application to reject.", "Membership Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
