﻿namespace Project_Milestone2_PRG282
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SignIn_Tab = new System.Windows.Forms.TabPage();
            this.btnSign_in = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SignUp_Tab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SignIn_Tab.SuspendLayout();
            this.SignUp_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SignIn_Tab);
            this.tabControl1.Controls.Add(this.SignUp_Tab);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // SignIn_Tab
            // 
            this.SignIn_Tab.BackgroundImage = global::Project_Milestone2_PRG282.Properties.Resources.MainImage;
            this.SignIn_Tab.Controls.Add(this.btnSign_in);
            this.SignIn_Tab.Controls.Add(this.label5);
            this.SignIn_Tab.Controls.Add(this.btnExit);
            this.SignIn_Tab.Controls.Add(this.label2);
            this.SignIn_Tab.Controls.Add(this.label1);
            this.SignIn_Tab.Controls.Add(this.textBox2);
            this.SignIn_Tab.Controls.Add(this.textBox1);
            this.SignIn_Tab.Location = new System.Drawing.Point(4, 22);
            this.SignIn_Tab.Name = "SignIn_Tab";
            this.SignIn_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.SignIn_Tab.Size = new System.Drawing.Size(510, 340);
            this.SignIn_Tab.TabIndex = 0;
            this.SignIn_Tab.Text = "Sign in";
            this.SignIn_Tab.UseVisualStyleBackColor = true;
            // 
            // btnSign_in
            // 
            this.btnSign_in.Location = new System.Drawing.Point(201, 226);
            this.btnSign_in.Name = "btnSign_in";
            this.btnSign_in.Size = new System.Drawing.Size(75, 23);
            this.btnSign_in.TabIndex = 7;
            this.btnSign_in.Text = "Sign In";
            this.btnSign_in.UseVisualStyleBackColor = true;
            this.btnSign_in.Click += new System.EventHandler(this.btnSign_in_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sign in to continue...";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(8, 307);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(215, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(215, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 0;
            // 
            // SignUp_Tab
            // 
            this.SignUp_Tab.BackgroundImage = global::Project_Milestone2_PRG282.Properties.Resources.MainImage;
            this.SignUp_Tab.Controls.Add(this.btnSignUp);
            this.SignUp_Tab.Controls.Add(this.label6);
            this.SignUp_Tab.Controls.Add(this.label3);
            this.SignUp_Tab.Controls.Add(this.label4);
            this.SignUp_Tab.Controls.Add(this.textBox3);
            this.SignUp_Tab.Controls.Add(this.textBox4);
            this.SignUp_Tab.Controls.Add(this.button1);
            this.SignUp_Tab.Location = new System.Drawing.Point(4, 22);
            this.SignUp_Tab.Name = "SignUp_Tab";
            this.SignUp_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.SignUp_Tab.Size = new System.Drawing.Size(510, 340);
            this.SignUp_Tab.TabIndex = 1;
            this.SignUp_Tab.Text = "Sign Up";
            this.SignUp_Tab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(215, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(215, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 26);
            this.textBox4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Goldenrod;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(419, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Create account to get started...";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(201, 226);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 366);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(532, 405);
            this.MinimumSize = new System.Drawing.Size(532, 405);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.SignIn_Tab.ResumeLayout(false);
            this.SignIn_Tab.PerformLayout();
            this.SignUp_Tab.ResumeLayout(false);
            this.SignUp_Tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SignIn_Tab;
        private System.Windows.Forms.TabPage SignUp_Tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSign_in;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label6;
    }
}

