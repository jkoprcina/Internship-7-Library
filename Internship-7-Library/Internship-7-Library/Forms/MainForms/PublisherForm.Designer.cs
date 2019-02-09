namespace Internship_7_Library
{
    partial class PublisherForm
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
            this.EditPublisherBtn = new System.Windows.Forms.Button();
            this.RemovePublisherBtn = new System.Windows.Forms.Button();
            this.AddNewPublisher = new System.Windows.Forms.Button();
            this.PublisherLbx = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditPublisherBtn
            // 
            this.EditPublisherBtn.Location = new System.Drawing.Point(298, 275);
            this.EditPublisherBtn.Name = "EditPublisherBtn";
            this.EditPublisherBtn.Size = new System.Drawing.Size(151, 66);
            this.EditPublisherBtn.TabIndex = 20;
            this.EditPublisherBtn.Text = "Edit Publisher";
            this.EditPublisherBtn.UseVisualStyleBackColor = true;
            this.EditPublisherBtn.Click += new System.EventHandler(this.EditPublisherBtn_Click);
            // 
            // RemovePublisherBtn
            // 
            this.RemovePublisherBtn.Location = new System.Drawing.Point(298, 203);
            this.RemovePublisherBtn.Name = "RemovePublisherBtn";
            this.RemovePublisherBtn.Size = new System.Drawing.Size(151, 66);
            this.RemovePublisherBtn.TabIndex = 19;
            this.RemovePublisherBtn.Text = "Remove Publisher";
            this.RemovePublisherBtn.UseVisualStyleBackColor = true;
            this.RemovePublisherBtn.Click += new System.EventHandler(this.RemovePublisherBtn_Click);
            // 
            // AddNewPublisher
            // 
            this.AddNewPublisher.Location = new System.Drawing.Point(298, 132);
            this.AddNewPublisher.Name = "AddNewPublisher";
            this.AddNewPublisher.Size = new System.Drawing.Size(151, 66);
            this.AddNewPublisher.TabIndex = 18;
            this.AddNewPublisher.Text = "Add New Publisher";
            this.AddNewPublisher.UseVisualStyleBackColor = true;
            this.AddNewPublisher.Click += new System.EventHandler(this.AddNewPublisher_Click);
            // 
            // PublisherLbx
            // 
            this.PublisherLbx.FormattingEnabled = true;
            this.PublisherLbx.Location = new System.Drawing.Point(12, 12);
            this.PublisherLbx.Name = "PublisherLbx";
            this.PublisherLbx.Size = new System.Drawing.Size(219, 420);
            this.PublisherLbx.TabIndex = 21;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(298, 347);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(151, 61);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(257, 63);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(48, 16);
            this.NameLbl.TabIndex = 24;
            this.NameLbl.Text = "Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(320, 62);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(172, 20);
            this.NameTxt.TabIndex = 23;
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 445);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PublisherLbx);
            this.Controls.Add(this.EditPublisherBtn);
            this.Controls.Add(this.RemovePublisherBtn);
            this.Controls.Add(this.AddNewPublisher);
            this.Name = "PublisherForm";
            this.Text = "PublisherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditPublisherBtn;
        private System.Windows.Forms.Button RemovePublisherBtn;
        private System.Windows.Forms.Button AddNewPublisher;
        private System.Windows.Forms.ListBox PublisherLbx;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
    }
}