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
            this.difficulty = new System.Windows.Forms.Label();
            this.dropdown = new System.Windows.Forms.PictureBox();
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
            this.ButtonImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadgame)).BeginInit();
            this.diffpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newgame
            // 
            this.newgame.AutoSize = true;
            this.newgame.Font = new System.Drawing.Font("Vineta BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.Location = new System.Drawing.Point(486, 12);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(121, 19);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "New game";
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Font = new System.Drawing.Font("Vineta BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulty.Location = new System.Drawing.Point(237, 12);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(194, 19);
            this.difficulty.TabIndex = 2;
            this.difficulty.Text = "Choose difficulty";
            // 
            // dropdown
            // 
            this.dropdown.BackColor = System.Drawing.SystemColors.Control;
            this.dropdown.Image = global::Minesweeper.Properties.Resources.drop_down__triangle2;
            this.dropdown.Location = new System.Drawing.Point(437, 12);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(33, 19);
            this.dropdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dropdown.TabIndex = 5;
            this.dropdown.TabStop = false;
            this.dropdown.Click += new System.EventHandler(this.dropdown_Click);
            // 
            // loadgame
            // 
            this.loadgame.Image = global::Minesweeper.Properties.Resources.gamebutton;
            this.loadgame.Location = new System.Drawing.Point(604, 5);
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
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameProgress
            // 
            this.gameProgress.Location = new System.Drawing.Point(51, 436);
            this.gameProgress.Name = "gameProgress";
            this.gameProgress.Size = new System.Drawing.Size(581, 23);
            this.gameProgress.TabIndex = 8;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(12, 12);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(49, 17);
            this.score.TabIndex = 9;
            this.score.Text = "Score:";
            // 
            // remainingFlags
            // 
            this.remainingFlags.AutoSize = true;
            this.remainingFlags.Location = new System.Drawing.Point(15, 32);
            this.remainingFlags.Name = "remainingFlags";
            this.remainingFlags.Size = new System.Drawing.Size(50, 17);
            this.remainingFlags.TabIndex = 10;
            this.remainingFlags.Text = "Flags: ";
            // 
            // ButtonImage
            // 
            this.ButtonImage.Location = new System.Drawing.Point(51, 77);
            this.ButtonImage.Name = "ButtonImage";
            this.ButtonImage.Size = new System.Drawing.Size(556, 247);
            this.ButtonImage.TabIndex = 11;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.ButtonImage);
            this.Controls.Add(this.remainingFlags);
            this.Controls.Add(this.score);
            this.Controls.Add(this.gameProgress);
            this.Controls.Add(this.diffpanel);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.loadgame);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.dropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadgame)).EndInit();
            this.diffpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadgame;
        private System.Windows.Forms.Label newgame;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.PictureBox dropdown;
        private System.Windows.Forms.Panel diffpanel;
        private System.Windows.Forms.Button hardbtn;
        private System.Windows.Forms.Button easybtn;
        private System.Windows.Forms.Button medbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar gameProgress;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label remainingFlags;
        private System.Windows.Forms.Panel ButtonImage;
    }
}

