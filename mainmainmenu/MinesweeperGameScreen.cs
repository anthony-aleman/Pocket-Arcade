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
            startGame();
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
                else if (i == 0 && j == 1)
                {
                    tile0_1.Image = Properties.Resources.mine_2;
                }
                else if (i == 0 && j == 2)
                {
                    tile0_2.Image = Properties.Resources.mine_2;
                }
                else if (i == 0 && j == 3)
                {
                    tile0_3.Image = Properties.Resources.mine_2;
                }
                else if (i == 1 && j == 0)
                {
                    tile1_0.Image = Properties.Resources.mine_2;
                }
                else if (i == 1 && j == 1)
                {
                    tile1_1.Image = Properties.Resources.mine_2;
                }
                else if (i == 1 && j == 2)
                {
                    tile1_2.Image = Properties.Resources.mine_2;
                }
                else if (i == 2 && j == 2)
                {
                    tile2_2.Image = Properties.Resources.mine_2;
                }
                else if (i == 2 && j == 1)
                {
                    tile2_1.Image = Properties.Resources.mine_2;
                }
                else if (i == 2 && j == 0)
                {
                    tile2_0.Image = Properties.Resources.mine_2;
                }
                else if (i == 1 && j == 3)
                {
                    tile1_3.Image = Properties.Resources.mine_2;
                }
                else if (i == 2 && j == 3)
                {
                    tile2_3.Image = Properties.Resources.mine_2;
                }
                else if (i == 3 && j == 0)
                {
                    tile3_0.Image = Properties.Resources.mine_2;

                }
                else if (i == 3 && j == 1)
                {
                    tile3_1.Image = Properties.Resources.mine_2;
                }
                else if (i == 3 && j == 2)
                {
                    tile3_2.Image = Properties.Resources.mine_2;
                }
                else if (i == 3 && j == 3)
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
                if (Tile.GetValue(i, j) == 1)
                {
                    tile0_0.Image = Properties.Resources.emptytile_1;
                }
                else if (Tile.GetValue(i, j) == 2)
                {
                    tile0_0.Image = Properties.Resources.emptytile_2;
                }
                else if (Tile.GetValue(i, j) == 3)
                {
                    tile0_0.Image = Properties.Resources.emptytile_3;
                }
                else if (Tile.GetValue(i, j) == 4)
                {
                    tile0_0.Image = Properties.Resources.emptytile_4;
                }
                else
                {
                    tile0_0.Image = Properties.Resources.mine_2;
                }
            }
            if (i == 0 && j == 1)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile0_1.Image = Properties.Resources.emptytile_1;
                }
                else if (Tile.GetValue(i, j) == 2)
                {
                    tile0_1.Image = Properties.Resources.emptytile_2;
                }
                else if (Tile.GetValue(i, j) == 3)
                {
                    tile0_1.Image = Properties.Resources.emptytile_3;
                }
                else if (Tile.GetValue(i, j) == 4)
                {
                    tile0_1.Image = Properties.Resources.emptytile_4;
                }
                else
                {
                    tile0_1.Image = Properties.Resources.mine_2;
                }
            }
            if (i == 0 && j == 2)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile0_2.Image = Properties.Resources.emptytile_1;
                }
                else if (Tile.GetValue(i, j) == 2)
                {
                    tile0_2.Image = Properties.Resources.emptytile_2;
                }
                else if (Tile.GetValue(i, j) == 3)
                {
                    tile0_2.Image = Properties.Resources.emptytile_3;
                }
                else if (Tile.GetValue(i, j) == 4)
                {
                    tile0_2.Image = Properties.Resources.emptytile_4;
                }
                else
                {
                    tile0_2.Image = Properties.Resources.mine_2;
                }
            }
            if (i == 0 && j == 3)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile0_3.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile0_3.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile0_3.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile0_3.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 1 && j == 0)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile1_0.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile1_0.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile1_0.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile1_0.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 1 && j == 1)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile1_1.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile1_1.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile1_1.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile1_1.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 1 && j == 2)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile1_2.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile1_2.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile1_2.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile1_2.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 2 && j == 2)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile2_2.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile2_2.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile2_2.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile2_2.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 2 && j == 1)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile2_1.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile2_1.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile2_1.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile2_1.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 2 && j == 0)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile2_0.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile2_0.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile2_0.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile2_0.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 1 && j == 3)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile1_3.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile1_3.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile1_3.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile1_3.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 2 && j == 3)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile2_3.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile2_3.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile2_3.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile2_3.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 3 && j == 0)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile3_0.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile3_0.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile3_0.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile3_0.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 3 && j == 1)
            {
                if (Tile.GetValue(i,j) == 1)
                {
                    tile3_1.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile3_1.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile3_1.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile3_1.Image = Properties.Resources.emptytile_4;
                }
                
            }
            if (i == 3 && j == 2)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile3_2.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile3_2.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile3_2.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile3_2.Image = Properties.Resources.emptytile_4;
                }
            }
            if (i == 3 && j == 3)
            {
                if (Tile.GetValue(i, j) == 1)
                {
                    tile3_3.Image = Properties.Resources.emptytile_1;
                }
                if (Tile.GetValue(i, j) == 2)
                {
                    tile3_3.Image = Properties.Resources.emptytile_2;
                }
                if (Tile.GetValue(i, j) == 3)
                {
                    tile3_3.Image = Properties.Resources.emptytile_3;
                }
                if (Tile.GetValue(i, j) == 4)
                {
                    tile3_3.Image = Properties.Resources.emptytile_4;
                }
            }
        }

        private void checkWinner() //checks tiles to declare winner
        {
            if (Tile.GetCheckedTiles() + Mine.GetMinecount() == Tile.GetTotalTiles())
            {
                MessageBox.Show("You won!");
                disableButtons();
            }
        }

        private void gameOver() // declares gameover
        {
            MessageBox.Show("You've clicked a mine. Game Over.");
            label1.Visible = true;
            disableButtons();
        }

        private void disableButtons()
        {
            try
            {
                foreach (PictureBox pcbx in Controls)
                {
                    PictureBox p = (PictureBox)pcbx;
                    pcbx.Enabled = false;
                }
            }
            catch { }

        }


       
        private void tile0_0_Click(object sender, EventArgs e)
        {
            tile0_0.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 0);
            checkTileScore(0, 0);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile1_0_Click(object sender, EventArgs e)
        {
            tile1_0.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 0);
            checkTileScore(1, 0);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile2_0_Click(object sender, EventArgs e)
        {
            tile2_0.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 0);
            checkTileScore(2, 0);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile3_0_Click(object sender, EventArgs e)
        {
            tile3_0.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 0);
            checkTileScore(3, 0);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile0_1_Click(object sender, EventArgs e)
        {
            tile0_1.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 1);
            checkTileScore(0, 1);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile1_1_Click(object sender, EventArgs e)
        {
            tile1_1.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 1);
            checkTileScore(1, 1);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile3_1_Click(object sender, EventArgs e)
        {
            tile3_1.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 1);
            checkTileScore(3, 1);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile0_2_Click(object sender, EventArgs e)
        {
            tile0_2.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 2);
            checkTileScore(0, 2);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile1_2_Click_1(object sender, EventArgs e)
        {
            tile1_2.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 2);
            checkTileScore(1, 2);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile2_2_Click(object sender, EventArgs e)
        {
            tile2_2.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 2);
            checkTileScore(2, 2);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile3_2_Click(object sender, EventArgs e)
        {
            tile3_2.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 2);
            checkTileScore(3, 2);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile0_3_Click(object sender, EventArgs e)
        {
            tile0_3.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 3);
            checkTileScore(0, 3);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile1_3_Click(object sender, EventArgs e)
        {
            tile1_3.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 3);
            checkTileScore(1, 3);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile2_3_Click(object sender, EventArgs e)
        {
            tile2_3.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 3);
            checkTileScore(2, 3);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile3_3_Click(object sender, EventArgs e)
        {
            tile3_3.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 3);
            checkTileScore(3, 3);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void tile2_1_Click(object sender, EventArgs e)
        {
            tile2_1.Image = Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 1);
            checkTileScore(2, 1);

            if (!gameisOver)
            {
                Tile.AddCheckedTile();
            }
            else
            {
                gameOver();
            }
        }

        private void NewGame_Button_Click(object sender, EventArgs e)
        {
            MinesweeperGameScreen gameScreen = new MinesweeperGameScreen();
            gameScreen.Show();
        }
    }
}
