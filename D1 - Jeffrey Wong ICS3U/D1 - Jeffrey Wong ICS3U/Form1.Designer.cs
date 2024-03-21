namespace D1___Jeffrey_Wong_ICS3U
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
            this.components = new System.ComponentModel.Container();
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.catTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catPictureBox
            // 
            this.catPictureBox.Location = new System.Drawing.Point(0, 0);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(229, 249);
            this.catPictureBox.TabIndex = 0;
            this.catPictureBox.TabStop = false;
            // 
            // catTimer
            // 
            this.catTimer.Tick += new System.EventHandler(this.catTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.catPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.Timer catTimer;
    }
}

