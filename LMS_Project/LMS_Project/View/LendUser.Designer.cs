namespace LMS_Project.Forms
{
    partial class LendUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendUser));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lendUserList = new System.Windows.Forms.DataGridView();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.lendBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.lendUserList)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(563, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "List";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
			this.label2.Location = new System.Drawing.Point(468, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 56);
			this.label2.TabIndex = 0;
			this.label2.Text = "Book";
			// 
			// lendUserList
			// 
			this.lendUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.lendUserList.BackgroundColor = System.Drawing.Color.White;
			this.lendUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lendUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lendUserList.Location = new System.Drawing.Point(12, 128);
			this.lendUserList.Name = "lendUserList";
			this.lendUserList.Size = new System.Drawing.Size(1149, 366);
			this.lendUserList.TabIndex = 1;
			// 
			// cancelBtn
			// 
			this.cancelBtn.BackColor = System.Drawing.Color.White;
			this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancelBtn.FlatAppearance.BorderSize = 0;
			this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
			this.cancelBtn.Location = new System.Drawing.Point(276, 530);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(251, 54);
			this.cancelBtn.TabIndex = 5;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// lendBtn
			// 
			this.lendBtn.BackColor = System.Drawing.Color.White;
			this.lendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lendBtn.FlatAppearance.BorderSize = 0;
			this.lendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lendBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
			this.lendBtn.Location = new System.Drawing.Point(624, 530);
			this.lendBtn.Name = "lendBtn";
			this.lendBtn.Size = new System.Drawing.Size(251, 54);
			this.lendBtn.TabIndex = 5;
			this.lendBtn.Text = "Lend";
			this.lendBtn.UseVisualStyleBackColor = false;
			this.lendBtn.Click += new System.EventHandler(this.lendBtn_Click);
			// 
			// LendUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1173, 614);
			this.Controls.Add(this.lendBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.lendUserList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LendUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SuppSellBook";
			this.Load += new System.EventHandler(this.SuppSellBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.lendUserList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lendUserList;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button lendBtn;
    }
}