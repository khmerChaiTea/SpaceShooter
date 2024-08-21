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
            this.label = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
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
            // label
            // 
            this.label.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(62, 126);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(452, 95);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Visible = false;
            // 
            // Replay
            // 
            this.Replay.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay.ForeColor = System.Drawing.Color.Black;
            this.Replay.Location = new System.Drawing.Point(218, 321);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(138, 23);
            this.Replay.TabIndex = 2;
            this.Replay.Text = "REPLAY";
            this.Replay.UseVisualStyleBackColor = true;
            this.Replay.Visible = false;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(218, 360);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(138, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.Gold;
            this.scorelbl.Location = new System.Drawing.Point(12, 9);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(100, 23);
            this.scorelbl.TabIndex = 4;
            this.scorelbl.Text = "label1";
            this.scorelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.Gold;
            this.levellbl.Location = new System.Drawing.Point(491, 9);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(81, 18);
            this.levellbl.TabIndex = 5;
            this.levellbl.Text = "Level: 0";
            this.levellbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.label);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Replay;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.Label scorelbl;
    }
}

