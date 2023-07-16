namespace LMS_Project.Forms
{
    partial class StaffMembersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMembersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userFnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffBooksBtn = new System.Windows.Forms.Button();
            this.staffMembersBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.draggingBar = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffUsersList = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDataSet = new LMS_Project.LMSDataSet();
            this.lendUserBtn = new System.Windows.Forms.Button();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.userTableAdapter = new LMS_Project.LMSDataSetTableAdapters.UserTableAdapter();
            this.roundPictureBox1 = new LMS_Project.Classes.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1039, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userFnameLabel
            // 
            this.userFnameLabel.AutoSize = true;
            this.userFnameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.userFnameLabel.Location = new System.Drawing.Point(1019, 54);
            this.userFnameLabel.Name = "userFnameLabel";
            this.userFnameLabel.Size = new System.Drawing.Size(103, 19);
            this.userFnameLabel.TabIndex = 1;
            this.userFnameLabel.Text = "User_Fname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vanier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Library";
            // 
            // staffBooksBtn
            // 
            this.staffBooksBtn.BackColor = System.Drawing.Color.White;
            this.staffBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBooksBtn.FlatAppearance.BorderSize = 0;
            this.staffBooksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.staffBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBooksBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBooksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.staffBooksBtn.Location = new System.Drawing.Point(317, 32);
            this.staffBooksBtn.Name = "staffBooksBtn";
            this.staffBooksBtn.Size = new System.Drawing.Size(260, 41);
            this.staffBooksBtn.TabIndex = 5;
            this.staffBooksBtn.Text = "Manage Books";
            this.staffBooksBtn.UseVisualStyleBackColor = false;
            this.staffBooksBtn.Click += new System.EventHandler(this.staffBooksBtn_Click);
            // 
            // staffMembersBtn
            // 
            this.staffMembersBtn.BackColor = System.Drawing.Color.White;
            this.staffMembersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffMembersBtn.FlatAppearance.BorderSize = 0;
            this.staffMembersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.staffMembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffMembersBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffMembersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.staffMembersBtn.Location = new System.Drawing.Point(659, 32);
            this.staffMembersBtn.Name = "staffMembersBtn";
            this.staffMembersBtn.Size = new System.Drawing.Size(260, 41);
            this.staffMembersBtn.TabIndex = 5;
            this.staffMembersBtn.Text = "Manage Members";
            this.staffMembersBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1166, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1136, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // draggingBar
            // 
            this.draggingBar.Location = new System.Drawing.Point(0, 1);
            this.draggingBar.Name = "draggingBar";
            this.draggingBar.Size = new System.Drawing.Size(1130, 16);
            this.draggingBar.TabIndex = 7;
            this.draggingBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.draggingBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(1064, 78);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(58, 17);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // staffUsersList
            // 
            this.staffUsersList.AllowUserToAddRows = false;
            this.staffUsersList.AllowUserToDeleteRows = false;
            this.staffUsersList.AutoGenerateColumns = false;
            this.staffUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffUsersList.BackgroundColor = System.Drawing.Color.White;
            this.staffUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userLnameDataGridViewTextBoxColumn,
            this.userFnameDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.User_Role});
            this.staffUsersList.DataSource = this.userBindingSource;
            this.staffUsersList.Location = new System.Drawing.Point(19, 127);
            this.staffUsersList.Name = "staffUsersList";
            this.staffUsersList.ReadOnly = true;
            this.staffUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffUsersList.Size = new System.Drawing.Size(1162, 369);
            this.staffUsersList.TabIndex = 12;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLnameDataGridViewTextBoxColumn
            // 
            this.userLnameDataGridViewTextBoxColumn.DataPropertyName = "User_Lname";
            this.userLnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.userLnameDataGridViewTextBoxColumn.Name = "userLnameDataGridViewTextBoxColumn";
            this.userLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userFnameDataGridViewTextBoxColumn
            // 
            this.userFnameDataGridViewTextBoxColumn.DataPropertyName = "User_Fname";
            this.userFnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.userFnameDataGridViewTextBoxColumn.Name = "userFnameDataGridViewTextBoxColumn";
            this.userFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "User_Phone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            this.userPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "User_Email";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            this.userEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // User_Role
            // 
            this.User_Role.DataPropertyName = "User_Role";
            this.User_Role.HeaderText = "Role";
            this.User_Role.Name = "User_Role";
            this.User_Role.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.lMSDataSet;
            // 
            // lMSDataSet
            // 
            this.lMSDataSet.DataSetName = "LMSDataSet";
            this.lMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendUserBtn
            // 
            this.lendUserBtn.BackColor = System.Drawing.Color.White;
            this.lendUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lendUserBtn.FlatAppearance.BorderSize = 0;
            this.lendUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.lendUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendUserBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.lendUserBtn.Location = new System.Drawing.Point(317, 540);
            this.lendUserBtn.Name = "lendUserBtn";
            this.lendUserBtn.Size = new System.Drawing.Size(260, 41);
            this.lendUserBtn.TabIndex = 5;
            this.lendUserBtn.Text = "Lend a User";
            this.lendUserBtn.UseVisualStyleBackColor = false;
            this.lendUserBtn.Click += new System.EventHandler(this.staffBooksBtn_Click);
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.Color.White;
            this.addMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBtn.FlatAppearance.BorderSize = 0;
            this.addMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.addMemberBtn.Location = new System.Drawing.Point(659, 540);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(260, 41);
            this.addMemberBtn.TabIndex = 5;
            this.addMemberBtn.Text = "Add as Member";
            this.addMemberBtn.UseVisualStyleBackColor = false;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(1131, 25);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(53, 70);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPictureBox1.TabIndex = 2;
            this.roundPictureBox1.TabStop = false;
            // 
            // StaffMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 617);
            this.Controls.Add(this.staffUsersList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.draggingBar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.lendUserBtn);
            this.Controls.Add(this.staffMembersBtn);
            this.Controls.Add(this.staffBooksBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.userFnameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userFnameLabel;
        private Classes.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button staffBooksBtn;
        private System.Windows.Forms.Button staffMembersBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel draggingBar;
        private System.Windows.Forms.Label logoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView staffUsersList;
        private System.Windows.Forms.Button lendUserBtn;
        private System.Windows.Forms.Button addMemberBtn;
        private LMSDataSet lMSDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LMSDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Role;
    }
}