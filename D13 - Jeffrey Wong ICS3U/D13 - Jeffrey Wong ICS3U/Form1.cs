// Jeffrey Wong
// ICS3U
// January 10th 2024
// D13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D13___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        // Initializing all of the variables used in the program
        Rectangle player, obstacle;
        Image steve;
        int yLimit, upper, gravity;
        bool jumping;
        int obstacledx = 5;
        int playerdx;
        Timer jumpTimer, movementTimer;

        public Form1()
        {
            InitializeComponent();
        }

        // Things to load upon starting
        private void Form1_Load(object sender, EventArgs e)
        {
            yLimit = this.Height - 40; // the maximum height is 40 pixels higher than the bottom of the window

            jumping = false; // starting off by not jumping

            // Making the starting position of the player and obstacle
            player = new Rectangle(20, yLimit - 20, 20, 20);
            obstacle = new Rectangle(this.Width - 50, yLimit - 20, 50, 20);

            steve = Image.FromFile(Application.StartupPath + @"\steve.jfif", true); // importing an image of minecraft steve to apply on top of the player rectangle

            // Setting up the paint method to display the updated movements
            this.DoubleBuffered = true; 
            this.Paint += Form1_Paint;

            // Setting up the event methods for key down and key up
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // Setting up a timer in 60 fps to allow the player to jump
            jumpTimer = new Timer();
            jumpTimer.Interval = 1000 / 60;
            jumpTimer.Tick += JumpTimer_Tick;
            jumpTimer.Start();

            // Setting up a timer in 60 fps to account for the movement of the obstacle and player
            movementTimer = new Timer();
            movementTimer.Interval = 1000 / 60;
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();
        }

        // This timer will constantly refresh the positions of the obstacle and player, creating an animation
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(); // wipes the region, and then updates
            
            // If the obstacle's left side is equal to 0, we will reverse the direction the box moves
            if (obstacle.Left == 0)
            {
                obstacledx = obstacledx * -1; // changes the direction of movement
            }
            // If the obstacle's right side is equal to the border (length of the window), we will reverse the direction the box moves
            if (obstacle.Right == this.Width)
            {
                obstacledx = obstacledx * -1; // changes the direction of movement
            }

            // If the player's left side is greater than 0 and the dx is negative
            if (player.Left > 0 && playerdx < 0)
            {
                player.X += playerdx; // update the x coordinate of the player with the factor
            }
            // If the player's right side is less than the right most area and the dx is positive
            if (player.Right < (this.Width - 20) && playerdx > 0)
            {
                player.X += playerdx; // update the x coordinate of the player with the factor
            }
            
            // If the the player intersects with the obstacle, stop the program and display "game over"
            if (player.IntersectsWith(obstacle))
            {
                movementTimer.Stop();
                MessageBox.Show("Game Over");
                Application.Exit();
            }

            obstacle.X += obstacledx; // update the x coordinate of the obstacle
        }

        // This timer will check if the player is jumping and goes up to the yLimit
        private void JumpTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();

            if(jumping) // jumping == true
            {
                if (player.Bottom <= yLimit) // Keeps going up as long as the bottom of the player is less than the yLimit
                {
                    jumping = true; // continue with jump
                    player.Y -= upper; // move player up by the upper value
                    player.Y += gravity; // move player down by the gravity value
                    if (upper > 0) // reduce the upper slowly
                    {
                        upper--;
                    }
                    if (player.Bottom >= yLimit) // if you hit the yLimit
                    {
                        jumping = false; // stop jumping
                        player.Y = yLimit - player.Height; // set the bottom of the player to the yLimit
                        upper = 0; // set the upper back to 0
                        gravity = 0; // set the gravity back to 0
                    }
                }
            }
        }

        // Function to react to when a key is pressed
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the spacebar or upwards arrow is pressed, change the jumping to true
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                if (!jumping)
                {
                    jumping = true;
                    upper = 14;
                    gravity = 3;
                }
            }
            // If the leftwards arrow is pressed, make the player move 5 pixels left
            if (e.KeyCode == Keys.Left)
            {
                playerdx = -5;
            }
            // If the rightwards arrow is pressed, make the player move 5 pixels right
            if (e.KeyCode == Keys.Right)
            {
                playerdx = 5;
            }
        }

        // If the keys are let go/not pressed
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) // if the left or right arrows are let go, change the movement to 0
            {
                playerdx = 0;
            }
        }

        // This function will paint the characters every tick
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(steve, player); // paint the player
            e.Graphics.DrawRectangle(Pens.Red, obstacle); // painting the obstacle
        }
    }
}