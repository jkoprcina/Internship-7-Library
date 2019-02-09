namespace Internship_7_Library.Forms.MainForms
{
    partial class AuthorForm
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
            this.EditAuthorBtn = new System.Windows.Forms.Button();
            this.RemoveAuthorBtn = new System.Windows.Forms.Button();
            this.AddAuthorBtn = new System.Windows.Forms.Button();
            this.AuthorsLbx = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditAuthorBtn
            // 
            this.EditAuthorBtn.Location = new System.Drawing.Point(314, 280);
            this.EditAuthorBtn.Name = "EditAuthorBtn";
            this.EditAuthorBtn.Size = new System.Drawing.Size(151, 66);
            this.EditAuthorBtn.TabIndex = 17;
            this.EditAuthorBtn.Text = "Edit Author";
            this.EditAuthorBtn.UseVisualStyleBackColor = true;
            this.EditAuthorBtn.Click += new System.EventHandler(this.EditAuthorBtn_Click);
            // 
            // RemoveAuthorBtn
            // 
            this.RemoveAuthorBtn.Location = new System.Drawing.Point(314, 208);
            this.RemoveAuthorBtn.Name = "RemoveAuthorBtn";
            this.RemoveAuthorBtn.Size = new System.Drawing.Size(151, 66);
            this.RemoveAuthorBtn.TabIndex = 16;
            this.RemoveAuthorBtn.Text = "Remove Author";
            this.RemoveAuthorBtn.UseVisualStyleBackColor = true;
            this.RemoveAuthorBtn.Click += new System.EventHandler(this.RemoveAuthorBtn_Click);
            // 
            // AddAuthorBtn
            // 
            this.AddAuthorBtn.Location = new System.Drawing.Point(314, 137);
            this.AddAuthorBtn.Name = "AddAuthorBtn";
            this.AddAuthorBtn.Size = new System.Drawing.Size(151, 66);
            this.AddAuthorBtn.TabIndex = 15;
            this.AddAuthorBtn.Text = "Add New Author";
            this.AddAuthorBtn.UseVisualStyleBackColor = true;
            this.AddAuthorBtn.Click += new System.EventHandler(this.AddAuthorBtn_Click);
            // 
            // AuthorsLbx
            // 
            this.AuthorsLbx.FormattingEnabled = true;
            this.AuthorsLbx.Location = new System.Drawing.Point(12, 12);
            this.AuthorsLbx.Name = "AuthorsLbx";
            this.AuthorsLbx.Size = new System.Drawing.Size(219, 420);
            this.AuthorsLbx.TabIndex = 18;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(314, 351);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 61);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(235, 78);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(73, 16);
            this.LastNameLbl.TabIndex = 27;
            this.LastNameLbl.Text = "Last name:";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(235, 52);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(73, 16);
            this.FirstNameLbl.TabIndex = 26;
            this.FirstNameLbl.Text = "First name:";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(324, 52);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(198, 20);
            this.FirstNameTxt.TabIndex = 25;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(324, 78);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(198, 20);
            this.LastNameTxt.TabIndex = 24;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AuthorsLbx);
            this.Controls.Add(this.EditAuthorBtn);
            this.Controls.Add(this.RemoveAuthorBtn);
            this.Controls.Add(this.AddAuthorBtn);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditAuthorBtn;
        private System.Windows.Forms.Button RemoveAuthorBtn;
        private System.Windows.Forms.Button AddAuthorBtn;
        private System.Windows.Forms.ListBox AuthorsLbx;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
    }
}