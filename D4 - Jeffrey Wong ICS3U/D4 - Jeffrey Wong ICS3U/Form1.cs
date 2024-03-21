// Jeffrey Wong
// ICS3U
// December 14th 2023
// D4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D4___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Will change the font of the textbox if the "bold" checkbox is checked/unchecked
        private void boldCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (boldCheckBox.Checked) // bold checkbox is checked
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Bold); // changes the font to bold
            }
            if (boldCheckBox.Checked && italicCheckBox.Checked) // both the bold and italic checkboxes are checked
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Bold | FontStyle.Italic); // changes the font to bold and italic
            }
            if (!boldCheckBox.Checked) // if the bold checkbox is not checked, we will remove the bold font
            {
                if (italicCheckBox.Checked) // if the bold checkbox is NOT checked, but the italic checkbox is
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Italic); // changes the font to only italic
                }
                else // this means that none of the checkboxes are checked
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular); // changes the font to regular
                }
            }
        }

        // Will change the font of the textbox if the "bold" checkbox is checked/unchecked
        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (italicCheckBox.Checked) // italic checkbox is checked
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Italic); // changes the font to italic
            }
            if (italicCheckBox.Checked && boldCheckBox.Checked) // both the bold and italic checkboxes are checked
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Bold | FontStyle.Italic); // changes the font to bold and italic
            }
            if (!italicCheckBox.Checked) // if the italic checkbox is not checked, we will remove the italic font
            {
                if (boldCheckBox.Checked) // if the italic checkbox is NOT checked, but the bold checkbox is
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold); // changes the font to only bold
                }
                else // this means that none of the checkboxes are checked
                {
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular); // changes the font to regular
                }
            }
        }
    }
}
