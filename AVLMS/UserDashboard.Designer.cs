using System.Drawing;
using System;
using System.Windows.Forms;

namespace AVLMS
{
    partial class UserDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnViewBooks;
        private Button btnBorrowBooks;
        private Button btnReturnBooks;
        private Button btnLogout;
        private Label lblWelcome;

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.btnBorrowBooks = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(95, 47);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(226, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [Username]";
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewBooks.Location = new System.Drawing.Point(100, 100);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Size = new System.Drawing.Size(200, 40);
            this.btnViewBooks.TabIndex = 1;
            this.btnViewBooks.Text = "View Books";
            this.btnViewBooks.UseVisualStyleBackColor = true;
           // this.btnViewBooks.Click += new System.EventHandler(this.BtnViewBooks_Click);
            // 
            // btnBorrowBooks
            // 
            this.btnBorrowBooks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrowBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrowBooks.Location = new System.Drawing.Point(100, 160);
            this.btnBorrowBooks.Name = "btnBorrowBooks";
            this.btnBorrowBooks.Size = new System.Drawing.Size(200, 40);
            this.btnBorrowBooks.TabIndex = 2;
            this.btnBorrowBooks.Text = "Borrow Books";
            this.btnBorrowBooks.UseVisualStyleBackColor = true;
           //this.btnBorrowBooks.Click += new System.EventHandler(this.BtnBorrowBooks_Click);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReturnBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturnBooks.Location = new System.Drawing.Point(100, 220);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(200, 40);
            this.btnReturnBooks.TabIndex = 3;
            this.btnReturnBooks.Text = "Return Books";
            this.btnReturnBooks.UseVisualStyleBackColor = true;
           // this.btnReturnBooks.Click += new System.EventHandler(this.BtnReturnBooks_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(100, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            //this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AVLMS.Properties.Resources.OIP__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturnBooks);
            this.Controls.Add(this.btnBorrowBooks);
            this.Controls.Add(this.btnViewBooks);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserDashboard";
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnReturnBooks_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnBorrowBooks_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private PictureBox pictureBox1;
    }
}
