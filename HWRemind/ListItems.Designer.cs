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
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
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
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(37, 62);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(713, 20);
            this.subjectTextBox.TabIndex = 1;
            // 
            // greenButton
            // 
            this.greenButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.greenButton.Location = new System.Drawing.Point(657, 365);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(92, 27);
            this.greenButton.TabIndex = 2;
            this.greenButton.Text = "Done";
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // redButton
            // 
            this.redButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.redButton.Location = new System.Drawing.Point(559, 365);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(92, 27);
            this.redButton.TabIndex = 3;
            this.redButton.Text = "Not Done";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // ListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 414);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectNameLabel);
            this.Name = "ListItems";
            this.Text = "ListItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
    }
}