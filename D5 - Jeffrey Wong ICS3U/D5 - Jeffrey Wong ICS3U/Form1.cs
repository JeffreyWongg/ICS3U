// Jeffrey Wong
// ICS3U
// December 14th 2023
// D5

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D5___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plainRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
        }

        private void boldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
        }

        private void italicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Italic);
        }

        private void boldItalicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Italic|FontStyle.Bold);
        }
    }
}
