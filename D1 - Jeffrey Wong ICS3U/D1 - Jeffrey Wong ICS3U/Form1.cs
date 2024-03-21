// Jeffrey Wong
// ICS3U 
// December 11th 2023
// D1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        private Image[] cat; // Array of images for cats
        int i = 4; // counter variable

        public Form1()
        {
            InitializeComponent();
        }

        // Loads these things first
        private void Form1_Load(object sender, EventArgs e)
        {
            // Width = 800 and Height = 600 (size of form)
            this.Width = 800;
            this.Height = 600;

            // Cat timer is every 1000 ms
            catTimer.Interval = 3000;

            // Array of cat images size 5
            cat = new Image[5];

            // Defining 5 cat images
            cat[0] = Image.FromFile(Application.StartupPath + @"\cat1.jpg",true);
            cat[1] = Image.FromFile(Application.StartupPath + @"\cat2.jpg", true);
            cat[2] = Image.FromFile(Application.StartupPath + @"\cat3.jpg", true);
            cat[3] = Image.FromFile(Application.StartupPath + @"\cat4.jpg", true);
            cat[4] = Image.FromFile(Application.StartupPath + @"\cat5.jpg", true);

            // Starting the timer to effectively begin the slideshow
            catTimer.Start();
        }

        // Cat timer which is used to change the display of the cat
        private void catTimer_Tick(object sender, EventArgs e)
        {
            i++; // Every tick, i adds one to itself
            if (i == 5) // Once i reaches an out of index range of the array, it will reset it to 0
            {
                i = 0;
            }
            // Sets the picture box to the i'th image
            catPictureBox.BackgroundImage = cat[i];

            // Sets the size of the picture box to whatever the image's size is
            catPictureBox.Width = cat[i].Width;
            catPictureBox.Height = cat[i].Height;

            // Sets the size of the window to whatever the image's size is
            this.Width = cat[i].Width;
            this.Height = cat[i].Height;

            // The cat images will appear at the top left corner of the window
            catPictureBox.Top = 0;
            catPictureBox.Left = 0;
        }
    }
}
