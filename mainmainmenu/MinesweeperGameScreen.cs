using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainmainmenu
{
    public partial class MinesweeperGameScreen : Form
    {
        Tile Tile = new Tile();
        Mine Mine = new Mine();

        bool gameisOver;
        public MinesweeperGameScreen()
        {
            InitializeComponent();
        }

        private void startGame()
        {
            gameisOver = false;
            var rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (rand.Next() % 2 != 0) //not mine
                    {
                        Mine.SetFalse(i, j);
                    }
                    else
                    {
                        Mine.SetTrue(i, j);
                        Tile.Set0(i, j);
                        Mine.addMine();

                        try
                        {
                            Tile.SetValues(i, j);
                        }
                        catch (IndexOutOfRangeException)
                        {

                        }


                    }
                }
            }


        }

        private void setMineImage(int i, int j)
        {

            if (Mine.GetMine(i, j) == true)
            {
                if (i == 0 && j == 0)
                {
                    tile0_0.Image = Properties.Resources.mine_2;
                }
                if (i == 0 && j == 1)
                {
                    tile0_1.Image = Properties.Resources.mine_2;
                }
                if (i == 0 && j == 2)
                {
                    tile0_2.Image = Properties.Resources.mine_2;
                }
                if (i == 0 && j == 3)
                {
                    tile0_3.Image = Properties.Resources.mine_2;
                }
                if (i == 1 && j == 0)
                {
                    tile1_0.Image = Properties.Resources.mine_2;
                }
                if (i == 1 && j == 1)
                {
                    tile1_1.Image = Properties.Resources.mine_2;
                }
                if (i == 1 && j == 2)
                {
                    tile1_2.Image = Properties.Resources.mine_2;
                }
                if (i == 2 && j == 2)
                {
                    tile2_2.Image = Properties.Resources.mine_2;
                }
                if (i == 2 && j == 1)
                {
                    tile2_1.Image = Properties.Resources.mine_2;
                }
                if (i == 2 && j == 0)
                {
                    tile2_0.Image = Properties.Resources.mine_2;
                }
                if (i == 1 && j == 3)
                {
                    tile1_3.Image = Properties.Resources.mine_2;
                }
                if (i == 2 && j == 3)
                {
                    tile2_3.Image = Properties.Resources.mine_2;
                }
                if (i == 3 && j == 0)
                {
                    tile3_0.Image = Properties.Resources.mine_2;

                }
                if (i == 3 && j == 1)
                {
                    tile3_1.Image = Properties.Resources.mine_2;
                }
                if (i == 3 && j == 2)
                {
                    tile3_2.Image = Properties.Resources.mine_2;
                }
                if (i == 3 && j == 3)
                {
                    tile3_3.Image = Properties.Resources.mine_2;
                }
                gameisOver = true;
            }
            else
            {
                gameisOver = false;
            }

        }

        private void checkTileScore(int i, int j)
        {
            if (i == 0 && j == 0)
            {
                tile0_0.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 0 && j == 1)
            {
                tile0_1.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 0 && j == 2)
            {
                tile0_2.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 0 && j == 3)
            {
                tile0_3.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 0)
            {
                tile1_0.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 1)
            {
                tile1_1.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 2)
            {
                tile1_2.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 2)
            {
                tile2_2.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 1)
            {
                tile2_1.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 0)
            {
                tile2_0.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 3)
            {
                tile1_3.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 3)
            {
                tile2_2.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 0)
            {
                tile3_0.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 1)
            {
                tile3_1.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 2)
            {
                tile3_2.Text = Tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 3)
            {
                tile3_3.Text = Tile.GetValue(i, j).ToString();
            }
        }

        private void checkWinner() //checks tiles to declare winner
        {
            if (checktiles + Mine.GetMinecount() == Tile.GetTotoalTiles())
            {
                MessageBox.Show("You won!");
                disableButtons();
            }
        }

        private void gameOver() // declares gameover
        {
            MessageBox.Show("You've clicked a mine. Game Over.");

            disableButtons();
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }


       

        private void tile1_2_Click(object sender, EventArgs e)
        {

        }

        private void tile0_0_Click(object sender, EventArgs e)
        {

        }

        private void tile1_0_Click(object sender, EventArgs e)
        {

        }

        private void tile2_0_Click(object sender, EventArgs e)
        {

        }

        private void tile3_0_Click(object sender, EventArgs e)
        {

        }

        private void tile0_1_Click(object sender, EventArgs e)
        {

        }

        private void tile1_1_Click(object sender, EventArgs e)
        {

        }

        private void tile3_1_Click(object sender, EventArgs e)
        {

        }

        private void tile0_2_Click(object sender, EventArgs e)
        {

        }

        private void tile1_2_Click_1(object sender, EventArgs e)
        {

        }

        private void tile2_2_Click(object sender, EventArgs e)
        {

        }

        private void tile3_2_Click(object sender, EventArgs e)
        {

        }

        private void tile0_3_Click(object sender, EventArgs e)
        {

        }

        private void tile1_3_Click(object sender, EventArgs e)
        {

        }

        private void tile2_3_Click(object sender, EventArgs e)
        {

        }

        private void tile3_3_Click(object sender, EventArgs e)
        {

        }
    }
}
