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
            this.diffpanel = new System.Windows.Forms.Panel();
            this.hardbtn = new System.Windows.Forms.Button();
            this.easybtn = new System.Windows.Forms.Button();
            this.medbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tile10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tile11 = new System.Windows.Forms.Button();
            this.tile12 = new System.Windows.Forms.Button();
            this.tile01 = new System.Windows.Forms.Button();
            this.tile02 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tile03 = new System.Windows.Forms.Button();
            this.tile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tile00 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tile0_0 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadGame = new System.Windows.Forms.PictureBox();
            this.diffpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGame)).BeginInit();
            this.SuspendLayout();
            // 
            // newgame
            // 
            this.newgame.AutoSize = true;
            this.newgame.Font = new System.Drawing.Font("Niagara Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.Location = new System.Drawing.Point(171, 16);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(87, 33);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "New game";
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
            // tile10
            // 
            this.tile10.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile10.Location = new System.Drawing.Point(30, 176);
            this.tile10.Name = "tile10";
            this.tile10.Size = new System.Drawing.Size(75, 73);
            this.tile10.TabIndex = 32;
            this.tile10.UseVisualStyleBackColor = true;
            this.tile10.Click += new System.EventHandler(this.tile10_Click);
            // 
            // button15
            // 
            this.button15.Image = global::Minesweeper.Properties.Resources.tile;
            this.button15.Location = new System.Drawing.Point(177, 246);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 73);
            this.button15.TabIndex = 31;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Image = global::Minesweeper.Properties.Resources.tile;
            this.button14.Location = new System.Drawing.Point(30, 246);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 73);
            this.button14.TabIndex = 30;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Image = global::Minesweeper.Properties.Resources.tile;
            this.button13.Location = new System.Drawing.Point(249, 314);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 73);
            this.button13.TabIndex = 29;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Image = global::Minesweeper.Properties.Resources.tile;
            this.button12.Location = new System.Drawing.Point(104, 246);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 73);
            this.button12.TabIndex = 28;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tile11
            // 
            this.tile11.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile11.Location = new System.Drawing.Point(104, 176);
            this.tile11.Name = "tile11";
            this.tile11.Size = new System.Drawing.Size(75, 73);
            this.tile11.TabIndex = 27;
            this.tile11.UseVisualStyleBackColor = true;
            this.tile11.Click += new System.EventHandler(this.tile11_Click);
            // 
            // tile12
            // 
            this.tile12.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile12.Location = new System.Drawing.Point(177, 176);
            this.tile12.Name = "tile12";
            this.tile12.Size = new System.Drawing.Size(75, 73);
            this.tile12.TabIndex = 26;
            this.tile12.UseVisualStyleBackColor = true;
            this.tile12.Click += new System.EventHandler(this.tile12_Click);
            // 
            // tile01
            // 
            this.tile01.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile01.Location = new System.Drawing.Point(104, 106);
            this.tile01.Name = "tile01";
            this.tile01.Size = new System.Drawing.Size(75, 73);
            this.tile01.TabIndex = 25;
            this.tile01.UseVisualStyleBackColor = true;
            this.tile01.Click += new System.EventHandler(this.tile01_Click);
            // 
            // tile02
            // 
            this.tile02.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile02.Location = new System.Drawing.Point(177, 106);
            this.tile02.Name = "tile02";
            this.tile02.Size = new System.Drawing.Size(75, 73);
            this.tile02.TabIndex = 24;
            this.tile02.UseVisualStyleBackColor = true;
            this.tile02.Click += new System.EventHandler(this.tile02_Click);
            // 
            // button7
            // 
            this.button7.Image = global::Minesweeper.Properties.Resources.tile;
            this.button7.Location = new System.Drawing.Point(249, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 73);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tile03
            // 
            this.tile03.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile03.Location = new System.Drawing.Point(249, 106);
            this.tile03.Name = "tile03";
            this.tile03.Size = new System.Drawing.Size(75, 73);
            this.tile03.TabIndex = 22;
            this.tile03.UseVisualStyleBackColor = true;
            this.tile03.Click += new System.EventHandler(this.tile03_Click);
            // 
            // tile
            // 
            this.tile.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile.Location = new System.Drawing.Point(249, 176);
            this.tile.Name = "tile";
            this.tile.Size = new System.Drawing.Size(75, 73);
            this.tile.TabIndex = 21;
            this.tile.UseVisualStyleBackColor = true;
            this.tile.Click += new System.EventHandler(this.tile_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Minesweeper.Properties.Resources.tile;
            this.button3.Location = new System.Drawing.Point(177, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 73);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tile00
            // 
            this.tile00.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile00.Location = new System.Drawing.Point(30, 106);
            this.tile00.Name = "tile00";
            this.tile00.Size = new System.Drawing.Size(75, 73);
            this.tile00.TabIndex = 18;
            this.tile00.UseVisualStyleBackColor = true;
            this.tile00.Click += new System.EventHandler(this.tile00_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Minesweeper.Properties.Resources.tile;
            this.button1.Location = new System.Drawing.Point(104, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tile0_0
            // 
            this.tile0_0.Image = global::Minesweeper.Properties.Resources.tile;
            this.tile0_0.Location = new System.Drawing.Point(30, 314);
            this.tile0_0.Name = "tile0_0";
            this.tile0_0.Size = new System.Drawing.Size(75, 73);
            this.tile0_0.TabIndex = 16;
            this.tile0_0.UseVisualStyleBackColor = true;
            this.tile0_0.Click += new System.EventHandler(this.tile0_0_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 281);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.Transparent;
            this.loadGame.Image = global::Minesweeper.Properties.Resources.gamebutton;
            this.loadGame.Location = new System.Drawing.Point(291, 12);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(41, 41);
            this.loadGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadGame.TabIndex = 0;
            this.loadGame.TabStop = false;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 453);
            this.Controls.Add(this.tile10);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.tile11);
            this.Controls.Add(this.tile12);
            this.Controls.Add(this.tile01);
            this.Controls.Add(this.tile02);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tile03);
            this.Controls.Add(this.tile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tile00);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tile0_0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.diffpanel);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.loadGame);
            this.Name = "Game";
            this.Text = "Game";
            this.diffpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadGame;
        private System.Windows.Forms.Label newgame;
        private System.Windows.Forms.Panel diffpanel;
        private System.Windows.Forms.Button hardbtn;
        private System.Windows.Forms.Button easybtn;
        private System.Windows.Forms.Button medbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tile0_0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tile00;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button tile;
        private System.Windows.Forms.Button tile03;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button tile02;
        private System.Windows.Forms.Button tile01;
        private System.Windows.Forms.Button tile12;
        private System.Windows.Forms.Button tile11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button tile10;
    }
}

