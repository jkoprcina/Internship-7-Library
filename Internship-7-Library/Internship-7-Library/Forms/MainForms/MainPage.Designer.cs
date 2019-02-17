namespace Internship_7_Library.Forms
{
    partial class MainPage
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
            this.BooksLbx = new System.Windows.Forms.ListBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.RemoveBookBtn = new System.Windows.Forms.Button();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.EditStudentBtn = new System.Windows.Forms.Button();
            this.RemoveStudentBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.StudentLbx = new System.Windows.Forms.ListBox();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.AuthorBtn = new System.Windows.Forms.Button();
            this.PublisherBtn = new System.Windows.Forms.Button();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.NumberOfDaysTxt = new System.Windows.Forms.TextBox();
            this.NumberOfDaysLbl = new System.Windows.Forms.Label();
            this.LoanReturnTxt = new System.Windows.Forms.TextBox();
            this.LoanReturnBtn = new System.Windows.Forms.Button();
            this.ReturnLoanLbl = new System.Windows.Forms.Label();
            this.AddRemoveCopiesTxt = new System.Windows.Forms.TextBox();
            this.AddCopiesBtn = new System.Windows.Forms.Button();
            this.RemoveCopiesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BooksLbx
            // 
            this.BooksLbx.FormattingEnabled = true;
            this.BooksLbx.Location = new System.Drawing.Point(255, 12);
            this.BooksLbx.Name = "BooksLbx";
            this.BooksLbx.Size = new System.Drawing.Size(342, 693);
            this.BooksLbx.TabIndex = 0;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(12, 15);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(213, 71);
            this.AddBookBtn.TabIndex = 1;
            this.AddBookBtn.Text = "Add New Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // RemoveBookBtn
            // 
            this.RemoveBookBtn.Location = new System.Drawing.Point(12, 94);
            this.RemoveBookBtn.Name = "RemoveBookBtn";
            this.RemoveBookBtn.Size = new System.Drawing.Size(213, 66);
            this.RemoveBookBtn.TabIndex = 2;
            this.RemoveBookBtn.Text = "Remove Book";
            this.RemoveBookBtn.UseVisualStyleBackColor = true;
            this.RemoveBookBtn.Click += new System.EventHandler(this.RemoveBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(12, 166);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(213, 66);
            this.EditBookBtn.TabIndex = 3;
            this.EditBookBtn.Text = "Edit Book";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // EditStudentBtn
            // 
            this.EditStudentBtn.Location = new System.Drawing.Point(972, 166);
            this.EditStudentBtn.Name = "EditStudentBtn";
            this.EditStudentBtn.Size = new System.Drawing.Size(209, 66);
            this.EditStudentBtn.TabIndex = 6;
            this.EditStudentBtn.Text = "Edit Student";
            this.EditStudentBtn.UseVisualStyleBackColor = true;
            this.EditStudentBtn.Click += new System.EventHandler(this.EditStudentBtn_Click);
            // 
            // RemoveStudentBtn
            // 
            this.RemoveStudentBtn.Location = new System.Drawing.Point(972, 94);
            this.RemoveStudentBtn.Name = "RemoveStudentBtn";
            this.RemoveStudentBtn.Size = new System.Drawing.Size(209, 66);
            this.RemoveStudentBtn.TabIndex = 5;
            this.RemoveStudentBtn.Text = "Remove Student";
            this.RemoveStudentBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentBtn.Click += new System.EventHandler(this.RemoveStudentBtn_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(972, 15);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(209, 71);
            this.AddStudentBtn.TabIndex = 4;
            this.AddStudentBtn.Text = "Add New Student";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(972, 642);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(209, 74);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StudentLbx
            // 
            this.StudentLbx.FormattingEnabled = true;
            this.StudentLbx.Location = new System.Drawing.Point(603, 12);
            this.StudentLbx.Name = "StudentLbx";
            this.StudentLbx.Size = new System.Drawing.Size(334, 693);
            this.StudentLbx.TabIndex = 10;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Location = new System.Drawing.Point(972, 482);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(209, 74);
            this.BorrowBtn.TabIndex = 11;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(972, 562);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(209, 74);
            this.ReturnBtn.TabIndex = 12;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Location = new System.Drawing.Point(12, 486);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(213, 74);
            this.AuthorBtn.TabIndex = 13;
            this.AuthorBtn.Text = "Authors";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            this.AuthorBtn.Click += new System.EventHandler(this.AuthorBtn_Click);
            // 
            // PublisherBtn
            // 
            this.PublisherBtn.Location = new System.Drawing.Point(12, 566);
            this.PublisherBtn.Name = "PublisherBtn";
            this.PublisherBtn.Size = new System.Drawing.Size(213, 74);
            this.PublisherBtn.TabIndex = 14;
            this.PublisherBtn.Text = "Publishers";
            this.PublisherBtn.UseVisualStyleBackColor = true;
            this.PublisherBtn.Click += new System.EventHandler(this.PublisherBtn_Click);
            // 
            // ClassBtn
            // 
            this.ClassBtn.Location = new System.Drawing.Point(12, 646);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(213, 70);
            this.ClassBtn.TabIndex = 15;
            this.ClassBtn.Text = "Classes";
            this.ClassBtn.UseVisualStyleBackColor = true;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // NumberOfDaysTxt
            // 
            this.NumberOfDaysTxt.Location = new System.Drawing.Point(1024, 438);
            this.NumberOfDaysTxt.Name = "NumberOfDaysTxt";
            this.NumberOfDaysTxt.Size = new System.Drawing.Size(100, 20);
            this.NumberOfDaysTxt.TabIndex = 16;
            // 
            // NumberOfDaysLbl
            // 
            this.NumberOfDaysLbl.AutoSize = true;
            this.NumberOfDaysLbl.Location = new System.Drawing.Point(949, 400);
            this.NumberOfDaysLbl.Name = "NumberOfDaysLbl";
            this.NumberOfDaysLbl.Size = new System.Drawing.Size(249, 26);
            this.NumberOfDaysLbl.TabIndex = 17;
            this.NumberOfDaysLbl.Text = "Enter the number of days the book will be borrowed\r\n*if nothing is entered the de" +
    "fault value is 30 days\r\n";
            // 
            // LoanReturnTxt
            // 
            this.LoanReturnTxt.Location = new System.Drawing.Point(1024, 278);
            this.LoanReturnTxt.Name = "LoanReturnTxt";
            this.LoanReturnTxt.Size = new System.Drawing.Size(100, 20);
            this.LoanReturnTxt.TabIndex = 18;
            // 
            // LoanReturnBtn
            // 
            this.LoanReturnBtn.Location = new System.Drawing.Point(972, 304);
            this.LoanReturnBtn.Name = "LoanReturnBtn";
            this.LoanReturnBtn.Size = new System.Drawing.Size(209, 72);
            this.LoanReturnBtn.TabIndex = 19;
            this.LoanReturnBtn.Text = "Return Money";
            this.LoanReturnBtn.UseVisualStyleBackColor = true;
            this.LoanReturnBtn.Click += new System.EventHandler(this.LoanReturnBtn_Click);
            // 
            // ReturnLoanLbl
            // 
            this.ReturnLoanLbl.AutoSize = true;
            this.ReturnLoanLbl.Location = new System.Drawing.Point(949, 253);
            this.ReturnLoanLbl.Name = "ReturnLoanLbl";
            this.ReturnLoanLbl.Size = new System.Drawing.Size(260, 13);
            this.ReturnLoanLbl.TabIndex = 20;
            this.ReturnLoanLbl.Text = "Enter the ammount of money the student has returned";
            // 
            // AddRemoveCopiesTxt
            // 
            this.AddRemoveCopiesTxt.Location = new System.Drawing.Point(71, 268);
            this.AddRemoveCopiesTxt.Name = "AddRemoveCopiesTxt";
            this.AddRemoveCopiesTxt.Size = new System.Drawing.Size(100, 20);
            this.AddRemoveCopiesTxt.TabIndex = 21;
            // 
            // AddCopiesBtn
            // 
            this.AddCopiesBtn.Location = new System.Drawing.Point(12, 307);
            this.AddCopiesBtn.Name = "AddCopiesBtn";
            this.AddCopiesBtn.Size = new System.Drawing.Size(213, 63);
            this.AddCopiesBtn.TabIndex = 22;
            this.AddCopiesBtn.Text = "Add Book Copies";
            this.AddCopiesBtn.UseVisualStyleBackColor = true;
            this.AddCopiesBtn.Click += new System.EventHandler(this.AddCopiesBtn_Click);
            // 
            // RemoveCopiesBtn
            // 
            this.RemoveCopiesBtn.Location = new System.Drawing.Point(12, 376);
            this.RemoveCopiesBtn.Name = "RemoveCopiesBtn";
            this.RemoveCopiesBtn.Size = new System.Drawing.Size(213, 65);
            this.RemoveCopiesBtn.TabIndex = 23;
            this.RemoveCopiesBtn.Text = "Remove Book Copies";
            this.RemoveCopiesBtn.UseVisualStyleBackColor = true;
            this.RemoveCopiesBtn.Click += new System.EventHandler(this.RemoveCopiesBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 732);
            this.Controls.Add(this.RemoveCopiesBtn);
            this.Controls.Add(this.AddCopiesBtn);
            this.Controls.Add(this.AddRemoveCopiesTxt);
            this.Controls.Add(this.ReturnLoanLbl);
            this.Controls.Add(this.LoanReturnBtn);
            this.Controls.Add(this.LoanReturnTxt);
            this.Controls.Add(this.NumberOfDaysLbl);
            this.Controls.Add(this.NumberOfDaysTxt);
            this.Controls.Add(this.ClassBtn);
            this.Controls.Add(this.PublisherBtn);
            this.Controls.Add(this.AuthorBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.BorrowBtn);
            this.Controls.Add(this.StudentLbx);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.EditStudentBtn);
            this.Controls.Add(this.RemoveStudentBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.RemoveBookBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.BooksLbx);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooksLbx;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button RemoveBookBtn;
        private System.Windows.Forms.Button EditBookBtn;
        private System.Windows.Forms.Button EditStudentBtn;
        private System.Windows.Forms.Button RemoveStudentBtn;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox StudentLbx;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button AuthorBtn;
        private System.Windows.Forms.Button PublisherBtn;
        private System.Windows.Forms.Button ClassBtn;
        private System.Windows.Forms.TextBox NumberOfDaysTxt;
        private System.Windows.Forms.Label NumberOfDaysLbl;
        private System.Windows.Forms.TextBox LoanReturnTxt;
        private System.Windows.Forms.Button LoanReturnBtn;
        private System.Windows.Forms.Label ReturnLoanLbl;
        private System.Windows.Forms.TextBox AddRemoveCopiesTxt;
        private System.Windows.Forms.Button AddCopiesBtn;
        private System.Windows.Forms.Button RemoveCopiesBtn;
    }
}

