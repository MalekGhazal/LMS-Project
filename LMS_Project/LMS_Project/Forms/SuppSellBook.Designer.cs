namespace LMS_Project.Forms
{
    partial class SuppSellBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.suppTitleTxt = new System.Windows.Forms.TextBox();
            this.suppAuthorTxt = new System.Windows.Forms.TextBox();
            this.suppCategoryTxt = new System.Windows.Forms.ComboBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.isbnSuppTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(191, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category:";
            // 
            // suppTitleTxt
            // 
            this.suppTitleTxt.Location = new System.Drawing.Point(128, 150);
            this.suppTitleTxt.Multiline = true;
            this.suppTitleTxt.Name = "suppTitleTxt";
            this.suppTitleTxt.Size = new System.Drawing.Size(258, 31);
            this.suppTitleTxt.TabIndex = 2;
            // 
            // suppAuthorTxt
            // 
            this.suppAuthorTxt.Location = new System.Drawing.Point(128, 249);
            this.suppAuthorTxt.Name = "suppAuthorTxt";
            this.suppAuthorTxt.Size = new System.Drawing.Size(258, 20);
            this.suppAuthorTxt.TabIndex = 2;
            // 
            // suppCategoryTxt
            // 
            this.suppCategoryTxt.FormattingEnabled = true;
            this.suppCategoryTxt.Items.AddRange(new object[] {
            "Fiction",
            "Romance",
            "Classic",
            "History",
            "Business",
            "Fantasy"});
            this.suppCategoryTxt.Location = new System.Drawing.Point(128, 337);
            this.suppCategoryTxt.Name = "suppCategoryTxt";
            this.suppCategoryTxt.Size = new System.Drawing.Size(258, 21);
            this.suppCategoryTxt.TabIndex = 3;
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.White;
            this.sellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellBtn.FlatAppearance.BorderSize = 0;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.sellBtn.Location = new System.Drawing.Point(132, 462);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(251, 54);
            this.sellBtn.TabIndex = 4;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.cancelBtn.Location = new System.Drawing.Point(132, 540);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(251, 54);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "ISBN:";
            // 
            // isbnSuppTxt
            // 
            this.isbnSuppTxt.Location = new System.Drawing.Point(128, 420);
            this.isbnSuppTxt.Name = "isbnSuppTxt";
            this.isbnSuppTxt.Size = new System.Drawing.Size(258, 20);
            this.isbnSuppTxt.TabIndex = 2;
            // 
            // SuppSellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 617);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.suppCategoryTxt);
            this.Controls.Add(this.isbnSuppTxt);
            this.Controls.Add(this.suppAuthorTxt);
            this.Controls.Add(this.suppTitleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuppSellBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppSellBook";
            this.Load += new System.EventHandler(this.SuppSellBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox suppTitleTxt;
        private System.Windows.Forms.TextBox suppAuthorTxt;
        private System.Windows.Forms.ComboBox suppCategoryTxt;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbnSuppTxt;
    }
}