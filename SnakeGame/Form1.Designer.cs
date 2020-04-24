namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelGameOverSub = new System.Windows.Forms.Label();
            this.GameSound = new System.Windows.Forms.PictureBox();
            this.GameWindow = new System.Windows.Forms.PictureBox();
            this.HelpButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(421, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(158, 63);
            this.Title.TabIndex = 1;
            this.Title.Text = "SNAKE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(354, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score :";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(427, 82);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(23, 25);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "0";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(52, 46);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(147, 45);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.StartButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(502, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "High Score :";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHighScore.Location = new System.Drawing.Point(615, 82);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(23, 25);
            this.labelHighScore.TabIndex = 6;
            this.labelHighScore.Text = "0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameOver.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Crimson;
            this.labelGameOver.Location = new System.Drawing.Point(298, 268);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(391, 98);
            this.labelGameOver.TabIndex = 7;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.Visible = false;
            // 
            // labelGameOverSub
            // 
            this.labelGameOverSub.AutoSize = true;
            this.labelGameOverSub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameOverSub.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOverSub.Location = new System.Drawing.Point(275, 385);
            this.labelGameOverSub.Name = "labelGameOverSub";
            this.labelGameOverSub.Size = new System.Drawing.Size(441, 35);
            this.labelGameOverSub.TabIndex = 8;
            this.labelGameOverSub.Text = "Press \"Space\" or \"Enter\" to play again";
            this.labelGameOverSub.Visible = false;
            // 
            // GameSound
            // 
            this.GameSound.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameSound.Image = global::SnakeGame.Properties.Resources.on;
            this.GameSound.Location = new System.Drawing.Point(915, 66);
            this.GameSound.Name = "GameSound";
            this.GameSound.Size = new System.Drawing.Size(45, 41);
            this.GameSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameSound.TabIndex = 9;
            this.GameSound.TabStop = false;
            this.GameSound.Click += new System.EventHandler(this.GameSound_Click);
            // 
            // GameWindow
            // 
            this.GameWindow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameWindow.Location = new System.Drawing.Point(30, 137);
            this.GameWindow.Name = "GameWindow";
            this.GameWindow.Size = new System.Drawing.Size(930, 588);
            this.GameWindow.TabIndex = 0;
            this.GameWindow.TabStop = false;
            this.GameWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGame);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpButton.Image = global::SnakeGame.Properties.Resources.qmark;
            this.HelpButton.Location = new System.Drawing.Point(915, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(45, 41);
            this.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpButton.TabIndex = 10;
            this.HelpButton.TabStop = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.GameSound);
            this.Controls.Add(this.labelGameOverSub);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.GameWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.GameSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameWindow;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelGameOverSub;
        private System.Windows.Forms.PictureBox GameSound;
        private System.Windows.Forms.PictureBox HelpButton;
    }
}

