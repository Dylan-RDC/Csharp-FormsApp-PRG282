﻿
namespace Project_Milestone2_PRG282
{
    partial class MainForm
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnResetStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richAddress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudSurname = new System.Windows.Forms.TextBox();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.redAddress = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PreviewPic = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.edtPhone = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtStudNum = new System.Windows.Forms.TextBox();
            this.lblDisplayCRUD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(540, 76);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(636, 278);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(768, 362);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(44, 28);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(820, 362);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(44, 28);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(872, 362);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 28);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(924, 362);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(44, 28);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 76);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 562);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.lblFilePath);
            this.tabPage1.Controls.Add(this.btnPath);
            this.tabPage1.Controls.Add(this.btnResetStudent);
            this.tabPage1.Controls.Add(this.btnAddStudent);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.richAddress);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtDOB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.picStudent);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtStudSurname);
            this.tabPage1.Controls.Add(this.txtStudName);
            this.tabPage1.Controls.Add(this.txtStudentNum);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(449, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert Student";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(301, 150);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 17);
            this.lblFilePath.TabIndex = 26;
            this.lblFilePath.Visible = false;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(261, 191);
            this.btnPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(35, 23);
            this.btnPath.TabIndex = 25;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnResetStudent
            // 
            this.btnResetStudent.Location = new System.Drawing.Point(59, 497);
            this.btnResetStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetStudent.Name = "btnResetStudent";
            this.btnResetStudent.Size = new System.Drawing.Size(100, 28);
            this.btnResetStudent.TabIndex = 22;
            this.btnResetStudent.Text = "Reset";
            this.btnResetStudent.UseVisualStyleBackColor = true;
            this.btnResetStudent.Click += new System.EventHandler(this.btnResetStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(291, 497);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 28);
            this.btnAddStudent.TabIndex = 21;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 411);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Module Codes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Student Address";
            // 
            // richAddress
            // 
            this.richAddress.Location = new System.Drawing.Point(168, 319);
            this.richAddress.Margin = new System.Windows.Forms.Padding(4);
            this.richAddress.Name = "richAddress";
            this.richAddress.Size = new System.Drawing.Size(169, 80);
            this.richAddress.TabIndex = 18;
            this.richAddress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(168, 223);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(169, 22);
            this.dtDOB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Image";
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(168, 140);
            this.picStudent.Margin = new System.Windows.Forms.Padding(4);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(85, 75);
            this.picStudent.TabIndex = 10;
            this.picStudent.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Undefined"});
            this.cmbGender.Location = new System.Drawing.Point(168, 255);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(93, 24);
            this.cmbGender.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(168, 287);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(169, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Number";
            // 
            // txtStudSurname
            // 
            this.txtStudSurname.Location = new System.Drawing.Point(168, 108);
            this.txtStudSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudSurname.Name = "txtStudSurname";
            this.txtStudSurname.Size = new System.Drawing.Size(169, 22);
            this.txtStudSurname.TabIndex = 2;
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(168, 76);
            this.txtStudName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(169, 22);
            this.txtStudName.TabIndex = 1;
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(168, 44);
            this.txtStudentNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.ReadOnly = true;
            this.txtStudentNum.Size = new System.Drawing.Size(169, 22);
            this.txtStudentNum.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Goldenrod;
            this.tabPage2.Controls.Add(this.checkedListBox2);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.redAddress);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dtDate);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.PreviewPic);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.cbbGender);
            this.tabPage2.Controls.Add(this.edtPhone);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.edtSurname);
            this.tabPage2.Controls.Add(this.edtName);
            this.tabPage2.Controls.Add(this.edtStudNum);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(449, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update/Delete Student";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 497);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 497);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 497);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Module Codes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 319);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Student Address";
            // 
            // redAddress
            // 
            this.redAddress.Location = new System.Drawing.Point(172, 315);
            this.redAddress.Margin = new System.Windows.Forms.Padding(4);
            this.redAddress.Name = "redAddress";
            this.redAddress.Size = new System.Drawing.Size(169, 57);
            this.redAddress.TabIndex = 38;
            this.redAddress.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 287);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 255);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Gender";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(172, 219);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(169, 22);
            this.dtDate.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 223);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Date of Birth";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 137);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "Student Image";
            // 
            // PreviewPic
            // 
            this.PreviewPic.Location = new System.Drawing.Point(172, 137);
            this.PreviewPic.Margin = new System.Windows.Forms.Padding(4);
            this.PreviewPic.Name = "PreviewPic";
            this.PreviewPic.Size = new System.Drawing.Size(85, 75);
            this.PreviewPic.TabIndex = 31;
            this.PreviewPic.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 108);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Student Surname";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 76);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 17);
            this.label19.TabIndex = 29;
            this.label19.Text = "Student Name";
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Undefined"});
            this.cbbGender.Location = new System.Drawing.Point(172, 251);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(93, 24);
            this.cbbGender.TabIndex = 28;
            // 
            // edtPhone
            // 
            this.edtPhone.Location = new System.Drawing.Point(172, 283);
            this.edtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.edtPhone.Name = "edtPhone";
            this.edtPhone.Size = new System.Drawing.Size(169, 22);
            this.edtPhone.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 44);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 17);
            this.label20.TabIndex = 26;
            this.label20.Text = "Student Number";
            // 
            // edtSurname
            // 
            this.edtSurname.Location = new System.Drawing.Point(172, 105);
            this.edtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(169, 22);
            this.edtSurname.TabIndex = 25;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(172, 73);
            this.edtName.Margin = new System.Windows.Forms.Padding(4);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(169, 22);
            this.edtName.TabIndex = 24;
            // 
            // edtStudNum
            // 
            this.edtStudNum.Location = new System.Drawing.Point(172, 41);
            this.edtStudNum.Margin = new System.Windows.Forms.Padding(4);
            this.edtStudNum.Name = "edtStudNum";
            this.edtStudNum.ReadOnly = true;
            this.edtStudNum.Size = new System.Drawing.Size(169, 22);
            this.edtStudNum.TabIndex = 23;
            // 
            // lblDisplayCRUD
            // 
            this.lblDisplayCRUD.AutoSize = true;
            this.lblDisplayCRUD.BackColor = System.Drawing.Color.Goldenrod;
            this.lblDisplayCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayCRUD.Location = new System.Drawing.Point(16, 30);
            this.lblDisplayCRUD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayCRUD.Name = "lblDisplayCRUD";
            this.lblDisplayCRUD.Size = new System.Drawing.Size(53, 44);
            this.lblDisplayCRUD.TabIndex = 7;
            this.lblDisplayCRUD.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Goldenrod;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(544, 404);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 44);
            this.label10.TabIndex = 8;
            this.label10.Text = "Search";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Goldenrod;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(532, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 44);
            this.label11.TabIndex = 9;
            this.label11.Text = "Display";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(613, 479);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Student Number";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(836, 476);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1085, 610);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(168, 411);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(169, 72);
            this.checkedListBox1.TabIndex = 27;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(172, 385);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(169, 106);
            this.checkedListBox2.TabIndex = 44;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Milestone2_PRG282.Properties.Resources.Image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDisplayCRUD);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1217, 689);
            this.MinimumSize = new System.Drawing.Size(1217, 689);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDisplayCRUD;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudSurname;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Button btnResetStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox redAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox PreviewPic;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox edtPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtStudNum;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}