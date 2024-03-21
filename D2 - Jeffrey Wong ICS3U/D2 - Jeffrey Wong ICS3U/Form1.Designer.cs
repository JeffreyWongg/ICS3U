namespace D2___Jeffrey_Wong_ICS3U
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
            this.counterButton = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterButton
            // 
            this.counterButton.Location = new System.Drawing.Point(12, 12);
            this.counterButton.Name = "counterButton";
            this.counterButton.Size = new System.Drawing.Size(260, 53);
            this.counterButton.TabIndex = 0;
            this.counterButton.Text = "0";
            this.counterButton.UseVisualStyleBackColor = true;
            this.counterButton.Click += new System.EventHandler(this.counterButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Location = new System.Drawing.Point(12, 106);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(260, 53);
            this.pictureButton.TabIndex = 1;
            this.pictureButton.Text = "CLICK ME";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 196);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 53);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "DONT CLICK ME";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.counterButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D2 - Jeffrey Wong ICS3U";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button counterButton;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button exitButton;
    }
}

