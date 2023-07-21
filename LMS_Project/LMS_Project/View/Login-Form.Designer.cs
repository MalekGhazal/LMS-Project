namespace LMS_Project.Forms
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
			this.panel1 = new System.Windows.Forms.Panel();
			this.loginCloseBtn = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.passwordTxtBox = new System.Windows.Forms.TextBox();
			this.usernameTxtBox = new System.Windows.Forms.TextBox();
			this.clearBtn = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.loginCloseBtn);
			this.panel1.Controls.Add(this.loginBtn);
			this.panel1.Controls.Add(this.passwordTxtBox);
			this.panel1.Controls.Add(this.usernameTxtBox);
			this.panel1.Controls.Add(this.clearBtn);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 464);
			this.panel1.TabIndex = 0;
			// 
			// loginCloseBtn
			// 
			this.loginCloseBtn.AutoSize = true;
			this.loginCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginCloseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginCloseBtn.ForeColor = System.Drawing.Color.White;
			this.loginCloseBtn.Location = new System.Drawing.Point(5, 5);
			this.loginCloseBtn.Name = "loginCloseBtn";
			this.loginCloseBtn.Size = new System.Drawing.Size(29, 17);
			this.loginCloseBtn.TabIndex = 3;
			this.loginCloseBtn.Text = "Exit";
			this.loginCloseBtn.Click += new System.EventHandler(this.loginCloseBtn_Click);
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.Color.White;
			this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginBtn.FlatAppearance.BorderSize = 0;
			this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.loginBtn.Location = new System.Drawing.Point(59, 352);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(146, 38);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "LOGIN";
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// passwordTxtBox
			// 
			this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passwordTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTxtBox.ForeColor = System.Drawing.Color.LightGray;
			this.passwordTxtBox.Location = new System.Drawing.Point(22, 263);
			this.passwordTxtBox.Name = "passwordTxtBox";
			this.passwordTxtBox.Size = new System.Drawing.Size(220, 27);
			this.passwordTxtBox.TabIndex = 1;
			this.passwordTxtBox.Text = "Your Password";
			this.passwordTxtBox.UseSystemPasswordChar = true;
			this.passwordTxtBox.Enter += new System.EventHandler(this.passwordTxtBox_Enter);
			this.passwordTxtBox.Leave += new System.EventHandler(this.passwordTxtBox_Leave);
			// 
			// usernameTxtBox
			// 
			this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.usernameTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTxtBox.ForeColor = System.Drawing.Color.LightGray;
			this.usernameTxtBox.Location = new System.Drawing.Point(22, 199);
			this.usernameTxtBox.Name = "usernameTxtBox";
			this.usernameTxtBox.Size = new System.Drawing.Size(220, 27);
			this.usernameTxtBox.TabIndex = 1;
			this.usernameTxtBox.Text = "Your Username";
			this.usernameTxtBox.Enter += new System.EventHandler(this.usernameTxtBox_Enter);
			this.usernameTxtBox.Leave += new System.EventHandler(this.usernameTxtBox_Leave);
			// 
			// clearBtn
			// 
			this.clearBtn.AutoSize = true;
			this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBtn.ForeColor = System.Drawing.Color.White;
			this.clearBtn.Location = new System.Drawing.Point(99, 402);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(67, 25);
			this.clearBtn.TabIndex = 0;
			this.clearBtn.Text = "Clear";
			this.clearBtn.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(32, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "USER LOGIN";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(738, 464);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Login_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(733, 464);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login_Form";
			this.Load += new System.EventHandler(this.Login_Form_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label clearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginCloseBtn;
    }
}