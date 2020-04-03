namespace Minesweeper
{
    partial class MinesweeperMenu
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
            this.gametitle = new System.Windows.Forms.TextBox();
            this.playbutton = new System.Windows.Forms.Button();
            this.minepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minepic)).BeginInit();
            this.SuspendLayout();
            // 
            // gametitle
            // 
            this.gametitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.gametitle.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gametitle.ForeColor = System.Drawing.Color.DarkViolet;
            this.gametitle.Location = new System.Drawing.Point(183, 58);
            this.gametitle.Name = "gametitle";
            this.gametitle.Size = new System.Drawing.Size(429, 62);
            this.gametitle.TabIndex = 0;
            this.gametitle.Text = "Minesweeper";
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.SystemColors.MenuText;
            this.playbutton.Font = new System.Drawing.Font("Vineta BT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.ForeColor = System.Drawing.Color.DarkViolet;
            this.playbutton.Location = new System.Drawing.Point(328, 265);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(135, 42);
            this.playbutton.TabIndex = 1;
            this.playbutton.Text = "Play";
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.PlayGame);
            // 
            // minepic
            // 
            this.minepic.BackgroundImage = global::Minesweeper.Properties.Resources.mine_2;
            this.minepic.ImageLocation = "";
            this.minepic.Location = new System.Drawing.Point(72, 125);
            this.minepic.Name = "minepic";
            this.minepic.Size = new System.Drawing.Size(133, 134);
            this.minepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minepic.TabIndex = 2;
            this.minepic.TabStop = false;
            // 
            // MinesweeperMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minepic);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.gametitle);
            this.Name = "MinesweeperMenu";
            this.Text = "MinesweeperMenu";
            ((System.ComponentModel.ISupportInitialize)(this.minepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gametitle;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.PictureBox minepic;
    }
}