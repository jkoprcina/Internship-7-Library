namespace Internship_7_Library.Forms.AddForms
{
    partial class AddClassForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClassRtx = new System.Windows.Forms.RichTextBox();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.LetterTxt = new System.Windows.Forms.TextBox();
            this.YearLbl = new System.Windows.Forms.Label();
            this.LetterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(187, 292);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(126, 59);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(187, 227);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 59);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ClassRtx
            // 
            this.ClassRtx.Location = new System.Drawing.Point(12, 12);
            this.ClassRtx.Name = "ClassRtx";
            this.ClassRtx.Size = new System.Drawing.Size(169, 339);
            this.ClassRtx.TabIndex = 11;
            this.ClassRtx.Text = "";
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(233, 66);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(37, 20);
            this.YearTxt.TabIndex = 12;
            // 
            // LetterTxt
            // 
            this.LetterTxt.Location = new System.Drawing.Point(233, 134);
            this.LetterTxt.Name = "LetterTxt";
            this.LetterTxt.Size = new System.Drawing.Size(37, 20);
            this.LetterTxt.TabIndex = 13;
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(210, 39);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(85, 13);
            this.YearLbl.TabIndex = 14;
            this.YearLbl.Text = "Enter class year:";
            this.YearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LetterLbl
            // 
            this.LetterLbl.AutoSize = true;
            this.LetterLbl.Location = new System.Drawing.Point(210, 107);
            this.LetterLbl.Name = "LetterLbl";
            this.LetterLbl.Size = new System.Drawing.Size(88, 13);
            this.LetterLbl.TabIndex = 15;
            this.LetterLbl.Text = "Enter class letter:";
            this.LetterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 365);
            this.Controls.Add(this.LetterLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.LetterTxt);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.ClassRtx);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.RichTextBox ClassRtx;
        private System.Windows.Forms.TextBox YearTxt;
        private System.Windows.Forms.TextBox LetterTxt;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label LetterLbl;
    }
}