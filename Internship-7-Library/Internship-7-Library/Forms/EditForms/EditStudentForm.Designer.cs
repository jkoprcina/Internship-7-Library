namespace Internship_7_Library.Forms.EditForms
{
    partial class EditStudentForm
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
            this.ClassLbx = new System.Windows.Forms.ListBox();
            this.GenderLbx = new System.Windows.Forms.ListBox();
            this.DateOfBirthDtp = new System.Windows.Forms.DateTimePicker();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassLbx
            // 
            this.ClassLbx.FormattingEnabled = true;
            this.ClassLbx.Location = new System.Drawing.Point(12, 235);
            this.ClassLbx.Name = "ClassLbx";
            this.ClassLbx.Size = new System.Drawing.Size(278, 108);
            this.ClassLbx.TabIndex = 19;
            // 
            // GenderLbx
            // 
            this.GenderLbx.FormattingEnabled = true;
            this.GenderLbx.Location = new System.Drawing.Point(12, 145);
            this.GenderLbx.Name = "GenderLbx";
            this.GenderLbx.Size = new System.Drawing.Size(278, 69);
            this.GenderLbx.TabIndex = 18;
            // 
            // DateOfBirthDtp
            // 
            this.DateOfBirthDtp.Location = new System.Drawing.Point(12, 102);
            this.DateOfBirthDtp.Name = "DateOfBirthDtp";
            this.DateOfBirthDtp.Size = new System.Drawing.Size(278, 20);
            this.DateOfBirthDtp.TabIndex = 17;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(40, 60);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(59, 13);
            this.LastNameLbl.TabIndex = 16;
            this.LastNameLbl.Text = "Last name:";
            this.LastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(40, 17);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(58, 13);
            this.FirstNameLbl.TabIndex = 15;
            this.FirstNameLbl.Text = "First name:";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(135, 57);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(155, 20);
            this.LastNameTxt.TabIndex = 14;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(135, 17);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(155, 20);
            this.FirstNameTxt.TabIndex = 13;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(164, 365);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(126, 59);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(18, 365);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(124, 59);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 435);
            this.Controls.Add(this.ClassLbx);
            this.Controls.Add(this.GenderLbx);
            this.Controls.Add(this.DateOfBirthDtp);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditBtn);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClassLbx;
        private System.Windows.Forms.ListBox GenderLbx;
        private System.Windows.Forms.DateTimePicker DateOfBirthDtp;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}