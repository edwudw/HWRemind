namespace HWRemind
{
    partial class ListItems
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
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLabel.Location = new System.Drawing.Point(23, 13);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(152, 29);
            this.subjectNameLabel.TabIndex = 0;
            this.subjectNameLabel.Text = "Subject Name";
            // 
            // ListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 236);
            this.Controls.Add(this.subjectNameLabel);
            this.Name = "ListItems";
            this.Text = "ListItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectNameLabel;
    }
}