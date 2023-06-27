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
    public partial class SuppSellBook : Form
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

        public SuppSellBook()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region
                .FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SuppSellBook_Load(object sender, EventArgs e)
        {
            sellBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, sellBtn.Width, sellBtn.Height, 15, 15));
            cancelBtn.Region = Region.FromHrgn
                (CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 15, 15));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
