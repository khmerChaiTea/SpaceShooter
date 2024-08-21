using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        // Array to hold PictureBox objects representing stars
        PictureBox[] stars;
        // Speed at which the background (stars) will move
        int backgroundspeed;
        // Random number generator for positioning stars randomly
        Random rnd;

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent(); // Initializes the form and its components
        }

        // Event handler for the Form's Load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the background speed
            backgroundspeed = 4;
            // Create an array to hold 10 PictureBox objects
            stars = new PictureBox[10];
            // Initialize the random number generator
            rnd = new Random();

            // Loop to create and initialize each star (PictureBox)
            for (int i = 0; i < stars.Length; i++)
            {
                // Create a new PictureBox object for each star
                stars[i] = new PictureBox();
                // Set the border style of the PictureBox to None
                stars[i].BorderStyle = BorderStyle.None;
                // Randomly position the star within the form
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));

                // Alternate between two different sizes and colors for the stars
                if (i % 2 == 1)
                {
                    // Smaller, lighter-colored star
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    // Larger, darker-colored star
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                // Add the PictureBox (star) to the form's controls
                this.Controls.Add(stars[i]);
            }
        }

        // Event handler for the Timer's Elapsed event to move the background (stars)
        private void MoveBgTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Loop to move the first half of the stars down the form
            for (int i = 0; i < stars.Length / 2; i++)
            {
                // Move the star down by the background speed
                stars[i].Top += backgroundspeed;

                // If the star moves past the bottom of the form, reset it to the top
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            // Loop to move the second half of the stars down the form
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                // Move the star down by slightly less than the background speed
                stars[i].Top += backgroundspeed - 2;

                // If the star moves past the bottom of the form, reset it to the top
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top -= -stars[i].Height;
                }
            }
        }
    }
}
