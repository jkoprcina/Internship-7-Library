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
            this.SuspendLayout();
            // 
            // BooksLbx
            // 
            this.BooksLbx.FormattingEnabled = true;
            this.BooksLbx.Location = new System.Drawing.Point(169, 12);
            this.BooksLbx.Name = "BooksLbx";
            this.BooksLbx.Size = new System.Drawing.Size(294, 641);
            this.BooksLbx.TabIndex = 0;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(12, 15);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(151, 71);
            this.AddBookBtn.TabIndex = 1;
            this.AddBookBtn.Text = "Add New Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // RemoveBookBtn
            // 
            this.RemoveBookBtn.Location = new System.Drawing.Point(12, 94);
            this.RemoveBookBtn.Name = "RemoveBookBtn";
            this.RemoveBookBtn.Size = new System.Drawing.Size(151, 66);
            this.RemoveBookBtn.TabIndex = 2;
            this.RemoveBookBtn.Text = "Remove Book";
            this.RemoveBookBtn.UseVisualStyleBackColor = true;
            this.RemoveBookBtn.Click += new System.EventHandler(this.RemoveBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(12, 166);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(151, 66);
            this.EditBookBtn.TabIndex = 3;
            this.EditBookBtn.Text = "Edit Book";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // EditStudentBtn
            // 
            this.EditStudentBtn.Location = new System.Drawing.Point(791, 166);
            this.EditStudentBtn.Name = "EditStudentBtn";
            this.EditStudentBtn.Size = new System.Drawing.Size(151, 66);
            this.EditStudentBtn.TabIndex = 6;
            this.EditStudentBtn.Text = "Edit Student";
            this.EditStudentBtn.UseVisualStyleBackColor = true;
            this.EditStudentBtn.Click += new System.EventHandler(this.EditStudentBtn_Click);
            // 
            // RemoveStudentBtn
            // 
            this.RemoveStudentBtn.Location = new System.Drawing.Point(791, 94);
            this.RemoveStudentBtn.Name = "RemoveStudentBtn";
            this.RemoveStudentBtn.Size = new System.Drawing.Size(151, 66);
            this.RemoveStudentBtn.TabIndex = 5;
            this.RemoveStudentBtn.Text = "Remove Student";
            this.RemoveStudentBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentBtn.Click += new System.EventHandler(this.RemoveStudentBtn_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(791, 15);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(151, 71);
            this.AddStudentBtn.TabIndex = 4;
            this.AddStudentBtn.Text = "Add New Student";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(791, 579);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 74);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StudentLbx
            // 
            this.StudentLbx.FormattingEnabled = true;
            this.StudentLbx.Location = new System.Drawing.Point(469, 12);
            this.StudentLbx.Name = "StudentLbx";
            this.StudentLbx.Size = new System.Drawing.Size(300, 641);
            this.StudentLbx.TabIndex = 10;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Location = new System.Drawing.Point(791, 419);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(151, 74);
            this.BorrowBtn.TabIndex = 11;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(791, 499);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(151, 74);
            this.ReturnBtn.TabIndex = 12;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Location = new System.Drawing.Point(12, 419);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(151, 74);
            this.AuthorBtn.TabIndex = 13;
            this.AuthorBtn.Text = "Authors";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            this.AuthorBtn.Click += new System.EventHandler(this.AuthorBtn_Click);
            // 
            // PublisherBtn
            // 
            this.PublisherBtn.Location = new System.Drawing.Point(12, 499);
            this.PublisherBtn.Name = "PublisherBtn";
            this.PublisherBtn.Size = new System.Drawing.Size(151, 74);
            this.PublisherBtn.TabIndex = 14;
            this.PublisherBtn.Text = "Publishers";
            this.PublisherBtn.UseVisualStyleBackColor = true;
            this.PublisherBtn.Click += new System.EventHandler(this.PublisherBtn_Click);
            // 
            // ClassBtn
            // 
            this.ClassBtn.Location = new System.Drawing.Point(12, 579);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(151, 70);
            this.ClassBtn.TabIndex = 15;
            this.ClassBtn.Text = "Classes";
            this.ClassBtn.UseVisualStyleBackColor = true;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 674);
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
    }
}

