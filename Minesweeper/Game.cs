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
        bool[] button = new bool[16];
        bool gameisOver = false;

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
            var rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                if (rand.Next() %2 != 0) //not mine
                {
                    button[i] = false;
                }
                else
                {
                    button[i] = true;
                    minecount++;

                }
            }
        }

        private void checkWinner() //checks tiles to declare winner
        {
            if (checktiles + minecount == totaltile)
            {
                MessageBox.Show("You won!");
            }
        }

        private void gameOver() // declares gameover
        {
            gameisOver = true;
            tile.BackgroundImage = Minesweeper.Properties.Resources.mine;
            MessageBox.Show("You've clicked a mine. Game Over.");
        }
         
        //*****Tile buttons below*******

        private void tile00_Click(object sender, EventArgs e)
        {
            tile00.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {
               // MessageBox.Show("You won!");


                if (button[0] == true)
                {
                    tile00.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile00.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile01_Click(object sender, EventArgs e)
        {
            tile01.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[1] == true)
                {
                    tile01.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile01.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile02_Click(object sender, EventArgs e)
        {
            tile02.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[2] == true)
                {
                    tile02.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile02.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile03_Click(object sender, EventArgs e)
        {
            tile03.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[3] == true)
                {
                    tile03.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile03.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            tile10.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[4] == true)
                {
                    tile10.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile10.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            tile11.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[5] == true)
                {
                    tile11.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile11.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            tile12.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[6] == true)
                {
                    tile12.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile12.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile_Click(object sender, EventArgs e)
        {
            tile.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[7] == true)
                {
                    tile.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[8] == true)
                {
                    button14.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button14.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[9] == true)
                {
                    button12.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button12.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[10] == true)
                {
                    button15.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button15.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[11] == true)
                {
                    button7.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button7.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void tile0_0_Click(object sender, EventArgs e)
        {
            tile0_0.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[12] == true)
                {
                    tile0_0.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    tile0_0.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[13] == true)
                {
                    button1.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button1.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[14] == true)
                {
                    button3.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button3.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Image = Minesweeper.Properties.Resources.pressedtile;

            if (!gameisOver)
            {


                if (button[15] == true)
                {
                    button13.BackgroundImage = Minesweeper.Properties.Resources.mine;
                    gameOver();
                }
                else
                {
                    button13.BackgroundImage = Minesweeper.Properties.Resources.pressedtile;

                }
                checktiles++;
                checkWinner();
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