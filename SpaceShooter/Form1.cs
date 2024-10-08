﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        // Array to hold PictureBox objects representing stars
        PictureBox[] stars;
        // Speed at which the player will move
        int playerSpeed;
        // Speed at which the background (stars) will move
        int backgroundSpeed;
        // Random number generator for positioning stars randomly

        PictureBox[] munitions;
        int munitionSpeed;

        PictureBox[] enemies;
        int enemySpeed;

        PictureBox[] enemyMunitions;
        int enemyMunitionsSpeed;

        Random rnd;

        int score;
        int level;
        int difficulty;
        bool pause;
        bool gameIsOver;

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent(); // Initializes the form and its components
        }

        // Event handler for the Form's Load event
        private void Form1_Load(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            // Initialize the player speed
            playerSpeed = 4;
            // Initialize the background speed
            backgroundSpeed = 4;
            // Initialize the enemy speed
            enemySpeed = 4;
            // Initialize the munition speed
            munitionSpeed = 20;
            enemyMunitionsSpeed = 4;

            munitions = new PictureBox[3];

            // Load images
            Image munition = Image.FromFile(@"asserts\munition.png");

            Image enemy1 = Image.FromFile("asserts\\E1.png");
            Image enemy2 = Image.FromFile("asserts\\E2.png");
            Image enemy3 = Image.FromFile("asserts\\E3.png");
            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");

            enemies = new PictureBox[10];

            // Initialize Enemy Picture Boxes
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy3;
            enemies[3].Image = enemy3;
            enemies[4].Image = enemy1;
            enemies[5].Image = enemy3;
            enemies[6].Image = enemy2;
            enemies[7].Image = enemy3;
            enemies[8].Image = enemy2;
            enemies[9].Image = boss2;

            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            // Create MP
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            // Load all songs
            gameMedia.URL = "songs\\GameSong.mp3";
            shootgMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";

            // Setup Songs setting
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;

            // Create an array to hold 10 PictureBox objects
            stars = new PictureBox[15];
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

            // Enemy Munition
            enemyMunitions = new PictureBox[10];

            for (int i = 0; i < enemyMunitions.Length; i++)
            {
                enemyMunitions[i] = new PictureBox();
                enemyMunitions[i].Size = new Size(2, 25);
                enemyMunitions[i].Visible = false;
                enemyMunitions[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemyMunitions[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add((enemyMunitions[i]));
            }

            this.Controls.Add(scorelbl);
            this.Controls.Add(levellbl);

            gameMedia.controls.play();
        }

        // Event handler for the Timer's Elapsed event to move the background (stars)
        private void MoveBgTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Loop to move the first half of the stars down the form
            for (int i = 0; i < stars.Length / 2; i++)
            {
                // Move the star down by the background speed
                stars[i].Top += backgroundSpeed;

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
                stars[i].Top += backgroundSpeed - 2;

                // If the star moves past the bottom of the form, reset it to the top
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top -= -stars[i].Height;
                }
            }
        }

        // This method is called when the LeftMoveTimer elapses.
        // It moves the player to the left as long as the player's left edge is greater than 10 pixels from the left edge of the form.
        private void LeftMoveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Check if the player's left side is greater than 10 pixels from the left edge of the form.
            if (Player.Left > 10)
            {
                // Move the player to the left by decreasing its left position by playerSpeed.
                Player.Left -= playerSpeed;
            }
        }

        // This method is called when the RightMoverTimer elapses.
        // It moves the player to the right as long as the player's right edge is less than 580 pixels from the left edge of the form.
        private void RightMoverTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Check if the player's right side is less than 580 pixels from the left edge of the form.
            if (Player.Right < 580)
            {
                // Move the player to the right by increasing its left position by playerSpeed.
                Player.Left += playerSpeed;
            }
        }

        // This method is called when the UpMoveTimer elapses.
        // It moves the player up as long as the player's top edge is greater than 10 pixels from the top edge of the form.
        private void UpMoveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Check if the player's top side is greater than 10 pixels from the top edge of the form.
            if (Player.Top > 10)
            {
                // Move the player up by decreasing its top position by playerSpeed.
                Player.Top -= playerSpeed;
            }
        }

        // This method is called when the DownMoveTimer elapses.
        // It moves the player down as long as the player's top edge is less than 400 pixels from the top edge of the form.
        private void DownMoveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Check if the player's top side is less than 400 pixels from the top edge of the form.
            if (Player.Top < 400)
            {
                // Move the player down by increasing its top position by playerSpeed.
                Player.Top += playerSpeed;
            }
        }


        // This method is triggered when a key is pressed down while the form has focus.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                // Check if the right arrow key is pressed.
                if (e.KeyCode == Keys.Right)
                {
                    // Start the timer that handles moving the player to the right.
                    RightMoverTimer.Start();
                }

                // Check if the left arrow key is pressed.
                if (e.KeyCode == Keys.Left)
                {
                    // Start the timer that handles moving the player to the left.
                    LeftMoveTimer.Start();
                }

                // Check if the up arrow key is pressed.
                if (e.KeyCode == Keys.Up)
                {
                    // Start the timer that handles moving the player up.
                    UpMoveTimer.Start();
                }

                // Check if the down arrow key is pressed.
                if (e.KeyCode == Keys.Down)
                {
                    // Start the timer that handles moving the player down.
                    DownMoveTimer.Start();
                }
            }
        }

        // This method is triggered when a key is released while the form has focus.
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Stop the timer that moves the player to the right when the key is released.
            RightMoverTimer.Stop();
            // Stop the timer that moves the player to the left when the key is released.
            LeftMoveTimer.Stop();
            // Stop the timer that moves the player up when the key is released.
            UpMoveTimer.Stop();
            // Stop the timer that moves the player down when the key is released.
            DownMoveTimer.Stop();

            // Check if the space bar is pressed for pausing/unpausing.
            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        label.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        // Center the "PAUSED" label on the form.
                        label.Text = "PAUSED";
                        label.Location = new Point((this.Width - label.Width) / 2, (this.Height - label.Height) / 2);
                        label.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void MoveMunitionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            shootgMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionSpeed;

                    Collision();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemiesTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MoveEnemies(enemies, enemySpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();

                    score += 1;
                    // Ensure "Score:" is always included in the label text
                    scorelbl.Text = "Score: " + score.ToString("D2");

                    if (score % 30 == 0)
                    {
                        level += 1;
                        levellbl.Text = "Level: " + level.ToString("D2");

                        if (enemySpeed <= 10 && enemyMunitionsSpeed <= 10 && difficulty > 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            enemyMunitionsSpeed++;
                        }

                        if (level == 10)
                        {
                            GameOver("NICELY DONE");
                        }
                    }

                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void GameOver(string str)
        {
            // Set the text of the label to the game over message.
            label.Text = str;
            // Center the label on the form.
            label.Location = new Point((this.Width - label.Width) / 2, (this.Height - label.Height) / 2);
            label.Visible = true;

            // Make the Replay and Exit buttons visible.
            Replay.Visible = true;
            Exit.Visible = true;

            // Stop the game media and timers.
            gameMedia.controls.stop();
            StopTimers();
        }

        // Stop timer
        private void StopTimers()
        {
            MoveBgTimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMunitionTimer.Stop();
            EnemiesMunitionTimer.Stop();
        }

        // Start timer
        private void StartTimers()
        {
            MoveBgTimer.Start();
            MoveEnemiesTimer.Start();
            MoveMunitionTimer.Start();
            EnemiesMunitionTimer.Start();
        }

        private void EnemiesMunitionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < (enemyMunitions.Length - difficulty); i++)
            {
                if (enemyMunitions[i].Top < this.Height)
                {
                    enemyMunitions[i].Visible = true;
                    enemyMunitions[i].Top += enemyMunitionsSpeed;
                }
                else
                {
                    enemyMunitions[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemyMunitions[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }

            // Check for collisions after moving the munitions
            CollisionWithEnemyMunition();
        }

        private void CollisionWithEnemyMunition()
        {
            for (int i = 0; i < enemyMunitions.Length; i++)
            {
                if (enemyMunitions[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemyMunitions[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}