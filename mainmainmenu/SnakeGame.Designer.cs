namespace mainmainmenu
{
    partial class SnakeGame
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
            this.labelGameOverSub = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.SnakeHelpButton = new System.Windows.Forms.PictureBox();
            this.GameSound = new System.Windows.Forms.PictureBox();
            this.GameWindow = new System.Windows.Forms.PictureBox();
            this.SnakeStartInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGameOverSub
            // 
            this.labelGameOverSub.AutoSize = true;
            this.labelGameOverSub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameOverSub.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOverSub.Location = new System.Drawing.Point(330, 393);
            this.labelGameOverSub.Name = "labelGameOverSub";
            this.labelGameOverSub.Size = new System.Drawing.Size(316, 35);
            this.labelGameOverSub.TabIndex = 19;
            this.labelGameOverSub.Text = "Press \"Enter\" to play again";
            this.labelGameOverSub.Visible = false;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameOver.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Crimson;
            this.labelGameOver.Location = new System.Drawing.Point(294, 277);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(391, 98);
            this.labelGameOver.TabIndex = 18;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.Visible = false;
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHighScore.Location = new System.Drawing.Point(611, 91);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(23, 25);
            this.labelHighScore.TabIndex = 17;
            this.labelHighScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(498, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "High Score :";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(423, 91);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(23, 25);
            this.ScoreLabel.TabIndex = 14;
            this.ScoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(350, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Score :";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(417, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(158, 63);
            this.Title.TabIndex = 12;
            this.Title.Text = "SNAKE";
            // 
            // SnakeHelpButton
            // 
            this.SnakeHelpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SnakeHelpButton.Image = global::mainmainmenu.Properties.Resources.qmark;
            this.SnakeHelpButton.Location = new System.Drawing.Point(911, 21);
            this.SnakeHelpButton.Name = "SnakeHelpButton";
            this.SnakeHelpButton.Size = new System.Drawing.Size(45, 41);
            this.SnakeHelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnakeHelpButton.TabIndex = 21;
            this.SnakeHelpButton.TabStop = false;
            this.SnakeHelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // GameSound
            // 
            this.GameSound.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameSound.Image = global::mainmainmenu.Properties.Resources.on;
            this.GameSound.Location = new System.Drawing.Point(911, 75);
            this.GameSound.Name = "GameSound";
            this.GameSound.Size = new System.Drawing.Size(45, 41);
            this.GameSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameSound.TabIndex = 20;
            this.GameSound.TabStop = false;
            this.GameSound.Click += new System.EventHandler(this.GameSound_Click);
            // 
            // GameWindow
            // 
            this.GameWindow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameWindow.Location = new System.Drawing.Point(24, 147);
            this.GameWindow.Name = "GameWindow";
            this.GameWindow.Size = new System.Drawing.Size(935, 594);
            this.GameWindow.TabIndex = 11;
            this.GameWindow.TabStop = false;
            this.GameWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGame);
            // 
            // SnakeStartInstruction
            // 
            this.SnakeStartInstruction.AutoSize = true;
            this.SnakeStartInstruction.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeStartInstruction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SnakeStartInstruction.Location = new System.Drawing.Point(21, 52);
            this.SnakeStartInstruction.Name = "SnakeStartInstruction";
            this.SnakeStartInstruction.Size = new System.Drawing.Size(191, 29);
            this.SnakeStartInstruction.TabIndex = 22;
            this.SnakeStartInstruction.Text = "Press Enter to Play";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.SnakeStartInstruction);
            this.Controls.Add(this.SnakeHelpButton);
            this.Controls.Add(this.GameSound);
            this.Controls.Add(this.labelGameOverSub);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.GameWindow);
            this.Name = "SnakeGame";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SnakeHelpButton;
        private System.Windows.Forms.PictureBox GameSound;
        private System.Windows.Forms.Label labelGameOverSub;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox GameWindow;
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Label SnakeStartInstruction;
    }
}