namespace Internship_7_Library.Forms.RemoveForms
{
    partial class RemovePublisherForm
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
            this.PublisherLbx = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublisherLbx
            // 
            this.PublisherLbx.FormattingEnabled = true;
            this.PublisherLbx.Location = new System.Drawing.Point(12, 12);
            this.PublisherLbx.Name = "PublisherLbx";
            this.PublisherLbx.Size = new System.Drawing.Size(305, 342);
            this.PublisherLbx.TabIndex = 13;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(191, 370);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 59);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(18, 370);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(111, 59);
            this.RemoveBtn.TabIndex = 11;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // RemovePublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.PublisherLbx);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Name = "RemovePublisherForm";
            this.Text = "RemovePublisherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PublisherLbx;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button RemoveBtn;
    }
}