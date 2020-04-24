using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace mainmainmenu
{
    public partial class PacManGameScreen : Form
    {
        PacManPlayer pac_man = new PacManPlayer();
        PacManGhosts ghosts = new PacManGhosts();
        public PacManGameScreen()
        {
            InitializeComponent();
        }

        private void PacManGameScreen_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            Play_BTN.Visible = false;
            Exit_BTN.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

      

        private void PacManGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //Sound of pac man moving

            SoundPlayer movingSound = new SoundPlayer(Properties.Resources.pacman_chomp);
            movingSound.Play();
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pac_man.SetLeft();
                    break;
                case Keys.Right:
                    pac_man.SetRight();
                    break;
                case Keys.Up:
                    pac_man.SetUp();
                    break;
                case Keys.Down:
                    pac_man.SetDown();
                    break;
            }
        }

        private void PacManGameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Left)
            {
                pac_man.SetFalse("left");
            }
            else if (e.KeyCode == Keys.Right)
            {
                pac_man.SetFalse("right");
            }
            else if (e.KeyCode == Keys.Up)
            {
                pac_man.SetFalse("up");

            }
            else if (e.KeyCode == Keys.Down)
            {
                pac_man.SetFalse("down");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = $"Score: { pac_man.GetScore()}";

            //movement of pacman
            if (pac_man.PacManLeft() == true)
            {
                PacManMoveLeft();
            }

            else if (pac_man.PacManRight() == true)
            {
                PacManMoveRight();
            }

            else if (pac_man.PacManUp() == true)
            {
                PacManMoveUp();
            }

            else if (pac_man.PacManDown() == true)
            {
                PacManMoveDown();
            }

            else
            {
                pacManPCBX.Location = new Point(pacManPCBX.Location.X, pacManPCBX.Location.Y);
            }
            //End of pac man movement

            //Ghost movement

            if (redGhost1PCBX.Bounds.IntersectsWith(RightBorder.Bounds))//Picture box border will ensure ghost wont move out of bounds 
            {
                ghosts.ChangeRedGhost1Direction();
            }
            if (redGhost2PCBX.Bounds.IntersectsWith(RightBorder.Bounds))
            {
                ghosts.ChangeRedGhost2Direction();
            }
            if (redGhost1PCBX.Bounds.IntersectsWith(LeftBorder.Bounds))
            {
                ghosts.ChangeRedGhost1Direction();
            }
            if (redGhost2PCBX.Bounds.IntersectsWith(LeftBorder.Bounds))
            {
                ghosts.ChangeRedGhost2Direction();
            }

            //State of Red Ghosts

            //RedGhost1
            switch (ghosts.GetRedGhost1Direction())
            {
                case true:
                    RedGhost1Left();
                    break;
                case false:
                    RedGhost1Right();
                    break;
            }

            //RedGhost2
            switch (ghosts.GetRedGhost2Direction())
            {
                case true:
                    RedGhost2Left();
                    break;
                case false:
                    RedGhost2Right();
                    break;
            }

            //End of Red ghost movement

            //Grey Ghost movement will be vertical up and Down


            //GreyGhost2

            //Checks if Grey Ghost intersects with borders
            if (greyGhost2PCBX.Bounds.IntersectsWith(TopBorder.Bounds))
            {
                ghosts.GreyGhostDown();
            }
            else if (greyGhost2PCBX.Bounds.IntersectsWith(BottomBorder.Bounds))
            {
                ghosts.GreyGhostUp();
            }
            else if (greyGhost2PCBX.Bounds.IntersectsWith(redGhost1PCBX.Bounds)
                  || greyGhost2PCBX.Bounds.IntersectsWith(redGhost2PCBX.Bounds))
            {
                ghosts.ChangeGreyGhost2Direction();
            }

            //Describes direction of ghost
            switch (ghosts.GetGreyGhost2Direction())
            {
                case true:
                    GreyGhost2Down();
                    break;
                case false:
                    GreyGhost2Up();
                    break;
            }

            //GreyGhost 1

            if (greyGhost1PCBX.Bounds.IntersectsWith(PCBXLBorder.Bounds) ||
                greyGhost1PCBX.Bounds.IntersectsWith(PCBXRBorder.Bounds))
            {
                ghosts.ChangedGreyGhost1DirectionX();
            }

            switch (ghosts.GetGreyGhost1XDirection())
            {
                case true:
                    GreyGhost1Left();
                    break;
                case false:
                    GreyGhost1Right();
                    break;
            }

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.Tag == "ghost")
                {
                    if (((PictureBox)item).Bounds.IntersectsWith(pacManPCBX.Bounds))
                    {
                        pacManPCBX.Image = Properties.Resources.Pac_man_hits_ghost;
                        label2.Visible = true;
                        label3.Visible = true;
                        if (pac_man.GetScore() == 23)
                        {
                            label2.Text = "YOU WIN";

                        }
                        else
                        {
                            label2.Text = "GAME OVER";
                            
                        }
                        label3.Text = "Play Again?";
                        Play_BTN.Visible = true;
                        Exit_BTN.Visible = true;
                        Play_BTN.Enabled = true;
                        Exit_BTN.Enabled = true;
                        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.pacman_death);
                        deathSound.Play();
                        timer1.Stop();
                      
                    }
                }

                if (item is PictureBox && item.Tag == "wall")
                {
                    if (((PictureBox)item).Bounds.IntersectsWith(pacManPCBX.Bounds))
                    {
                        pacManPCBX.Image = Properties.Resources.Pac_man_hits_ghost;
                        label2.Visible = true;
                        label3.Visible = true;
                        if (pac_man.GetScore() == 23)
                        {
                            label2.Text = "YOU WIN";
                        }
                        else
                        {
                            label2.Text = "GAME OVER";
                        }
                        label3.Text = "Play Again?";
                        Play_BTN.Visible = true;
                        Exit_BTN.Visible = true;
                        Play_BTN.Enabled = true;
                        Exit_BTN.Enabled = true;
                        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.pacman_death);
                        deathSound.PlaySync();
                        timer1.Stop();
                        
                    }
                }

                if (item is PictureBox && item.Tag == "Coin")
                {
                    if (((PictureBox)item).Bounds.IntersectsWith(pacManPCBX.Bounds))
                    {
                        this.Controls.Remove(item);
                        pac_man.Score();

                        if (pac_man.GetScore() == 23)
                        {
                            label2.Text = "YOU WIN";
                            label2.Visible = true;
                            label3.Visible = true;
                            Play_BTN.Visible = true;
                            Exit_BTN.Visible = true;
                            Play_BTN.Enabled = true;
                            Exit_BTN.Enabled = true;
                            SoundPlayer deathSound = new SoundPlayer(Properties.Resources.pacman_death);
                            deathSound.PlaySync();
                            timer1.Stop();
                        }
                        
                    }
                }
            }

        }

        //Movement Functions

        //Pac man movement
        private void PacManMoveLeft()
        {
            this.SuspendLayout();
            BringToFront();
            pacManPCBX.Location = new Point(pacManPCBX.Location.X - pac_man.Speed(),
                                         pacManPCBX.Location.Y);
            pacManPCBX.Image = Properties.Resources.Pacman_moving_left;
            this.ResumeLayout();
        }

        private void PacManMoveRight()
        {
            this.SuspendLayout();
            BringToFront();

            pacManPCBX.Location = new Point(pacManPCBX.Location.X + pac_man.Speed(),
                                         pacManPCBX.Location.Y);
            pacManPCBX.Image = Properties.Resources.Pacman_moving_right;
            this.ResumeLayout();
        }

        private void PacManMoveUp()
        {
            this.SuspendLayout();
            BringToFront();
            pacManPCBX.Location = new Point(pacManPCBX.Location.X,
                                         pacManPCBX.Location.Y - pac_man.Speed());
            pacManPCBX.Image = Properties.Resources.Pacman_moving_up;
            this.ResumeLayout();
        }

        private void PacManMoveDown()
        {
            this.SuspendLayout();
            BringToFront();
            pacManPCBX.Location = new Point(pacManPCBX.Location.X,
                                         pacManPCBX.Location.Y + pac_man.Speed());
            pacManPCBX.Image = Properties.Resources.Pac_man_moving_down;
            this.ResumeLayout();
        }

        //Ghost movement
        //RedGhost 1 & 2
        private void RedGhost1Left()
        {

            this.SuspendLayout();
            redGhost1PCBX.Image = Properties.Resources.Red_Ghost_Left_1;
            redGhost1PCBX.Location = new Point(redGhost1PCBX.Location.X - ghosts.GhostSpeed(),
                                            redGhost1PCBX.Location.Y);
            this.ResumeLayout();


        }

        private void RedGhost1Right()
        {

            this.SuspendLayout();
            redGhost1PCBX.Image = Properties.Resources.Red_Ghost_Right_1;
            redGhost1PCBX.Location = new Point(redGhost1PCBX.Location.X + ghosts.GhostSpeed(),
                                            redGhost1PCBX.Location.Y);
            this.ResumeLayout();


        }

        private void RedGhost2Left()
        {
            this.SuspendLayout();
            redGhost2PCBX.Image = Properties.Resources.Red_Ghost_Left_1;
            redGhost2PCBX.Location = new Point(redGhost2PCBX.Location.X - ghosts.GhostSpeed(),
                                            redGhost2PCBX.Location.Y);
            this.ResumeLayout();
        }

        private void RedGhost2Right()
        {
            this.SuspendLayout();
            redGhost2PCBX.Image = Properties.Resources.Ghost_final_2_55x55;
            redGhost2PCBX.Location = new Point(redGhost2PCBX.Location.X + ghosts.GhostSpeed(),
                                            redGhost2PCBX.Location.Y);
            this.ResumeLayout();
        }

        //GreyGhost 1

        private void GreyGhost1Right()
        {
            this.SuspendLayout();
            greyGhost1PCBX.Image = Properties.Resources.Grey_ghost;
            greyGhost1PCBX.Location = new Point(greyGhost1PCBX.Location.X + ghosts.GhostSpeed(), greyGhost1PCBX.Location.Y);
            this.ResumeLayout();
        }

        private void GreyGhost1Left()
        {
            this.SuspendLayout();
            greyGhost1PCBX.Image = Properties.Resources.Grey_ghost;
            greyGhost1PCBX.Location = new Point(greyGhost1PCBX.Location.X - ghosts.GhostSpeed(), greyGhost1PCBX.Location.Y);
            this.ResumeLayout();
        }

        //GreyGhost 2

        private void GreyGhost2Up()
        {
            this.SuspendLayout();
            greyGhost2PCBX.Image = Properties.Resources.Grey_Ghost_moving_up;
            greyGhost2PCBX.Location = new Point(greyGhost2PCBX.Location.X,
                                             greyGhost2PCBX.Location.Y - ghosts.GhostSpeed());
            this.ResumeLayout();

        }

        private void GreyGhost2Down()
        {
            this.SuspendLayout();
            greyGhost2PCBX.Image = Properties.Resources.Grey_Ghost_moving_down;
            greyGhost2PCBX.Location = new Point(greyGhost2PCBX.Location.X,
                                             greyGhost2PCBX.Location.Y + ghosts.GhostSpeed());
            this.ResumeLayout();
        }

        private void Play_BTN_Click(object sender, EventArgs e)
        {
            PacManGameScreen newScreen = new PacManGameScreen();
            newScreen.Show();

            SoundPlayer newGameSound = new SoundPlayer(Properties.Resources.pacman_beginning);
            newGameSound.Play();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
