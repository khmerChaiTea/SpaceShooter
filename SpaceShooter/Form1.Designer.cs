namespace SpaceShooter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBgTimer = new System.Timers.Timer();
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Timers.Timer();
            this.RightMoverTimer = new System.Timers.Timer();
            this.UpMoveTimer = new System.Timers.Timer();
            this.DownMoveTimer = new System.Timers.Timer();
            this.MoveMunitionTimer = new System.Timers.Timer();
            this.MoveEnemiesTimer = new System.Timers.Timer();
            this.EnemiesMunitionTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBgTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMoveTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMoverTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpMoveTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownMoveTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveMunitionTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveEnemiesTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemiesMunitionTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10D;
            this.MoveBgTimer.SynchronizingObject = this;
            this.MoveBgTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.MoveBgTimer_Elapsed);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Enabled = true;
            this.LeftMoveTimer.Interval = 5D;
            this.LeftMoveTimer.SynchronizingObject = this;
            this.LeftMoveTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.LeftMoveTimer_Elapsed);
            // 
            // RightMoverTimer
            // 
            this.RightMoverTimer.Enabled = true;
            this.RightMoverTimer.Interval = 5D;
            this.RightMoverTimer.SynchronizingObject = this;
            this.RightMoverTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.RightMoverTimer_Elapsed);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Enabled = true;
            this.UpMoveTimer.Interval = 5D;
            this.UpMoveTimer.SynchronizingObject = this;
            this.UpMoveTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.UpMoveTimer_Elapsed);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Enabled = true;
            this.DownMoveTimer.Interval = 5D;
            this.DownMoveTimer.SynchronizingObject = this;
            this.DownMoveTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.DownMoveTimer_Elapsed);
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20D;
            this.MoveMunitionTimer.SynchronizingObject = this;
            this.MoveMunitionTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.MoveMunitionTimer_Elapsed);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.SynchronizingObject = this;
            this.MoveEnemiesTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.MoveEnemiesTimer_Elapsed);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20D;
            this.EnemiesMunitionTimer.SynchronizingObject = this;
            this.EnemiesMunitionTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.EnemiesMunitionTimer_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MoveBgTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMoveTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMoverTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpMoveTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownMoveTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveMunitionTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveEnemiesTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemiesMunitionTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Timers.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Timers.Timer LeftMoveTimer;
        private System.Timers.Timer RightMoverTimer;
        private System.Timers.Timer UpMoveTimer;
        private System.Timers.Timer DownMoveTimer;
        private System.Timers.Timer MoveMunitionTimer;
        private System.Timers.Timer MoveEnemiesTimer;
        private System.Timers.Timer EnemiesMunitionTimer;
    }
}

