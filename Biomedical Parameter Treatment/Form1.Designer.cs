namespace Biomedical_Parameter_Treatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginB = new System.Windows.Forms.Button();
            this.login_passwordTB = new System.Windows.Forms.TextBox();
            this.login_usernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.designationTB = new System.Windows.Forms.TextBox();
            this.hospitalTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.signup_usernameTB = new System.Windows.Forms.TextBox();
            this.signup_passwordTB = new System.Windows.Forms.TextBox();
            this.signupB = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginB);
            this.panel1.Controls.Add(this.login_passwordTB);
            this.panel1.Controls.Add(this.login_usernameTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 77);
            this.panel1.TabIndex = 0;
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(657, 28);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 23);
            this.loginB.TabIndex = 4;
            this.loginB.Text = "Log In";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // login_passwordTB
            // 
            this.login_passwordTB.Location = new System.Drawing.Point(502, 32);
            this.login_passwordTB.Name = "login_passwordTB";
            this.login_passwordTB.PasswordChar = '*';
            this.login_passwordTB.Size = new System.Drawing.Size(148, 20);
            this.login_passwordTB.TabIndex = 3;
            this.login_passwordTB.Text = "mithun";
            // 
            // login_usernameTB
            // 
            this.login_usernameTB.Location = new System.Drawing.Point(348, 32);
            this.login_usernameTB.Name = "login_usernameTB";
            this.login_usernameTB.Size = new System.Drawing.Size(148, 20);
            this.login_usernameTB.TabIndex = 2;
            this.login_usernameTB.Text = "mithun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hospital/Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "password";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(568, 157);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(178, 20);
            this.nameTB.TabIndex = 8;
            // 
            // designationTB
            // 
            this.designationTB.Location = new System.Drawing.Point(568, 185);
            this.designationTB.Name = "designationTB";
            this.designationTB.Size = new System.Drawing.Size(178, 20);
            this.designationTB.TabIndex = 9;
            // 
            // hospitalTB
            // 
            this.hospitalTB.Location = new System.Drawing.Point(568, 219);
            this.hospitalTB.Name = "hospitalTB";
            this.hospitalTB.Size = new System.Drawing.Size(178, 20);
            this.hospitalTB.TabIndex = 10;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(568, 250);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(178, 20);
            this.phoneTB.TabIndex = 11;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(568, 279);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(178, 20);
            this.emailTB.TabIndex = 12;
            // 
            // signup_usernameTB
            // 
            this.signup_usernameTB.Location = new System.Drawing.Point(568, 310);
            this.signup_usernameTB.Name = "signup_usernameTB";
            this.signup_usernameTB.Size = new System.Drawing.Size(178, 20);
            this.signup_usernameTB.TabIndex = 13;
            // 
            // signup_passwordTB
            // 
            this.signup_passwordTB.Location = new System.Drawing.Point(568, 340);
            this.signup_passwordTB.Name = "signup_passwordTB";
            this.signup_passwordTB.PasswordChar = '*';
            this.signup_passwordTB.Size = new System.Drawing.Size(178, 20);
            this.signup_passwordTB.TabIndex = 14;
            // 
            // signupB
            // 
            this.signupB.Location = new System.Drawing.Point(671, 376);
            this.signupB.Name = "signupB";
            this.signupB.Size = new System.Drawing.Size(75, 23);
            this.signupB.TabIndex = 15;
            this.signupB.Text = "Sign Up";
            this.signupB.UseVisualStyleBackColor = true;
            this.signupB.Click += new System.EventHandler(this.signupB_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(409, 17);
            this.toolStripStatusLabel1.Text = "Developed By: Institute of Information Technology, Jahangirnagar University";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 434);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.signupB);
            this.Controls.Add(this.signup_passwordTB);
            this.Controls.Add(this.signup_usernameTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.hospitalTB);
            this.Controls.Add(this.designationTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biomedical Parameter Treatment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.TextBox login_passwordTB;
        private System.Windows.Forms.TextBox login_usernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox designationTB;
        private System.Windows.Forms.TextBox hospitalTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox signup_usernameTB;
        private System.Windows.Forms.TextBox signup_passwordTB;
        private System.Windows.Forms.Button signupB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

