﻿namespace _3DDataType
{
    partial class RenderDemo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RenderBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RenderBtn
            // 
            this.RenderBtn.Location = new System.Drawing.Point(30, 25);
            this.RenderBtn.Name = "RenderBtn";
            this.RenderBtn.Size = new System.Drawing.Size(75, 23);
            this.RenderBtn.TabIndex = 1;
            this.RenderBtn.Text = "线框";
            this.RenderBtn.UseVisualStyleBackColor = true;
            this.RenderBtn.Click += new System.EventHandler(this.RenderBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 599);
            this.panel1.TabIndex = 2;
            // 
            // RenderDemo
            // 
            this.ClientSize = new System.Drawing.Size(1002, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RenderBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RenderDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random";
            this.Load += new System.EventHandler(this.RenderDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RenderBtn;
        private System.Windows.Forms.Panel panel1;
    }
}