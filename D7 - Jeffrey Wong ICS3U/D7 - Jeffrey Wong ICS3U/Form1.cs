// Jeffrey Wong
// ICS3U
// December 20th 2023
// D7

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        // Initializing the "textbox" which is the type textbox
        TextBox textBox;

        public Form1()
        {
            InitializeComponent();
        }

        // Loading the things before the program begins
        private void Form1_Load(object sender, EventArgs e)
        {
            // setting the size of the form
            this.Height = 600;
            this.Width = 800;

            // making an array for textbox of size 27
            TextBox[] textBox;
            textBox = new TextBox[27];

            // Declaring the random number generator, type "random"
            Random randomNumberGenerator = new Random();

            // for loop to repeat 26 times
            for (int i = 1; i <= 26; i++)
            {
                textBox[i] = new TextBox(); // making a new textbox and assigning it to the i'th textbox
                textBox[i].Text = i.ToString(); // converting the number to a string so it can be displayed as text
                textBox[i].Visible = true; // making sure the textbox is visible
                textBox[i].Top = randomNumberGenerator.Next(600); // generating a number for the y coordinate from 0 to 600
                textBox[i].Left = randomNumberGenerator.Next(800); // generating a number for the x coordinate from 0 to 800
                this.Controls.Add(textBox[i]); // adds the textbox onto the screen
            }
        }
    }
}
