namespace Internship_7_Library
{
    partial class ClassForm
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
            this.EditClassBtn = new System.Windows.Forms.Button();
            this.RemoveClassBtn = new System.Windows.Forms.Button();
            this.AddClassBtn = new System.Windows.Forms.Button();
            this.ClassLbx = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.LetterLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.LetterTxt = new System.Windows.Forms.TextBox();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditClassBtn
            // 
            this.EditClassBtn.Location = new System.Drawing.Point(127, 310);
            this.EditClassBtn.Name = "EditClassBtn";
            this.EditClassBtn.Size = new System.Drawing.Size(151, 66);
            this.EditClassBtn.TabIndex = 16;
            this.EditClassBtn.Text = "Edit Class";
            this.EditClassBtn.UseVisualStyleBackColor = true;
            this.EditClassBtn.Click += new System.EventHandler(this.EditClassBtn_Click);
            // 
            // RemoveClassBtn
            // 
            this.RemoveClassBtn.Location = new System.Drawing.Point(127, 238);
            this.RemoveClassBtn.Name = "RemoveClassBtn";
            this.RemoveClassBtn.Size = new System.Drawing.Size(151, 66);
            this.RemoveClassBtn.TabIndex = 15;
            this.RemoveClassBtn.Text = "Remove Class";
            this.RemoveClassBtn.UseVisualStyleBackColor = true;
            this.RemoveClassBtn.Click += new System.EventHandler(this.RemoveClassBtn_Click);
            // 
            // AddClassBtn
            // 
            this.AddClassBtn.Location = new System.Drawing.Point(127, 167);
            this.AddClassBtn.Name = "AddClassBtn";
            this.AddClassBtn.Size = new System.Drawing.Size(151, 66);
            this.AddClassBtn.TabIndex = 14;
            this.AddClassBtn.Text = "Add New Class";
            this.AddClassBtn.UseVisualStyleBackColor = true;
            this.AddClassBtn.Click += new System.EventHandler(this.AddClassBtn_Click);
            // 
            // ClassLbx
            // 
            this.ClassLbx.FormattingEnabled = true;
            this.ClassLbx.Location = new System.Drawing.Point(12, 12);
            this.ClassLbx.Name = "ClassLbx";
            this.ClassLbx.Size = new System.Drawing.Size(109, 433);
            this.ClassLbx.TabIndex = 17;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(127, 383);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 61);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LetterLbl
            // 
            this.LetterLbl.AutoSize = true;
            this.LetterLbl.Location = new System.Drawing.Point(161, 95);
            this.LetterLbl.Name = "LetterLbl";
            this.LetterLbl.Size = new System.Drawing.Size(88, 13);
            this.LetterLbl.TabIndex = 27;
            this.LetterLbl.Text = "Enter class letter:";
            this.LetterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(161, 27);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(85, 13);
            this.YearLbl.TabIndex = 26;
            this.YearLbl.Text = "Enter class year:";
            this.YearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LetterTxt
            // 
            this.LetterTxt.Location = new System.Drawing.Point(184, 122);
            this.LetterTxt.Name = "LetterTxt";
            this.LetterTxt.Size = new System.Drawing.Size(37, 20);
            this.LetterTxt.TabIndex = 25;
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(184, 54);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(37, 20);
            this.YearTxt.TabIndex = 24;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 459);
            this.Controls.Add(this.LetterLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.LetterTxt);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ClassLbx);
            this.Controls.Add(this.EditClassBtn);
            this.Controls.Add(this.RemoveClassBtn);
            this.Controls.Add(this.AddClassBtn);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditClassBtn;
        private System.Windows.Forms.Button RemoveClassBtn;
        private System.Windows.Forms.Button AddClassBtn;
        private System.Windows.Forms.ListBox ClassLbx;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label LetterLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.TextBox LetterTxt;
        private System.Windows.Forms.TextBox YearTxt;
    }
}