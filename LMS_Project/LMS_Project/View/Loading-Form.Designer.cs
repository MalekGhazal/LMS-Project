﻿namespace LMS_Project.Forms
{
    partial class Loading_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Form));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.myProgress = new CircularProgressBar.CircularProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(130, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(461, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Library Management System";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(498, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Version 1.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(310, 387);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 0;
			this.label3.Text = "Project By";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(290, 419);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Wei, Sean, Malek";
			// 
			// myProgress
			// 
			this.myProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.myProgress.AnimationSpeed = 600;
			this.myProgress.BackColor = System.Drawing.Color.Transparent;
			this.myProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
			this.myProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.myProgress.InnerColor = System.Drawing.Color.Empty;
			this.myProgress.InnerMargin = 2;
			this.myProgress.InnerWidth = -1;
			this.myProgress.Location = new System.Drawing.Point(246, 127);
			this.myProgress.MarqueeAnimationSpeed = 2000;
			this.myProgress.Name = "myProgress";
			this.myProgress.OuterColor = System.Drawing.Color.White;
			this.myProgress.OuterMargin = -25;
			this.myProgress.OuterWidth = 26;
			this.myProgress.ProgressColor = System.Drawing.SystemColors.HotTrack;
			this.myProgress.ProgressWidth = 25;
			this.myProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.myProgress.Size = new System.Drawing.Size(228, 227);
			this.myProgress.StartAngle = 270;
			this.myProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.myProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.myProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.myProgress.SubscriptText = ".23";
			this.myProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.myProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.myProgress.SuperscriptText = "°C";
			this.myProgress.TabIndex = 1;
			this.myProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.myProgress.Value = 25;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Loading_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(733, 464);
			this.Controls.Add(this.myProgress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Loading_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading_Form";
			this.Load += new System.EventHandler(this.Loading_Form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar myProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}