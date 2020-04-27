using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{

    /*************************************
     Name: Program
     Purpose: Run game
     Notes: N/A
     ************************************/
    public partial class Game : Form
    {
        Tile tile = new Tile();
        Mine mine = new Mine();

        int totaltile = 16;
        int minecount = 0 , checktiles = 0; //counts for mines and then check tiles
        int[,] button = new int [4,4];
        bool gameisOver = false;
        bool[,] isMine = new bool [4,4];

        public Game()
        {
            InitializeComponent();
            coolfont();
            startGame();
        }


        private void startGame()
        {
            gameisOver = false;
            Array.Clear(button, 0, button.Length); //clears the array for new game
            Array.Clear(isMine, 0, isMine.Length);
            var rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (rand.Next() % 2 != 0) //not mine
                    {
                        mine.SetFalse(i, j);
                    }
                    else
                    {
                        mine.SetTrue(i, j);
                        tile.Set0(i, j);
                        mine.addMine();

                        try
                        {
                            tile.SetValues(i, j);
                        }
                        catch (IndexOutOfRangeException)
                        {

                        }
                        

                    }
                }
            }

            
        }

       /*private void addValues(int i, int j)
          {
            //Body
            if ((i == 1 || i == 2) && (j == 1 || j == 2))//Positions {(2,2),(2,3),(3,2),(3,3)}
            {
                if (isMine[i + 1, j] == false)
                {
                    button[i + 1, j] += 1;
                }
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j + 1] == false)
                {
                    button[i, j + 1] += 1;
                }
                if (isMine[i, j - 1] == false)
                {
                    button[i, j - 1] += 1;
                }
            }
            //Left 
            if (i == 0  && (j == 1 || j == 2))//Positions {(1,2),(1, 3)}
            {
                if (isMine[i + 1, j] == false)
                {
                    button[i + 1, j] += 1;
                }
                if (isMine[i, j - 1] == false)
                {
                    button[i, j - 1] += 1;
                }
                if (isMine[i, j + 1] == false)
                {
                    button[i, j + 1] += 1;
                }
            }
            //Right
            if (i == 3 && (j == 1 || j == 2))//Positions {(4,2),(4,3)}
            {
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j + 1] == false)
                {
                    button[i, j + 1] += 1;
                }
                if (isMine[i, j - 1] == false)
                {
                    button[i, j + 1] += 1;
                }
            }
            //Top
            if ((i == 1 || i == 2) && j == 0)//Positions {(2, 1)(3,1)}
            {
                if (isMine[i + 1, j] == false)
                {
                    button[i + 1, j] += 1;
                }
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j + 1] == false)
                {
                    button[i, j + 1] += 1;
                }
            }
            if ((i == 1 || i == 2) && (j == 3))//Position {(2,4),(3,4)}
            {
                if (isMine[i + 1, j] == false)
                {
                    button[i + 1, j] += 1;
                }
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j -1] == false)
                {
                    button[i, j - 1] += 1;
                }
            }
            //Corners
            if ((i == 0 && j == 0))// Position {(1,1)}
            {
                if (isMine[i + 1, j] == false)
                {
                    button[i + 1, j] += 1;
                }
                if (isMine[i, j + 1] == false)
                {
                    button[i + 1, j] += 1;
                }
            }
            if ((i == 0 && j == 3))//Position {1,4)}
            {
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j - 1] == false)
                {
                    button[i, j - 1] += 1;
                }
            }
            if ((i == 3 && j == 0))//Postion {(4,1)}
            {
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j + 1] == false)
                {
                    button[i, j + 1] += 1;
                }
            }
            if ((i == 3 && j == 3))//Position {(4,4)}
            {
                if (isMine[i - 1, j] == false)
                {
                    button[i - 1, j] += 1;
                }
                if (isMine[i, j - 1] == false)
                {
                    button[i, j - 1] += 1;
                }
            }
          }*/

        private void setMineImage(int i, int j)
        {

            if (mine.GetMine(i,j) == true)
            {
                if (i == 0 && j == 0)
                {
                    tile00.Image = Properties.Resources.Mine_pic;
                }
                if (i == 0 && j == 1)
                {
                    tile01.Image = Properties.Resources.Mine_pic;
                }
                if (i == 0 && j == 2)
                {
                    tile02.Image = Properties.Resources.Mine_pic;
                }
                if (i == 0 && j == 3)
                {
                    tile03.Image = Properties.Resources.Mine_pic;
                }
                if (i == 1 && j == 0)
                {
                    tile10.Image = Properties.Resources.Mine_pic;
                }
                if (i == 1 && j == 1)
                {
                    tile11.Image = Properties.Resources.Mine_pic;
                }
                if (i == 1 && j == 2)
                {
                    tile12.Image = Properties.Resources.Mine_pic;
                }
                if (i == 2 && j == 2)
                {
                    tile22.Image = Properties.Resources.Mine_pic;
                }
                if (i == 2 && j == 1)
                {
                    tile21.Image = Properties.Resources.Mine_pic;
                }
                if (i == 2 && j == 0)
                {
                    tile20.Image = Properties.Resources.Mine_pic;
                }
                if (i == 1 && j == 3)
                {
                    tile13.Image = Properties.Resources.Mine_pic;
                }
                if (i == 2 && j == 3)
                {
                    tile23.Image = Properties.Resources.Mine_pic;
                }
                if (i == 3 && j == 0)
                {
                    tile30.Image = Properties.Resources.Mine_pic;
                    
                }
                if (i == 3 && j == 1)
                {
                    tile31.Image = Properties.Resources.Mine_pic;
                }
                if (i == 3 && j == 2)
                {
                    tile32.Image = Properties.Resources.Mine_pic;
                }
                if (i == 3 && j == 3)
                {
                    tile33.Image = Properties.Resources.Mine_pic;
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
                tile00.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 0 && j == 1)
            {
                tile01.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 0 && j == 2)
            {
                tile02.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 0 && j == 3)
            {
                tile03.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 0)
            {
                tile10.Text = tile.GetValue(i, j).ToString(); 
            }
            if (i == 1 && j == 1)
            {
                tile11.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 2)
            {
                tile12.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 2)
            {
                tile22.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 1)
            {
                tile21.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 0)
            {
                tile20.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 1 && j == 3)
            {
                tile13.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 2 && j == 3)
            {
                tile23.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 0)
            {
                tile30.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 1)
            {
                tile31.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 2)
            {
                tile32.Text = tile.GetValue(i, j).ToString();
            }
            if (i == 3 && j == 3)
            {
                tile33.Text = tile.GetValue(i, j).ToString();
            }
        }

        private void checkWinner() //checks tiles to declare winner
        {
            if (checktiles + minecount == totaltile)
            {
                MessageBox.Show("You won!");
                disableButtons();
            }
        }

        private void gameOver() // declares gameover
        {
            tile13.BackgroundImage = Minesweeper.Properties.Resources.mine;
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
            catch{ }

        }
         
        //*****Tile buttons below*******

        private void tile00_Click(object sender, EventArgs e)
        {
            tile00.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 0);
            checkTileScore(0, 0);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile01_Click(object sender, EventArgs e)
        {
            tile00.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 1);
            checkTileScore(0, 1);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile02_Click(object sender, EventArgs e)
        {
            tile02.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 2);
            checkTileScore(0, 2);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile03_Click(object sender, EventArgs e)
        {
            tile03.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(0, 3);
            checkTileScore(0, 3);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            tile10.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 0);
            checkTileScore(1, 0);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            tile11.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 1);
            checkTileScore(1, 1);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            tile12.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 2);
            checkTileScore(1, 2);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }


        private void loadGame_Click(object sender, EventArgs e)
        {
            startGame();
            Game newGame = new Game();
            newGame.Show();

        }

        private void tile13_Click(object sender, EventArgs e)
        {
            tile13.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(1, 3);
            checkTileScore(1, 3);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile20_Click(object sender, EventArgs e)
        {
            tile20.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 0);
            checkTileScore(2, 0);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile21_Click(object sender, EventArgs e)
        {
            tile21.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 1);
            checkTileScore(0, 0);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile22_Click(object sender, EventArgs e)
        {
            tile22.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 2);
            checkTileScore(2, 2);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile23_Click(object sender, EventArgs e)
        {
            tile23.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(2, 3);
            checkTileScore(2, 3);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile30_Click(object sender, EventArgs e)
        {
            tile30.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 0);
            checkTileScore(3, 0);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile31_Click(object sender, EventArgs e)
        {
            tile31.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 1);
            checkTileScore(3, 1);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile32_Click(object sender, EventArgs e)
        {
            tile32.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 2);
            checkTileScore(3, 2);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void tile33_Click(object sender, EventArgs e)
        {
            tile33.Image = Minesweeper.Properties.Resources.pressedtile;
            checkWinner();
            setMineImage(3, 3);
            checkTileScore(3, 3);

            if (!gameisOver)
            {
                checktiles++;
            }
            else
            {
                gameOver();
            }
        }

        private void coolfont()
        {
            PrivateFontCollection newFont = new PrivateFontCollection();

        newFont.AddFontFile("digit-7-mono.ttf");

            newgame.Font = new Font(newFont.Families[0], 14);
    }
}
}