namespace Project_Milestone2_PRG282
{
    partial class LogIn
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
            this.tcLogIn = new System.Windows.Forms.TabControl();
            this.btnExit = new System.Windows.Forms.Button();
            this.SignUp_Tab = new System.Windows.Forms.TabPage();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSignInscreen = new System.Windows.Forms.Button();
            this.btnSignUpScreen = new System.Windows.Forms.Button();
            this.lblDisplayLogIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSign_in = new System.Windows.Forms.Button();
            this.txtLogInUserName = new System.Windows.Forms.TextBox();
            this.SignIn_Tab = new System.Windows.Forms.TabPage();
            this.btnCheat = new System.Windows.Forms.Button();
            this.tcLogIn.SuspendLayout();
            this.SignUp_Tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SignIn_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLogIn
            // 
            this.tcLogIn.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcLogIn.Controls.Add(this.SignIn_Tab);
            this.tcLogIn.Controls.Add(this.SignUp_Tab);
            this.tcLogIn.ItemSize = new System.Drawing.Size(0, 1);
            this.tcLogIn.Location = new System.Drawing.Point(434, 147);
            this.tcLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcLogIn.Name = "tcLogIn";
            this.tcLogIn.SelectedIndex = 0;
            this.tcLogIn.Size = new System.Drawing.Size(619, 406);
            this.tcLogIn.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcLogIn.TabIndex = 0;
            this.tcLogIn.TabIndexChanged += new System.EventHandler(this.tcLogIn_TabIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(46)))), ((int)(((byte)(88)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(0, 481);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(376, 95);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SignUp_Tab
            // 
            this.SignUp_Tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignUp_Tab.Controls.Add(this.btnSignUp);
            this.SignUp_Tab.Controls.Add(this.label3);
            this.SignUp_Tab.Controls.Add(this.label4);
            this.SignUp_Tab.Controls.Add(this.txtCreatePassword);
            this.SignUp_Tab.Controls.Add(this.txtCreateUsername);
            this.SignUp_Tab.Location = new System.Drawing.Point(4, 5);
            this.SignUp_Tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUp_Tab.Name = "SignUp_Tab";
            this.SignUp_Tab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUp_Tab.Size = new System.Drawing.Size(611, 397);
            this.SignUp_Tab.TabIndex = 1;
            this.SignUp_Tab.Text = "Sign Up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.Snow;
            this.btnSignUp.Location = new System.Drawing.Point(251, 183);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(104, 49);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username:";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePassword.Location = new System.Drawing.Point(251, 131);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(180, 30);
            this.txtCreatePassword.TabIndex = 5;
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUsername.Location = new System.Drawing.Point(251, 88);
            this.txtCreateUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(180, 30);
            this.txtCreateUsername.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.btnSignUpScreen);
            this.panel2.Controls.Add(this.btnSignInscreen);
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(347, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 576);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(46)))), ((int)(((byte)(88)))));
            this.panel4.Controls.Add(this.lblDisplayLogIn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(376, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 126);
            this.panel4.TabIndex = 11;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.panelLogo.BackgroundImage = global::Project_Milestone2_PRG282.Properties.Resources.bcLogoFinal;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.MinimumSize = new System.Drawing.Size(347, 123);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(376, 126);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnSignInscreen
            // 
            this.btnSignInscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnSignInscreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignInscreen.FlatAppearance.BorderSize = 0;
            this.btnSignInscreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnSignInscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(46)))), ((int)(((byte)(88)))));
            this.btnSignInscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignInscreen.ForeColor = System.Drawing.Color.Snow;
            this.btnSignInscreen.Location = new System.Drawing.Point(0, 126);
            this.btnSignInscreen.Name = "btnSignInscreen";
            this.btnSignInscreen.Size = new System.Drawing.Size(376, 128);
            this.btnSignInscreen.TabIndex = 0;
            this.btnSignInscreen.Text = "Sign In";
            this.btnSignInscreen.UseVisualStyleBackColor = false;
            this.btnSignInscreen.Click += new System.EventHandler(this.btnSignInscreen_Click);
            // 
            // btnSignUpScreen
            // 
            this.btnSignUpScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnSignUpScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUpScreen.FlatAppearance.BorderSize = 0;
            this.btnSignUpScreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnSignUpScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(46)))), ((int)(((byte)(88)))));
            this.btnSignUpScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpScreen.ForeColor = System.Drawing.Color.Snow;
            this.btnSignUpScreen.Location = new System.Drawing.Point(0, 254);
            this.btnSignUpScreen.Name = "btnSignUpScreen";
            this.btnSignUpScreen.Size = new System.Drawing.Size(376, 128);
            this.btnSignUpScreen.TabIndex = 2;
            this.btnSignUpScreen.Text = "Create Account";
            this.btnSignUpScreen.UseVisualStyleBackColor = false;
            this.btnSignUpScreen.Click += new System.EventHandler(this.btnSignUpScreen_Click);
            // 
            // lblDisplayLogIn
            // 
            this.lblDisplayLogIn.AutoSize = true;
            this.lblDisplayLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayLogIn.ForeColor = System.Drawing.Color.Snow;
            this.lblDisplayLogIn.Location = new System.Drawing.Point(99, 21);
            this.lblDisplayLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayLogIn.Name = "lblDisplayLogIn";
            this.lblDisplayLogIn.Size = new System.Drawing.Size(239, 73);
            this.lblDisplayLogIn.TabIndex = 8;
            this.lblDisplayLogIn.Text = "Sign In";
            this.lblDisplayLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(128, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogInPassword.Location = new System.Drawing.Point(247, 131);
            this.txtLogInPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.PasswordChar = '*';
            this.txtLogInPassword.Size = new System.Drawing.Size(180, 30);
            this.txtLogInPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(135, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnSign_in
            // 
            this.btnSign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnSign_in.FlatAppearance.BorderSize = 0;
            this.btnSign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign_in.ForeColor = System.Drawing.Color.Snow;
            this.btnSign_in.Location = new System.Drawing.Point(247, 186);
            this.btnSign_in.Margin = new System.Windows.Forms.Padding(4);
            this.btnSign_in.Name = "btnSign_in";
            this.btnSign_in.Size = new System.Drawing.Size(111, 50);
            this.btnSign_in.TabIndex = 7;
            this.btnSign_in.Text = "Sign In";
            this.btnSign_in.UseVisualStyleBackColor = false;
            this.btnSign_in.Click += new System.EventHandler(this.btnSign_in_Click);
            // 
            // txtLogInUserName
            // 
            this.txtLogInUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogInUserName.Location = new System.Drawing.Point(247, 88);
            this.txtLogInUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogInUserName.Name = "txtLogInUserName";
            this.txtLogInUserName.Size = new System.Drawing.Size(180, 30);
            this.txtLogInUserName.TabIndex = 0;
            // 
            // SignIn_Tab
            // 
            this.SignIn_Tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignIn_Tab.Controls.Add(this.btnCheat);
            this.SignIn_Tab.Controls.Add(this.txtLogInUserName);
            this.SignIn_Tab.Controls.Add(this.btnSign_in);
            this.SignIn_Tab.Controls.Add(this.label2);
            this.SignIn_Tab.Controls.Add(this.txtLogInPassword);
            this.SignIn_Tab.Controls.Add(this.label1);
            this.SignIn_Tab.Location = new System.Drawing.Point(4, 5);
            this.SignIn_Tab.Margin = new System.Windows.Forms.Padding(4);
            this.SignIn_Tab.Name = "SignIn_Tab";
            this.SignIn_Tab.Padding = new System.Windows.Forms.Padding(4);
            this.SignIn_Tab.Size = new System.Drawing.Size(611, 397);
            this.SignIn_Tab.TabIndex = 0;
            this.SignIn_Tab.Text = "Sign in";
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(513, 30);
            this.btnCheat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(57, 23);
            this.btnCheat.TabIndex = 8;
            this.btnCheat.Text = "Cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1147, 576);
            this.Controls.Add(this.tcLogIn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(100000, 100000);
            this.MinimumSize = new System.Drawing.Size(629, 440);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcLogIn.ResumeLayout(false);
            this.SignUp_Tab.ResumeLayout(false);
            this.SignUp_Tab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.SignIn_Tab.ResumeLayout(false);
            this.SignIn_Tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLogIn;
        private System.Windows.Forms.TabPage SignUp_Tab;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.TextBox txtCreateUsername;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSignUpScreen;
        private System.Windows.Forms.Button btnSignInscreen;
        private System.Windows.Forms.Label lblDisplayLogIn;
        private System.Windows.Forms.TabPage SignIn_Tab;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.TextBox txtLogInUserName;
        private System.Windows.Forms.Button btnSign_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.Label label1;
    }
}

