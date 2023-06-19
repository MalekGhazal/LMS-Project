using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project.Forms
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Loading ...
            startPoint += 1;
            myProgress.Value = startPoint;

            // When it hits 100, value goes back to 0 and the timer stops
            if (myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();

                // Start the Login form after reaching 100
                Login_Form login = new Login_Form();
                login.Show();

                // Hiding this form.
                this.Hide();
            }
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
