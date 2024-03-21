// Jeffrey Wong
// ICS3U
// December 12th 2023
// D2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        // Initializing variables
        Image flag;
        int counter1 = 0;
        int counter2 = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // Counter button is a button that will tell you how many times it has been clicked
        private void counterButton_Click(object sender, EventArgs e)
        {           
            counter1++; // Acts as a loop, will add one to itself every time the button is clicked

            // Displays the counter variable as the button's text, which reflects how many times the user has clicked the button
            counterButton.Text = (counter1.ToString());
        }

        // Picture button will alternate between text and an image every time it is clicked
        private void pictureButton_Click(object sender, EventArgs e)
        {
            counter2++; // Acts as a loop, will add one to itself every time it is clicked
            flag = Image.FromFile(Application.StartupPath + @"\flag.png", true); // Assigning an image of a canadian flag to the "flag" variable

            // temporary variable to determine if the counter is at an even or odd number
            int temp = counter2 % 2;

            if (temp == 0) // If the counter is a even number, it will replace the text box with an image
            {
                pictureButton.Text = null; // sets the button's text to nothing (null)
                pictureButton.Image = flag; // sets the button's image as the flag image
            }
            if (temp == 1) // If the counter is an odd number, it will replace the image with the text
            {
                pictureButton.Image = null; // sets the button's image to nothing (null)
                pictureButton.Text = "CLICK ME"; // sets the button's text to "CLICK ME"
            }
        }

        // Exit button will end the program, and displays a message box before stopping
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Hides all other buttons
            counterButton.Visible = false;
            pictureButton.Visible = false;
            exitButton.Visible = false;

            // Displays a message box that says "BYE BYE"
            MessageBox.Show("BYE BYE");
     
            // Will exit the application after the user presses "okay" on the message box
            Application.Exit();           
        } 
    }
}
