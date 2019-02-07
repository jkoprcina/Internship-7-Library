﻿namespace Internship_7_Library.Forms.EditForms
{
    partial class EditBookForm
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AuthorLbx = new System.Windows.Forms.ListBox();
            this.PublisherLbx = new System.Windows.Forms.ListBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PageNumberTxt = new System.Windows.Forms.TextBox();
            this.PageNumberLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(141, 399);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(111, 59);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(16, 399);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(111, 59);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AuthorLbx
            // 
            this.AuthorLbx.FormattingEnabled = true;
            this.AuthorLbx.Location = new System.Drawing.Point(39, 100);
            this.AuthorLbx.Name = "AuthorLbx";
            this.AuthorLbx.Size = new System.Drawing.Size(189, 121);
            this.AuthorLbx.TabIndex = 13;
            // 
            // PublisherLbx
            // 
            this.PublisherLbx.FormattingEnabled = true;
            this.PublisherLbx.Location = new System.Drawing.Point(39, 237);
            this.PublisherLbx.Name = "PublisherLbx";
            this.PublisherLbx.Size = new System.Drawing.Size(189, 134);
            this.PublisherLbx.TabIndex = 12;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(99, 19);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(129, 20);
            this.NameTxt.TabIndex = 11;
            // 
            // PageNumberTxt
            // 
            this.PageNumberTxt.Location = new System.Drawing.Point(161, 61);
            this.PageNumberTxt.Name = "PageNumberTxt";
            this.PageNumberTxt.Size = new System.Drawing.Size(67, 20);
            this.PageNumberTxt.TabIndex = 10;
            // 
            // PageNumberLbl
            // 
            this.PageNumberLbl.AutoSize = true;
            this.PageNumberLbl.Location = new System.Drawing.Point(36, 61);
            this.PageNumberLbl.Name = "PageNumberLbl";
            this.PageNumberLbl.Size = new System.Drawing.Size(91, 13);
            this.PageNumberLbl.TabIndex = 9;
            this.PageNumberLbl.Text = "Number of pages:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(36, 19);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name:";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 476);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AuthorLbx);
            this.Controls.Add(this.PublisherLbx);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.PageNumberTxt);
            this.Controls.Add(this.PageNumberLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ListBox AuthorLbx;
        private System.Windows.Forms.ListBox PublisherLbx;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PageNumberTxt;
        private System.Windows.Forms.Label PageNumberLbl;
        private System.Windows.Forms.Label NameLbl;
    }
}