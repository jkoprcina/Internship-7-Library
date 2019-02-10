namespace Internship_7_Library.Forms.AddForms
{
    partial class AddBookForm
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.PageNumberLbl = new System.Windows.Forms.Label();
            this.PageNumberTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PublisherLbx = new System.Windows.Forms.ListBox();
            this.AuthorLbx = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NumberOfBooksLbl = new System.Windows.Forms.Label();
            this.NumberOfBooksTxt = new System.Windows.Forms.TextBox();
            this.GenreLbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(32, 18);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name:";
            // 
            // PageNumberLbl
            // 
            this.PageNumberLbl.AutoSize = true;
            this.PageNumberLbl.Location = new System.Drawing.Point(32, 60);
            this.PageNumberLbl.Name = "PageNumberLbl";
            this.PageNumberLbl.Size = new System.Drawing.Size(91, 13);
            this.PageNumberLbl.TabIndex = 1;
            this.PageNumberLbl.Text = "Number of pages:";
            // 
            // PageNumberTxt
            // 
            this.PageNumberTxt.Location = new System.Drawing.Point(157, 60);
            this.PageNumberTxt.Name = "PageNumberTxt";
            this.PageNumberTxt.Size = new System.Drawing.Size(67, 20);
            this.PageNumberTxt.TabIndex = 2;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(95, 18);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(129, 20);
            this.NameTxt.TabIndex = 3;
            // 
            // PublisherLbx
            // 
            this.PublisherLbx.FormattingEnabled = true;
            this.PublisherLbx.Location = new System.Drawing.Point(34, 416);
            this.PublisherLbx.Name = "PublisherLbx";
            this.PublisherLbx.Size = new System.Drawing.Size(189, 134);
            this.PublisherLbx.TabIndex = 4;
            // 
            // AuthorLbx
            // 
            this.AuthorLbx.FormattingEnabled = true;
            this.AuthorLbx.Location = new System.Drawing.Point(34, 279);
            this.AuthorLbx.Name = "AuthorLbx";
            this.AuthorLbx.Size = new System.Drawing.Size(189, 121);
            this.AuthorLbx.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(136, 578);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(111, 59);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(11, 578);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 59);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NumberOfBooksLbl
            // 
            this.NumberOfBooksLbl.AutoSize = true;
            this.NumberOfBooksLbl.Location = new System.Drawing.Point(32, 96);
            this.NumberOfBooksLbl.Name = "NumberOfBooksLbl";
            this.NumberOfBooksLbl.Size = new System.Drawing.Size(93, 13);
            this.NumberOfBooksLbl.TabIndex = 8;
            this.NumberOfBooksLbl.Text = "Number of copies:";
            // 
            // NumberOfBooksTxt
            // 
            this.NumberOfBooksTxt.Location = new System.Drawing.Point(157, 96);
            this.NumberOfBooksTxt.Name = "NumberOfBooksTxt";
            this.NumberOfBooksTxt.Size = new System.Drawing.Size(67, 20);
            this.NumberOfBooksTxt.TabIndex = 9;
            // 
            // GenreLbx
            // 
            this.GenreLbx.FormattingEnabled = true;
            this.GenreLbx.Location = new System.Drawing.Point(34, 141);
            this.GenreLbx.Name = "GenreLbx";
            this.GenreLbx.Size = new System.Drawing.Size(189, 121);
            this.GenreLbx.TabIndex = 10;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 656);
            this.Controls.Add(this.GenreLbx);
            this.Controls.Add(this.NumberOfBooksTxt);
            this.Controls.Add(this.NumberOfBooksLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AuthorLbx);
            this.Controls.Add(this.PublisherLbx);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.PageNumberTxt);
            this.Controls.Add(this.PageNumberLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "AddBookForm";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label PageNumberLbl;
        private System.Windows.Forms.TextBox PageNumberTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.ListBox PublisherLbx;
        private System.Windows.Forms.ListBox AuthorLbx;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NumberOfBooksLbl;
        private System.Windows.Forms.TextBox NumberOfBooksTxt;
        private System.Windows.Forms.ListBox GenreLbx;
    }
}