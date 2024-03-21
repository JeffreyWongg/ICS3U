// Jeffrey Wong
// ICS3U
// January 10th 2024
// D11

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace D11___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        Rectangle player;
        Rectangle obstacle;
        Timer timer;
        Pen pen;
        Random randomNum = new Random();
        SoundPlayer move;
        int dx, dy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 800;

            player = new Rectangle(475, 700, 50, 50);
            obstacle = new Rectangle(randomNum.Next(this.Width), randomNum.Next(this.Height), 50, 50);

            pen = new Pen(Color.Blue);

            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            move = new SoundPlayer();
            move.SoundLocation = Application.StartupPath + @"\blop.wav";

            timer = new Timer();
            timer.Interval = 1000 / 60;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dy = 0;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                dx = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dy = 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                dy = -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                dx = 5;
            }
            if (e.KeyCode == Keys.Left)
            {
                dx = -5;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 0 && dx < 0)
            {
                move.Play();
                player.X += dx;
            }
            if (player.Right < (this.Width - 20) && dx > 0)
            {
                move.Play();
                player.X += dx;
            }
            if (player.Top > 0 && dy < 0)
            {
                move.Play();
                player.Y += dy;
            }
            if (player.Bottom < (this.Height) && dy > 0)
            {
                move.Play();
                player.Y += dy;
            }
            if (player.Top <= 0)
            {
                timer.Stop();
                MessageBox.Show("You Win!");
                Application.Exit();
            }
            if (player.IntersectsWith(obstacle))
            {
                timer.Stop();
                MessageBox.Show("You Lose!");
                Application.Exit();
            }

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            e.Graphics.DrawRectangle(pen, player);
            e.Graphics.DrawRectangle(pen, obstacle);
        }
    }
}
