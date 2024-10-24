using System;

namespace AVLMS
{
    partial class Login
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
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To AV\'s Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.LblWelcome_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblpassword.Font = new System.Drawing.Font("Arial", 12F);
            this.lblpassword.Location = new System.Drawing.Point(125, 227);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(110, 23);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password :";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblusername.Font = new System.Drawing.Font("Arial", 12F);
            this.lblusername.Location = new System.Drawing.Point(125, 150);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(111, 23);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username :";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Arial", 12F);
            this.txtusername.Location = new System.Drawing.Point(273, 143);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(200, 30);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Arial", 12F);
            this.txtpassword.Location = new System.Drawing.Point(273, 220);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(200, 30);
            this.txtpassword.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnlogin.Location = new System.Drawing.Point(187, 302);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 39);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnregister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnregister.Location = new System.Drawing.Point(351, 302);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(110, 39);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AVLMS.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
    }
}

