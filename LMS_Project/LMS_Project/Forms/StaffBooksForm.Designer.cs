namespace LMS_Project.Forms
{
    partial class StaffBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffBooksForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffBooksBtn = new System.Windows.Forms.Button();
            this.staffMembersBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.draggingBar = new System.Windows.Forms.Panel();
            this.roundPictureBox1 = new LMS_Project.Classes.RoundPictureBox();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffBooksList = new System.Windows.Forms.DataGridView();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.markBookBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryComBox = new System.Windows.Forms.ComboBox();
            this.lMSDataSet = new LMS_Project.LMSDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LMS_Project.LMSDataSetTableAdapters.BookTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBooksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(1019, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User_Fname";
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
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // staffBooksList
            // 
            this.staffBooksList.AutoGenerateColumns = false;
            this.staffBooksList.BackgroundColor = System.Drawing.Color.White;
            this.staffBooksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffBooksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewTextBoxColumn});
            this.staffBooksList.DataSource = this.bookBindingSource;
            this.staffBooksList.Location = new System.Drawing.Point(354, 153);
            this.staffBooksList.Name = "staffBooksList";
            this.staffBooksList.Size = new System.Drawing.Size(827, 452);
            this.staffBooksList.TabIndex = 11;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.White;
            this.addBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.Location = new System.Drawing.Point(19, 479);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(110, 47);
            this.addBookBtn.TabIndex = 12;
            this.addBookBtn.Text = "Add";
            this.addBookBtn.UseVisualStyleBackColor = false;
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.BackColor = System.Drawing.Color.White;
            this.searchBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBookBtn.FlatAppearance.BorderSize = 0;
            this.searchBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookBtn.Location = new System.Drawing.Point(209, 479);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(110, 47);
            this.searchBookBtn.TabIndex = 12;
            this.searchBookBtn.Text = "Search";
            this.searchBookBtn.UseVisualStyleBackColor = false;
            // 
            // editBookBtn
            // 
            this.editBookBtn.BackColor = System.Drawing.Color.White;
            this.editBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBookBtn.FlatAppearance.BorderSize = 0;
            this.editBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookBtn.Location = new System.Drawing.Point(19, 558);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(110, 47);
            this.editBookBtn.TabIndex = 12;
            this.editBookBtn.Text = "Edit";
            this.editBookBtn.UseVisualStyleBackColor = false;
            // 
            // markBookBtn
            // 
            this.markBookBtn.BackColor = System.Drawing.Color.White;
            this.markBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markBookBtn.FlatAppearance.BorderSize = 0;
            this.markBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markBookBtn.Location = new System.Drawing.Point(209, 558);
            this.markBookBtn.Name = "markBookBtn";
            this.markBookBtn.Size = new System.Drawing.Size(110, 47);
            this.markBookBtn.TabIndex = 12;
            this.markBookBtn.Text = "Mark";
            this.markBookBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Title";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(29, 185);
            this.titleTxtBox.Multiline = true;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(219, 49);
            this.titleTxtBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Author";
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(29, 294);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(219, 20);
            this.authorTxtBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Category";
            // 
            // categoryComBox
            // 
            this.categoryComBox.FormattingEnabled = true;
            this.categoryComBox.Location = new System.Drawing.Point(29, 374);
            this.categoryComBox.Name = "categoryComBox";
            this.categoryComBox.Size = new System.Drawing.Size(219, 21);
            this.categoryComBox.TabIndex = 15;
            // 
            // lMSDataSet
            // 
            this.lMSDataSet.DataSetName = "LMSDataSet";
            this.lMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.lMSDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // isBorrowedDataGridViewTextBoxColumn
            // 
            this.isBorrowedDataGridViewTextBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewTextBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewTextBoxColumn.Name = "isBorrowedDataGridViewTextBoxColumn";
            // 
            // StaffBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 617);
            this.Controls.Add(this.categoryComBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.markBookBtn);
            this.Controls.Add(this.editBookBtn);
            this.Controls.Add(this.searchBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.staffBooksList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.draggingBar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.staffMembersBtn);
            this.Controls.Add(this.staffBooksBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBooksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridView staffBooksList;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button searchBookBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button markBookBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryComBox;
        private LMSDataSet lMSDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LMSDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBorrowedDataGridViewTextBoxColumn;
    }
}