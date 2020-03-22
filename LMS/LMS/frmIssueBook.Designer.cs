﻿namespace LMS
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studImage = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchStud = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboBooks = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtIssue = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtDueDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnAddStudent = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studImage)).BeginInit();
            this.gunaLinePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel1.Controls.Add(this.btnBack);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(12, 2);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(797, 37);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::LMS.Properties.Resources.left_30px;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(8, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(38, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.lblYear);
            this.gunaLinePanel2.Controls.Add(this.lblCourse);
            this.gunaLinePanel2.Controls.Add(this.lblStudNo);
            this.gunaLinePanel2.Controls.Add(this.lblName);
            this.gunaLinePanel2.Controls.Add(this.label4);
            this.gunaLinePanel2.Controls.Add(this.label5);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.studImage);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(12, 115);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(425, 201);
            this.gunaLinePanel2.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(237, 132);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(27, 13);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(237, 107);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 20;
            this.lblCourse.Text = "Course";
            // 
            // lblStudNo
            // 
            this.lblStudNo.AutoSize = true;
            this.lblStudNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNo.Location = new System.Drawing.Point(237, 82);
            this.lblStudNo.Name = "lblStudNo";
            this.lblStudNo.Size = new System.Drawing.Size(92, 13);
            this.lblStudNo.TabIndex = 19;
            this.lblStudNo.Text = "Student Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(237, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Student name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(162, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(162, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(162, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(162, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // studImage
            // 
            this.studImage.BackColor = System.Drawing.Color.White;
            this.studImage.BaseColor = System.Drawing.Color.Gainsboro;
            this.studImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studImage.Image = ((System.Drawing.Image)(resources.GetObject("studImage.Image")));
            this.studImage.Location = new System.Drawing.Point(21, 31);
            this.studImage.Name = "studImage";
            this.studImage.Size = new System.Drawing.Size(130, 130);
            this.studImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studImage.TabIndex = 11;
            this.studImage.TabStop = false;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel3.Controls.Add(this.label14);
            this.gunaLinePanel3.Controls.Add(this.lblAuthor);
            this.gunaLinePanel3.Controls.Add(this.lblSubject);
            this.gunaLinePanel3.Controls.Add(this.lblISBN);
            this.gunaLinePanel3.Controls.Add(this.lblTitle);
            this.gunaLinePanel3.Controls.Add(this.label10);
            this.gunaLinePanel3.Controls.Add(this.label11);
            this.gunaLinePanel3.Controls.Add(this.label12);
            this.gunaLinePanel3.Controls.Add(this.label13);
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel3.LineLeft = 1;
            this.gunaLinePanel3.LineRight = 1;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 1;
            this.gunaLinePanel3.Location = new System.Drawing.Point(470, 115);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(339, 201);
            this.gunaLinePanel3.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(26, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Book Details";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(99, 136);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(27, 13);
            this.lblAuthor.TabIndex = 29;
            this.lblAuthor.Text = "Year";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(99, 111);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 28;
            this.lblSubject.Text = "Course";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(99, 86);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(92, 13);
            this.lblISBN.TabIndex = 27;
            this.lblISBN.Text = "Student Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(99, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 13);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Student name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(36, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Author:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(36, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Subject:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(36, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "ISBN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(36, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Title:";
            // 
            // txtSearchStud
            // 
            this.txtSearchStud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchStud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchStud.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchStud.BeforeTouchSize = new System.Drawing.Size(263, 20);
            this.txtSearchStud.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStud.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearchStud.Location = new System.Drawing.Point(12, 83);
            this.txtSearchStud.Metrocolor = System.Drawing.Color.Gainsboro;
            this.txtSearchStud.Name = "txtSearchStud";
            this.txtSearchStud.Size = new System.Drawing.Size(263, 20);
            this.txtSearchStud.TabIndex = 4;
            this.txtSearchStud.UseBorderColorOnFocus = true;
            this.txtSearchStud.TextChanged += new System.EventHandler(this.TxtSearchStud_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Enter Student Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cboBooks
            // 
            this.cboBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(470, 83);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(265, 21);
            this.cboBooks.TabIndex = 7;
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.CboBooks_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(471, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Enter Book Title";
            // 
            // dtIssue
            // 
            this.dtIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIssue.Location = new System.Drawing.Point(557, 343);
            this.dtIssue.Name = "dtIssue";
            this.dtIssue.Size = new System.Drawing.Size(232, 31);
            this.dtIssue.Style.BackColor = System.Drawing.Color.White;
            this.dtIssue.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(554, 327);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Issue Date";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(554, 382);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Due Date";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDueDate.Location = new System.Drawing.Point(557, 398);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(232, 31);
            this.dtDueDate.Style.BackColor = System.Drawing.Color.White;
            this.dtDueDate.TabIndex = 11;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.AnimationHoverSpeed = 0.07F;
            this.btnAddStudent.AnimationSpeed = 0.03F;
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnAddStudent.BorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = null;
            this.btnAddStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddStudent.Location = new System.Drawing.Point(671, 462);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnAddStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddStudent.OnHoverImage = null;
            this.btnAddStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddStudent.Radius = 15;
            this.btnAddStudent.Size = new System.Drawing.Size(118, 32);
            this.btnAddStudent.TabIndex = 49;
            this.btnAddStudent.Text = "Process Issue";
            this.btnAddStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtIssue);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearchStud);
            this.Controls.Add(this.gunaLinePanel3);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueBook";
            this.Text = "frmIssueBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIssueBook_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studImage)).EndInit();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuImageButton btnBack;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        public Guna.UI.WinForms.GunaPictureBox studImage;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblCourse;
        public System.Windows.Forms.Label lblStudNo;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblAuthor;
        public System.Windows.Forms.Label lblSubject;
        public System.Windows.Forms.Label lblISBN;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchStud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboBooks;
        private System.Windows.Forms.Label label16;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtIssue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtDueDate;
        private Guna.UI.WinForms.GunaButton btnAddStudent;
    }
}