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
                        isMine[i, j] = false;
                    }
                    else
                    {
                        isMine[i, j] = true;
                        minecount++;

                    }
                }
            }
        }

       private void addValues()
          {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (isMine[i,j] == true)
                    {
                        if ((i == 2 || i == 3) && (j == 2 || j == 3))//Positions {(2,2),(2,3),(3,2),(3,3)}
                        {
                            button[i + 1, j] += 1;
                            button[i - 1, j] += 1;
                            button[i, j + 1] += 1;
                            button[i, j - 1] += 1;
                        }
                        if ((i == 1 || i == 4) && (j == 2 || j == 3))//Positions {(1,2),(1, 3),(4, 2),(4, 3)}
                        {
                            button[i + 1, j] += 1;
                            button[i, j - 1] += 1;
                            button[i, j + 1] += 1;
                        }
                        if ((i == 2 || i == 3) && j == 1)//Positions {(2, 1)(3, 1)}
                        {
                            button[i + 1, j] += 1;
                            button[i - 1, j] += 1;
                            button[i, j + 1] += 1;
                        }
                        if ((i == 1 && j == 1))// Position {(1,1)}
                        {
                            button[i + 1, j] += 1;
                            button[i, j + 1] += 1;
                        }
                        if ((i == 1 && j == 4))//Position {1,4)}
                        {
                            button[i - 1, j] += 1;
                            button[i, j - 1] += 1;
                        }
                        if ((i == 4 && j == 1))//Postion {(4,1)}
                        {
                            button[i - 1, j] += 1;
                            button[i, j + 1] += 1;
                        }
                        if ((i == 1 && j == 1))//Position {(4,4)}
                        {
                            button[i - 1, j] += 1;
                            button[i, j - 1] += 1;
                        }
                    }
                    else
                    {
                        button[i, j] = -1;
                    }
                }
            }
          }

        private void checkMine(int i, int j)
        {

            if (isMine[i,j] == true)
            {
                if (i == 0 && j == 0)
                {
                    tile00.Image = Properties.Resources.mine;
                }
                if (i == 0 && j == 1)
                {
                    tile01.Image = Properties.Resources.mine;
                }
                if (i == 1 && j == 0)
                {
                    tile10.Image = Properties.Resources.mine;
                }
                if (i == 1 && j == 1)
                {
                    tile11.Image = Properties.Resources.mine;
                }
                if (i == 1 && j == 2)
                {
                    tile12.Image = Properties.Resources.mine;
                }
                if (i == 2 && j == 2)
                {
                    tile22.Image = Properties.Resources.mine;
                }
                if (i == 2 && j == 1)
                {
                    tile21.Image = Properties.Resources.mine;
                }
                if (i == 2 && j == 3)
                {
                    tile23.Image = Properties.Resources.mine;
                }
                if (i == 3 && j == 2)
                {
                    tile32.Image = Properties.Resources.mine;
                }
                gameisOver = true;
            }
            else
            {
                gameisOver = false;
            }

         

        }

        private void checkWinner() //checks tiles to declare winner
        {
            if (checktiles + minecount == totaltile)
            {
                MessageBox.Show("You won!");
                disableButtons();
            }
            //disableButtons();
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
            checkMine(0, 0);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile01_Click(object sender, EventArgs e)
        {
            tile01.Image = Minesweeper.Properties.Resources.pressedtile;
           // tile01.Enabled = false;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile02_Click(object sender, EventArgs e)
        {
            tile02.Image = Minesweeper.Properties.Resources.pressedtile;
            //tile02.Enabled = false;
            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile03_Click(object sender, EventArgs e)
        {
            tile03.Image = Minesweeper.Properties.Resources.pressedtile;
            //tile03.Enabled = false;
            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            tile10.Image = Minesweeper.Properties.Resources.pressedtile;
            //tile10.Enabled = false;
            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            tile11.Image = Minesweeper.Properties.Resources.pressedtile;
            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            tile12.Image = Minesweeper.Properties.Resources.pressedtile;
            tile12.Enabled = false;
            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile_Click(object sender, EventArgs e)
        {
            tile13.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tile20.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tile21.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tile22.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tile23.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void tile0_0_Click(object sender, EventArgs e)
        {
            tile30.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tile31.Image = Minesweeper.Properties.Resources.pressedtile;
            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tile32.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
            }
            else
            {
                gameOver();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tile33.Image = Minesweeper.Properties.Resources.pressedtile;

            checkMine(0, 1);

            if (!gameisOver)
            {
                checktiles++;
                checkWinner();
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
        private void coolfont()
        {
            PrivateFontCollection newFont = new PrivateFontCollection();

        newFont.AddFontFile("digit-7-mono.ttf");

            newgame.Font = new Font(newFont.Families[0], 14);
    }
}
}