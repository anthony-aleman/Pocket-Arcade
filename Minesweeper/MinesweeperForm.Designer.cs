namespace Minesweeper
{
    partial class MinesweeperForm
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
            this.Gamebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tileGrid = new Minesweeper.MinesweeperForm.TileGrid();
            ((System.ComponentModel.ISupportInitialize)(this.Gamebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // Gamebutton
            // 
            this.Gamebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gamebutton.Image = global::Minesweeper.Properties.Resources.GameButton;
            this.Gamebutton.Location = new System.Drawing.Point(221, 13);
            this.Gamebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Gamebutton.Name = "Gamebutton";
            this.Gamebutton.Size = new System.Drawing.Size(47, 43);
            this.Gamebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gamebutton.TabIndex = 1;
            this.Gamebutton.TabStop = false;
            this.Gamebutton.Click += new System.EventHandler(this.LoadGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "New game";
            // 
            // tileGrid
            // 
            this.tileGrid.AutoSize = true;
            this.tileGrid.BackgroundImage = global::Minesweeper.Properties.Resources.Tile;
            this.tileGrid.Location = new System.Drawing.Point(13, 64);
            this.tileGrid.Margin = new System.Windows.Forms.Padding(4);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(288, 439);
            this.tileGrid.TabIndex = 0;
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gamebutton);
            this.Controls.Add(this.tileGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.Gamebutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Gamebutton;
        private System.Windows.Forms.Label label1;
        private TileGrid tileGrid;
    }
}

