namespace HWRemind
{
    partial class Form1
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
            this.englishButton = new System.Windows.Forms.Button();
            this.mathsButton = new System.Windows.Forms.Button();
            this.physButton = new System.Windows.Forms.Button();
            this.busButton = new System.Windows.Forms.Button();
            this.sddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // englishButton
            // 
            this.englishButton.BackColor = System.Drawing.Color.Red;
            this.englishButton.ForeColor = System.Drawing.Color.Black;
            this.englishButton.Location = new System.Drawing.Point(13, 14);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(329, 185);
            this.englishButton.TabIndex = 0;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = false;
            // 
            // mathsButton
            // 
            this.mathsButton.BackColor = System.Drawing.Color.Lime;
            this.mathsButton.Location = new System.Drawing.Point(13, 217);
            this.mathsButton.Name = "mathsButton";
            this.mathsButton.Size = new System.Drawing.Size(329, 185);
            this.mathsButton.TabIndex = 1;
            this.mathsButton.Text = "Maths";
            this.mathsButton.UseVisualStyleBackColor = false;
            // 
            // physButton
            // 
            this.physButton.BackColor = System.Drawing.Color.Lime;
            this.physButton.Location = new System.Drawing.Point(348, 14);
            this.physButton.Name = "physButton";
            this.physButton.Size = new System.Drawing.Size(329, 185);
            this.physButton.TabIndex = 2;
            this.physButton.Text = "Physics";
            this.physButton.UseVisualStyleBackColor = false;
            // 
            // busButton
            // 
            this.busButton.BackColor = System.Drawing.Color.Lime;
            this.busButton.Location = new System.Drawing.Point(348, 217);
            this.busButton.Name = "busButton";
            this.busButton.Size = new System.Drawing.Size(329, 185);
            this.busButton.TabIndex = 3;
            this.busButton.Text = "Business";
            this.busButton.UseVisualStyleBackColor = false;
            // 
            // sddButton
            // 
            this.sddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sddButton.Location = new System.Drawing.Point(683, 14);
            this.sddButton.Name = "sddButton";
            this.sddButton.Size = new System.Drawing.Size(181, 388);
            this.sddButton.TabIndex = 4;
            this.sddButton.Text = "SDD";
            this.sddButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 435);
            this.Controls.Add(this.sddButton);
            this.Controls.Add(this.busButton);
            this.Controls.Add(this.physButton);
            this.Controls.Add(this.mathsButton);
            this.Controls.Add(this.englishButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button mathsButton;
        private System.Windows.Forms.Button physButton;
        private System.Windows.Forms.Button busButton;
        private System.Windows.Forms.Button sddButton;
    }
}

