namespace Minesweeper
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.newgame = new System.Windows.Forms.Label();
            this.loadgame = new System.Windows.Forms.PictureBox();
            this.diffpanel = new System.Windows.Forms.Panel();
            this.hardbtn = new System.Windows.Forms.Button();
            this.easybtn = new System.Windows.Forms.Button();
            this.medbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gameProgress = new System.Windows.Forms.ProgressBar();
            this.score = new System.Windows.Forms.Label();
            this.remainingFlags = new System.Windows.Forms.Label();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.Label();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadgame)).BeginInit();
            this.diffpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newgame
            // 
            this.newgame.AutoSize = true;
            this.newgame.Font = new System.Drawing.Font("Vineta BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.Location = new System.Drawing.Point(471, 9);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(121, 19);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "New game";
            // 
            // loadgame
            // 
            this.loadgame.BackColor = System.Drawing.Color.Transparent;
            this.loadgame.Image = global::Minesweeper.Properties.Resources.gamebutton;
            this.loadgame.Location = new System.Drawing.Point(598, 9);
            this.loadgame.Name = "loadgame";
            this.loadgame.Size = new System.Drawing.Size(41, 41);
            this.loadgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadgame.TabIndex = 0;
            this.loadgame.TabStop = false;
            this.loadgame.Click += new System.EventHandler(this.loadgame_Click);
            // 
            // diffpanel
            // 
            this.diffpanel.Controls.Add(this.hardbtn);
            this.diffpanel.Controls.Add(this.easybtn);
            this.diffpanel.Controls.Add(this.medbtn);
            this.diffpanel.Location = new System.Drawing.Point(212, 27);
            this.diffpanel.Name = "diffpanel";
            this.diffpanel.Size = new System.Drawing.Size(200, 0);
            this.diffpanel.TabIndex = 7;
            // 
            // hardbtn
            // 
            this.hardbtn.Location = new System.Drawing.Point(0, 50);
            this.hardbtn.Name = "hardbtn";
            this.hardbtn.Size = new System.Drawing.Size(200, 27);
            this.hardbtn.TabIndex = 10;
            this.hardbtn.Text = "Hard";
            this.hardbtn.UseVisualStyleBackColor = true;
            // 
            // easybtn
            // 
            this.easybtn.Location = new System.Drawing.Point(0, 0);
            this.easybtn.Name = "easybtn";
            this.easybtn.Size = new System.Drawing.Size(200, 27);
            this.easybtn.TabIndex = 8;
            this.easybtn.Text = "Easy";
            this.easybtn.UseVisualStyleBackColor = true;
            // 
            // medbtn
            // 
            this.medbtn.Location = new System.Drawing.Point(0, 25);
            this.medbtn.Name = "medbtn";
            this.medbtn.Size = new System.Drawing.Size(200, 27);
            this.medbtn.TabIndex = 9;
            this.medbtn.Text = "Medium";
            this.medbtn.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gameProgress
            // 
            this.gameProgress.Location = new System.Drawing.Point(84, 395);
            this.gameProgress.MarqueeAnimationSpeed = 0;
            this.gameProgress.Name = "gameProgress";
            this.gameProgress.Size = new System.Drawing.Size(581, 23);
            this.gameProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.gameProgress.TabIndex = 8;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Vineta BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 12);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(76, 19);
            this.score.TabIndex = 9;
            this.score.Text = "Score:";
            // 
            // remainingFlags
            // 
            this.remainingFlags.AutoSize = true;
            this.remainingFlags.Font = new System.Drawing.Font("Vineta BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingFlags.Location = new System.Drawing.Point(12, 33);
            this.remainingFlags.Name = "remainingFlags";
            this.remainingFlags.Size = new System.Drawing.Size(84, 19);
            this.remainingFlags.TabIndex = 10;
            this.remainingFlags.Text = "Flags: ";
            // 
            // difficulty
            // 
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "Easy ",
            "Medium",
            "Hard"});
            this.difficulty.Location = new System.Drawing.Point(297, 9);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(150, 24);
            this.difficulty.TabIndex = 0;
            this.difficulty.Text = "Choose difficulty";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(209, 7);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(43, 17);
            this.time.TabIndex = 12;
            this.time.Text = "Time:";
            // 
            // minutesBox
            // 
            this.minutesBox.Location = new System.Drawing.Point(200, 27);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(24, 22);
            this.minutesBox.TabIndex = 13;
            // 
            // secondsBox
            // 
            this.secondsBox.Location = new System.Drawing.Point(230, 28);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(24, 22);
            this.secondsBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 240);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(718, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.time);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.remainingFlags);
            this.Controls.Add(this.score);
            this.Controls.Add(this.gameProgress);
            this.Controls.Add(this.diffpanel);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.loadgame);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.loadgame)).EndInit();
            this.diffpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadgame;
        private System.Windows.Forms.Label newgame;
        private System.Windows.Forms.Panel diffpanel;
        private System.Windows.Forms.Button hardbtn;
        private System.Windows.Forms.Button easybtn;
        private System.Windows.Forms.Button medbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar gameProgress;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label remainingFlags;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.TextBox secondsBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

