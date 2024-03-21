// Jeffrey Wong
// ICS3U
// December 22nd 2023
// D8

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D8___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        Image cat;
        Timer timer;
        Rectangle box;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 800;

            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;

            cat = Image.FromFile(Application.StartupPath + @"\cat.jpg", true);
            box = new Rectangle(0, 0, 50, 50);

            timer = new Timer();
            timer.Interval = (10);
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            box.X += 2;
            box.Y += 3;

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(cat, box);
        }
    }
}
