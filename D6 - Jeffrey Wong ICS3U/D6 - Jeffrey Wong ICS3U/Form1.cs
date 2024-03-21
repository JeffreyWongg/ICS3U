// Jeffrey Wong
// ICS3U
// December 18th 2023
// D6

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D6___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        Image[] picture;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picture = new Image[4];

            picture[0] = Image.FromFile(Application.StartupPath + @"\basketball.jpg", true);
            picture[1] = Image.FromFile(Application.StartupPath + @"\cat.jpg", true);
            picture[2] = Image.FromFile(Application.StartupPath + @"\dog.jpg", true);
            picture[3] = Image.FromFile(Application.StartupPath + @"\fish.jpg", true);

            comboBox.Items.Add("Basketball");
            comboBox.Items.Add("Cat");
            comboBox.Items.Add("Dog");
            comboBox.Items.Add("Fish");
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.Text == "Basketball")
            {
                pictureBox.BackgroundImage = picture[0];
            }
            if (comboBox.Text == "Cat")
            {
                pictureBox.BackgroundImage = picture[1];
            }
            if (comboBox.Text == "Dog")
            {
                pictureBox.BackgroundImage = picture[2];
            }
            if (comboBox.Text == "Fish")
            {
                pictureBox.BackgroundImage = picture[3];
            }
        }
    }
}
