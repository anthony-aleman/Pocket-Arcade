namespace mainmainmenu
{
    partial class PocketArcade
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
            this.thunberbolt2 = new System.Windows.Forms.PictureBox();
            this.thunderbolt1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbttn = new System.Windows.Forms.Button();
            this.game1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thunberbolt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunderbolt1)).BeginInit();
            this.SuspendLayout();
            // 
            // thunberbolt2
            // 
            this.thunberbolt2.Image = global::mainmainmenu.Properties.Resources.lightning_bolt;
            this.thunberbolt2.Location = new System.Drawing.Point(628, 261);
            this.thunberbolt2.Name = "thunberbolt2";
            this.thunberbolt2.Size = new System.Drawing.Size(123, 141);
            this.thunberbolt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thunberbolt2.TabIndex = 6;
            this.thunberbolt2.TabStop = false;
            // 
            // thunderbolt1
            // 
            this.thunderbolt1.Image = global::mainmainmenu.Properties.Resources.lightning_bolt;
            this.thunderbolt1.Location = new System.Drawing.Point(51, 120);
            this.thunderbolt1.Name = "thunderbolt1";
            this.thunderbolt1.Size = new System.Drawing.Size(123, 141);
            this.thunderbolt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thunderbolt1.TabIndex = 5;
            this.thunderbolt1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(175, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pocket Arcade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitbttn
            // 
            this.exitbttn.BackColor = System.Drawing.Color.Orchid;
            this.exitbttn.Font = new System.Drawing.Font("Vineta BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbttn.ForeColor = System.Drawing.Color.Blue;
            this.exitbttn.Location = new System.Drawing.Point(356, 323);
            this.exitbttn.Name = "exitbttn";
            this.exitbttn.Size = new System.Drawing.Size(135, 38);
            this.exitbttn.TabIndex = 11;
            this.exitbttn.Text = "Exit";
            this.exitbttn.UseVisualStyleBackColor = false;
            // 
            // game1
            // 
            this.game1.BackColor = System.Drawing.Color.Orchid;
            this.game1.Font = new System.Drawing.Font("Vineta BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game1.ForeColor = System.Drawing.Color.Blue;
            this.game1.Location = new System.Drawing.Point(265, 129);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(318, 38);
            this.game1.TabIndex = 12;
            this.game1.Text = "Minesweeper";
            this.game1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Font = new System.Drawing.Font("Vineta BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(265, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Snake game";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orchid;
            this.button2.Font = new System.Drawing.Font("Vineta BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(265, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pac Man";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PocketArcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.exitbttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thunberbolt2);
            this.Controls.Add(this.thunderbolt1);
            this.Name = "PocketArcade";
            this.Text = "Pocket Arcade";
            ((System.ComponentModel.ISupportInitialize)(this.thunberbolt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunderbolt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox thunderbolt1;
        private System.Windows.Forms.PictureBox thunberbolt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitbttn;
        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

