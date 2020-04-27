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
    public partial class SnakeGame : Form
    {
        private List<SnakeBody> Snake = new List<SnakeBody>();    //Array of snake parts
        private SnakeBody food = new SnakeBody();
        SnakeSettings settings = new SnakeSettings();

        bool mute = false;

        public SnakeGame()
        {
            InitializeComponent();

            GameTick.Interval = 1000 / settings.GetSpeed(); //Sets speed of ticks in ms, default is 50
            GameTick.Tick += UpdateScreen;
            GameTick.Start();   //Starts timer
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            SnakeInput.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            SnakeInput.changeState(e.KeyCode, false);
        }

        private void UpdateGame(object sender, PaintEventArgs e)    //Drawing Snake
        {
            Graphics game = e.Graphics;

            //If game is not over
            if (settings.GetGameOver() == false)
            {

                Brush SnakeColor;
                SnakeColor = Brushes.Green;
                for (int i = 0; i < Snake.Count; i++)
                {
                    //Draw Snake
                    game.FillRectangle(SnakeColor, new Rectangle((Snake[i].GetX() * settings.GetWidth()), (Snake[i].GetY() * settings.GetHeight()), settings.GetWidth(), settings.GetHeight()));

                    //Draw Food
                    game.FillEllipse(Brushes.Red, new Rectangle((food.GetX() * settings.GetWidth()), (food.GetY() * settings.GetHeight()), settings.GetWidth(), settings.GetHeight()));
                }
            }

        }

        private void UpdateScreen(object sender, EventArgs e)  //Will run every tick
        {
            //Check for game over
            if (settings.GetGameOver() == true)
            {
                if ((SnakeInput.KeyPress(Keys.Enter)))
                {
                    StartGame();
                }
            }
            else
            {
                //Game is not over, check for inputs
                if ((SnakeInput.KeyPress(Keys.Right) || SnakeInput.KeyPress(Keys.D)) && settings.GetDirection() != "Left") //Checking for either right arrow key or d and that the snake is not pointed left
                {
                    settings.SetDirection("Right");
                }
                else if ((SnakeInput.KeyPress(Keys.Left) || SnakeInput.KeyPress(Keys.A)) && settings.GetDirection() != "Right")
                {
                    settings.SetDirection("Left");
                }
                else if ((SnakeInput.KeyPress(Keys.Down) || SnakeInput.KeyPress(Keys.S)) && settings.GetDirection() != "Up")
                {
                    settings.SetDirection("Down");
                }
                else if ((SnakeInput.KeyPress(Keys.Up) || SnakeInput.KeyPress(Keys.W)) && settings.GetDirection() != "Down")
                {
                    settings.SetDirection("Up");
                }
                MoveSnake();
            }
            GameWindow.Invalidate(); //Redraws screen every tick to simulate movement
        }

        private void MoveSnake()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)     //Check for snake head
                {
                    switch (settings.GetDirection())
                    {
                        //Checks what direction to move the snake
                        case "Right":
                            Snake[i].AddX();
                            break;
                        case "Left":
                            Snake[i].SubX();
                            break;
                        case "Down":
                            Snake[i].AddY();
                            break;
                        case "Up":
                            Snake[i].SubY();
                            break;
                    }
                    //Check if snake has hit anything, only need to check with the head
                    CheckCollisions(i);

                }
                else
                {   //If its not the head, update the piece the take the place of the previous body part
                    Snake[i].SetX(Snake[i - 1].GetX());
                    Snake[i].SetY(Snake[i - 1].GetY());
                }
            }
        }


        private void CheckCollisions(int i)
        {
            //Prevent the snake from leaving the window
            int xMax = GameWindow.Size.Width / settings.GetWidth();
            int yMax = GameWindow.Size.Height / settings.GetHeight();
            SoundPlayer GameOver = new SoundPlayer(Properties.Resources.GameOver);

            //Check if snake is out of bounds
            if ((Snake[i].GetX() < 0) || (Snake[i].GetY() < 0) || (Snake[i].GetX() > xMax) || (Snake[i].GetY() > yMax))
            {
                if (mute == false)
                {
                    GameOver.Play();
                }
                EndGame();
            }

            //Check if snake hits itself
            for (int j = 1; j < Snake.Count; j++)
            {
                if (Snake[i].GetX() == Snake[j].GetX() && Snake[i].GetY() == Snake[j].GetY())
                {
                    if (mute == false)
                    {
                        GameOver.Play();
                    }
                    EndGame();
                }
            }

            //Check if snake hits food
            if (Snake[0].GetX() == food.GetX() && Snake[0].GetY() == food.GetY())
            {
                EatFood();
            }
        }

        private void StartGame()
        {
            //Resetting game
            settings.SetGameOver(false);
            labelGameOver.Visible = false;
            labelGameOverSub.Visible = false;
            SnakeStartInstruction.Visible = false;
            settings.SetDirection("Down");
            settings.SetScore(0);
            ScoreLabel.Text = "0";
            Snake.Clear();

            //Create head
            SnakeBody head = new SnakeBody(10, 10);
            Snake.Add(head);

            CreateFood();

        }

        private void CreateFood()   //Runs when food is eaten and when game starts, spawns food on map
        {
            //Max cord vals
            int xMax = GameWindow.Size.Width / settings.GetWidth();
            int yMax = GameWindow.Size.Height / settings.GetHeight();

            //Creates random vals for x and y cords
            Random r = new Random();
            int yRand;
            int xRand;

            //Check to make sure food doesn't spawn inside of the snake
            while (true == true)
            {
                //Infinite loop until a spot is found
                yRand = r.Next(0, yMax);
                xRand = r.Next(0, xMax);
                bool unique = true;
                //Checks every part of the snake
                for (int i = Snake.Count - 1; i >= 0; i--)
                {
                    //Check if food has same cords as a part of snake
                    if (Snake[i].GetX() == xRand && Snake[i].GetY() == yRand)
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique == true)
                {
                    food.SetX(xRand);
                    food.SetY(yRand);
                    break;
                }

            }
        }

        private void EatFood()  //Runs when snake makes collision with food
        {
            //Takes position of last snake body part and adds a new piece
            SnakeBody x = new SnakeBody(Snake[Snake.Count - 1].GetX(), Snake[Snake.Count - 1].GetY());
            Snake.Add(x);
            //Play sound
            SoundPlayer Eat = new SoundPlayer(Properties.Resources.eatSound);
            if (mute == false)
            {
                Eat.Play();
            }
            //Updating Score
            settings.SetScore(settings.GetScore() + 1);
            ScoreLabel.Text = Convert.ToString(settings.GetScore());
            //updating High Score
            if (settings.GetScore() > Convert.ToInt32(labelHighScore.Text))
            {
                labelHighScore.Text = Convert.ToString(settings.GetScore());
            }

            CreateFood();
        }

        private void EndGame()
        {
            //Ends Game
            settings.SetGameOver(true);
            settings.SetScore(0);
            labelGameOver.Visible = true;
            labelGameOverSub.Visible = true;
            //Plays game over sound
        }
        private void GameSound_Click(object sender, EventArgs e)
        {
            // Used to mute sound
            if (mute == false)
            {
                mute = true;
                GameSound.Image = Properties.Resources.off;
            }
            else
            {
                mute = false;
                GameSound.Image = Properties.Resources.on;
            }
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The goal of Snake is to maneuver a line and collect food to grow in length and score. You must be careful however because bumping into yourself or the walls will result in a game over.\n \n \n Use WASD or arrow keys to control the snake");
        }
    }
}
