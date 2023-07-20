namespace LMS_Project.Forms
{
    partial class UserBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.userFNameTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userMemberBtn = new System.Windows.Forms.Button();
            this.staffMembersBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.draggingBar = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.userBooksList = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDataSet = new LMS_Project.LMSDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.userSearchTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userSearchByCB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userBorrowBtn = new System.Windows.Forms.Button();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.bookTableAdapter = new LMS_Project.LMSDataSetTableAdapters.BookTableAdapter();
            this.roundPictureBox1 = new LMS_Project.Classes.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBooksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // userFNameTxt
            // 
            this.userFNameTxt.AutoSize = true;
            this.userFNameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.userFNameTxt.Location = new System.Drawing.Point(1019, 54);
            this.userFNameTxt.Name = "userFNameTxt";
            this.userFNameTxt.Size = new System.Drawing.Size(103, 19);
            this.userFNameTxt.TabIndex = 1;
            this.userFNameTxt.Text = "User_Fname";
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
            // userMemberBtn
            // 
            this.userMemberBtn.BackColor = System.Drawing.Color.White;
            this.userMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userMemberBtn.FlatAppearance.BorderSize = 0;
            this.userMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.userMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userMemberBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.userMemberBtn.Location = new System.Drawing.Point(317, 32);
            this.userMemberBtn.Name = "userMemberBtn";
            this.userMemberBtn.Size = new System.Drawing.Size(260, 41);
            this.userMemberBtn.TabIndex = 5;
            this.userMemberBtn.Text = "Become a Member";
            this.userMemberBtn.UseVisualStyleBackColor = false;
            this.userMemberBtn.Click += new System.EventHandler(this.userMemberBtn_Click);
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
            this.staffMembersBtn.Text = "Books";
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
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // userBooksList
            // 
            this.userBooksList.AllowUserToAddRows = false;
            this.userBooksList.AllowUserToDeleteRows = false;
            this.userBooksList.AutoGenerateColumns = false;
            this.userBooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userBooksList.BackgroundColor = System.Drawing.Color.White;
            this.userBooksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.userBooksList.DataSource = this.bookBindingSource;
            this.userBooksList.Location = new System.Drawing.Point(317, 148);
            this.userBooksList.Name = "userBooksList";
            this.userBooksList.ReadOnly = true;
            this.userBooksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userBooksList.Size = new System.Drawing.Size(864, 432);
            this.userBooksList.TabIndex = 11;
            // 
            // Book_ID
            // 
            this.Book_ID.DataPropertyName = "Book_ID";
            this.Book_ID.HeaderText = "Book ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.lMSDataSet;
            // 
            // lMSDataSet
            // 
            this.lMSDataSet.DataSetName = "LMSDataSet";
            this.lMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Search:";
            // 
            // userSearchTxtBox
            // 
            this.userSearchTxtBox.Location = new System.Drawing.Point(0, 256);
            this.userSearchTxtBox.Name = "userSearchTxtBox";
            this.userSearchTxtBox.Size = new System.Drawing.Size(248, 20);
            this.userSearchTxtBox.TabIndex = 21;
            this.userSearchTxtBox.TextChanged += new System.EventHandler(this.userSearchTxtBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search By:";
            // 
            // userSearchByCB
            // 
            this.userSearchByCB.FormattingEnabled = true;
            this.userSearchByCB.Items.AddRange(new object[] {
            "Book_ID",
            "Title",
            "Author",
            "ISBN",
            "Category"});
            this.userSearchByCB.Location = new System.Drawing.Point(0, 184);
            this.userSearchByCB.Name = "userSearchByCB";
            this.userSearchByCB.Size = new System.Drawing.Size(248, 21);
            this.userSearchByCB.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-55, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // userBorrowBtn
            // 
            this.userBorrowBtn.BackColor = System.Drawing.Color.White;
            this.userBorrowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBorrowBtn.FlatAppearance.BorderSize = 0;
            this.userBorrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.userBorrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBorrowBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBorrowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.userBorrowBtn.Location = new System.Drawing.Point(-12, 310);
            this.userBorrowBtn.Name = "userBorrowBtn";
            this.userBorrowBtn.Size = new System.Drawing.Size(260, 41);
            this.userBorrowBtn.TabIndex = 17;
            this.userBorrowBtn.Text = "Borrow";
            this.userBorrowBtn.UseVisualStyleBackColor = false;
            this.userBorrowBtn.Click += new System.EventHandler(this.userBorrowBtn_Click);
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.BackColor = System.Drawing.Color.White;
            this.returnBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBookBtn.FlatAppearance.BorderSize = 0;
            this.returnBookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.returnBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.returnBookBtn.Location = new System.Drawing.Point(-12, 357);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(260, 41);
            this.returnBookBtn.TabIndex = 17;
            this.returnBookBtn.Text = "Return a Book";
            this.returnBookBtn.UseVisualStyleBackColor = false;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
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
            // UserBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 617);
            this.Controls.Add(this.userBooksList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userSearchTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userSearchByCB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.returnBookBtn);
            this.Controls.Add(this.userBorrowBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.draggingBar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.staffMembersBtn);
            this.Controls.Add(this.userMemberBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.userFNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBooksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userFNameTxt;
        private Classes.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button userMemberBtn;
        private System.Windows.Forms.Button staffMembersBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel draggingBar;
        private System.Windows.Forms.Label logoutBtn;
        private System.Windows.Forms.DataGridView userBooksList;
        private LMSDataSet lMSDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LMSDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userSearchTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox userSearchByCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button userBorrowBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button returnBookBtn;
    }
}