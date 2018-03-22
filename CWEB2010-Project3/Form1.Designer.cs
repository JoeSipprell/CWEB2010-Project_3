namespace CWEB2010_Project3
{
    partial class Form1
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
            this.LoginTitle = new System.Windows.Forms.Label();
            this.UsernameLab = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.EnterBox = new System.Windows.Forms.Button();
            this.badPass = new System.Windows.Forms.Label();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.LoginPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(121, 21);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(195, 39);
            this.LoginTitle.TabIndex = 1;
            this.LoginTitle.Text = "Login Page";
            // 
            // UsernameLab
            // 
            this.UsernameLab.AutoSize = true;
            this.UsernameLab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLab.Location = new System.Drawing.Point(118, 111);
            this.UsernameLab.Name = "UsernameLab";
            this.UsernameLab.Size = new System.Drawing.Size(92, 21);
            this.UsernameLab.TabIndex = 2;
            this.UsernameLab.Text = "Username:";
            // 
            // usernamebox
            // 
            this.usernamebox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebox.Location = new System.Drawing.Point(216, 114);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(100, 23);
            this.usernamebox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(215, 153);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 23);
            this.passwordBox.TabIndex = 5;
            // 
            // EnterBox
            // 
            this.EnterBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBox.Location = new System.Drawing.Point(227, 182);
            this.EnterBox.Name = "EnterBox";
            this.EnterBox.Size = new System.Drawing.Size(75, 23);
            this.EnterBox.TabIndex = 6;
            this.EnterBox.Text = "Enter";
            this.EnterBox.UseVisualStyleBackColor = true;
            this.EnterBox.Click += new System.EventHandler(this.EnterBox_Click);
            // 
            // badPass
            // 
            this.badPass.AutoSize = true;
            this.badPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badPass.ForeColor = System.Drawing.Color.Red;
            this.badPass.Location = new System.Drawing.Point(79, 73);
            this.badPass.Name = "badPass";
            this.badPass.Size = new System.Drawing.Size(317, 21);
            this.badPass.TabIndex = 7;
            this.badPass.Text = "*Username and/or password is incorrect";
            this.badPass.Visible = false;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.badPass);
            this.LoginPage.Controls.Add(this.LoginTitle);
            this.LoginPage.Controls.Add(this.EnterBox);
            this.LoginPage.Controls.Add(this.UsernameLab);
            this.LoginPage.Controls.Add(this.passwordBox);
            this.LoginPage.Controls.Add(this.usernamebox);
            this.LoginPage.Controls.Add(this.label1);
            this.LoginPage.Location = new System.Drawing.Point(76, 35);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(451, 230);
            this.LoginPage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 455);
            this.Controls.Add(this.LoginPage);
            this.Name = "Form1";
            this.Text = "Boolin XP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Label UsernameLab;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button EnterBox;
        private System.Windows.Forms.Label badPass;
        private System.Windows.Forms.Panel LoginPage;
    }
}

