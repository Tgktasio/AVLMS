using System;

namespace AVLMS
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdminPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManageUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.Location = new System.Drawing.Point(411, 172);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(150, 65);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.BtnManageUsers_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManageBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageBooks.Location = new System.Drawing.Point(170, 172);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(150, 65);
            this.btnManageBooks.TabIndex = 2;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = false;
            this.btnManageBooks.Click += new System.EventHandler(this.BtnManageBooks_Click);
            this.Controls.Add(this.btnManageBooks);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReports.Location = new System.Drawing.Point(170, 284);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 65);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(411, 284);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 65);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAdminPanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(281, 72);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(194, 35);
            this.lblAdminPanel.TabIndex = 0;
            this.lblAdminPanel.Text = "Admin Panel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AVLMS.Properties.Resources.OIP__1_;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(781, 444);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 435);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnManageBooks_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.PictureBox pictureBox2;
        private EventHandler pictureBox2_Click;
    }
}
