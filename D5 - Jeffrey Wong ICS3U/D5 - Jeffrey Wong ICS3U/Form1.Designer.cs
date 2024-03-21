namespace D5___Jeffrey_Wong_ICS3U
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plainRadioButton = new System.Windows.Forms.RadioButton();
            this.boldRadioButton = new System.Windows.Forms.RadioButton();
            this.italicRadioButton = new System.Windows.Forms.RadioButton();
            this.boldItalicRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 25);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(260, 152);
            this.textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Here:";
            // 
            // plainRadioButton
            // 
            this.plainRadioButton.AutoSize = true;
            this.plainRadioButton.Location = new System.Drawing.Point(12, 200);
            this.plainRadioButton.Name = "plainRadioButton";
            this.plainRadioButton.Size = new System.Drawing.Size(72, 17);
            this.plainRadioButton.TabIndex = 2;
            this.plainRadioButton.TabStop = true;
            this.plainRadioButton.Text = "Plain Text";
            this.plainRadioButton.UseVisualStyleBackColor = true;
            this.plainRadioButton.CheckedChanged += new System.EventHandler(this.plainRadioButton_CheckedChanged);
            // 
            // boldRadioButton
            // 
            this.boldRadioButton.AutoSize = true;
            this.boldRadioButton.Location = new System.Drawing.Point(12, 232);
            this.boldRadioButton.Name = "boldRadioButton";
            this.boldRadioButton.Size = new System.Drawing.Size(70, 17);
            this.boldRadioButton.TabIndex = 3;
            this.boldRadioButton.TabStop = true;
            this.boldRadioButton.Text = "Bold Text";
            this.boldRadioButton.UseVisualStyleBackColor = true;
            this.boldRadioButton.CheckedChanged += new System.EventHandler(this.boldRadioButton_CheckedChanged);
            // 
            // italicRadioButton
            // 
            this.italicRadioButton.AutoSize = true;
            this.italicRadioButton.Location = new System.Drawing.Point(168, 200);
            this.italicRadioButton.Name = "italicRadioButton";
            this.italicRadioButton.Size = new System.Drawing.Size(71, 17);
            this.italicRadioButton.TabIndex = 4;
            this.italicRadioButton.TabStop = true;
            this.italicRadioButton.Text = "Italic Text";
            this.italicRadioButton.UseVisualStyleBackColor = true;
            this.italicRadioButton.CheckedChanged += new System.EventHandler(this.italicRadioButton_CheckedChanged);
            // 
            // boldItalicRadioButton
            // 
            this.boldItalicRadioButton.AutoSize = true;
            this.boldItalicRadioButton.Location = new System.Drawing.Point(168, 232);
            this.boldItalicRadioButton.Name = "boldItalicRadioButton";
            this.boldItalicRadioButton.Size = new System.Drawing.Size(104, 17);
            this.boldItalicRadioButton.TabIndex = 5;
            this.boldItalicRadioButton.TabStop = true;
            this.boldItalicRadioButton.Text = "Bold && Italic Text";
            this.boldItalicRadioButton.UseVisualStyleBackColor = true;
            this.boldItalicRadioButton.CheckedChanged += new System.EventHandler(this.boldItalicRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.boldItalicRadioButton);
            this.Controls.Add(this.italicRadioButton);
            this.Controls.Add(this.boldRadioButton);
            this.Controls.Add(this.plainRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton plainRadioButton;
        private System.Windows.Forms.RadioButton boldRadioButton;
        private System.Windows.Forms.RadioButton italicRadioButton;
        private System.Windows.Forms.RadioButton boldItalicRadioButton;
    }
}

