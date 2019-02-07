namespace Internship_7_Library.Forms.EditForms
{
    partial class EditClassForm
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
            this.LetterLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.LetterTxt = new System.Windows.Forms.TextBox();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ClassLbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LetterLbl
            // 
            this.LetterLbl.AutoSize = true;
            this.LetterLbl.Location = new System.Drawing.Point(210, 107);
            this.LetterLbl.Name = "LetterLbl";
            this.LetterLbl.Size = new System.Drawing.Size(88, 13);
            this.LetterLbl.TabIndex = 22;
            this.LetterLbl.Text = "Enter class letter:";
            this.LetterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(210, 39);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(85, 13);
            this.YearLbl.TabIndex = 21;
            this.YearLbl.Text = "Enter class year:";
            this.YearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LetterTxt
            // 
            this.LetterTxt.Location = new System.Drawing.Point(233, 134);
            this.LetterTxt.Name = "LetterTxt";
            this.LetterTxt.Size = new System.Drawing.Size(37, 20);
            this.LetterTxt.TabIndex = 20;
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(233, 66);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(37, 20);
            this.YearTxt.TabIndex = 19;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(187, 292);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(126, 59);
            this.ExitBtn.TabIndex = 17;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(187, 227);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(126, 59);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // ClassLbx
            // 
            this.ClassLbx.FormattingEnabled = true;
            this.ClassLbx.Location = new System.Drawing.Point(12, 12);
            this.ClassLbx.Name = "ClassLbx";
            this.ClassLbx.Size = new System.Drawing.Size(159, 342);
            this.ClassLbx.TabIndex = 23;
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 363);
            this.Controls.Add(this.ClassLbx);
            this.Controls.Add(this.LetterLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.LetterTxt);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditBtn);
            this.Name = "EditClassForm";
            this.Text = "EditClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LetterLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.TextBox LetterTxt;
        private System.Windows.Forms.TextBox YearTxt;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ListBox ClassLbx;
    }
}