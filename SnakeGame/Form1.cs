using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {

        private List<Body> Snake = new List<Body>();    //Array of snake parts
        private Body food = new Body();
        Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();

            

            GameTick.Interval = 1000 / settings.GetSpeed(); //Sets speed of ticks in ms, default is 50
            GameTick.Tick += UpdateScreen;
            GameTick.Start();   //Starts timer

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void UpdateGame(object sender, PaintEventArgs e)
        {
            Graphics game = e.Graphics;

            //If game is not over
            if(settings.GetGameOver() == false)
            {
                
                Brush SnakeColor;
                SnakeColor = Brushes.Green;
                for(int i = 0; i < Snake.Count; i++)
                {
                    //Draw Snake
                    game.FillEllipse(SnakeColor, new Rectangle((Snake[i].GetX() * settings.GetWidth()), (Snake[i].GetY() * settings.GetHeight()), settings.GetWidth(), settings.GetHeight()));
                    
                    //Draw Food
                    game.FillEllipse(Brushes.Red, new Rectangle((food.GetX() * settings.GetWidth()), (food.GetY() * settings.GetHeight()), settings.GetWidth(), settings.GetHeight()));
                }
            }
            //If game is over
            else
            {
                //Show a game over message
                //Probably just make something visible
            }


        }

        private void UpdateScreen(object sender, EventArgs e)  //Will run every tick
        {
            //Check for game over
            if(settings.GetGameOver() == true)
            {
                EndGame();
            }
            else
            {
                //Game is not over, check for inputs
                if((Input.KeyPress(Keys.Right) || Input.KeyPress(Keys.D)) && settings.GetDirection() != "Left") //Checking for either right arrow key or d and that the snake is not pointed left
                {
                    settings.SetDirection("Right");
                }
                else if ((Input.KeyPress(Keys.Left) || Input.KeyPress(Keys.A)) && settings.GetDirection() != "Right") 
                {
                    settings.SetDirection("Left");
                }
                else if ((Input.KeyPress(Keys.Down) || Input.KeyPress(Keys.S)) && settings.GetDirection() != "Up")
                {
                    settings.SetDirection("Down");
                }
                else if ((Input.KeyPress(Keys.Up) || Input.KeyPress(Keys.W)) && settings.GetDirection() != "Down")
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

            if ((Snake[i].GetX() < 0) || (Snake[i].GetY() < 0) || (Snake[i].GetX() > xMax) || (Snake[i].GetY() > yMax))
            {
                EndGame();
            }

            //Check if snake hits itself
            for(int j = 1; j < Snake.Count; j++)
            {
                if(Snake[i].GetX() == Snake[j].GetX() && Snake[i].GetY() == Snake[j].GetY())
                {
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
            //Run at a button press maybe
            settings.SetGameOver(false);
            Body head = new Body(10, 10);
            ScoreLabel.Text = "0";
            Snake.Clear();
            Snake.Add(head);

            CreateFood();

        }

        private void CreateFood()
        {
            int xMax = GameWindow.Size.Width / settings.GetWidth();
            int yMax = GameWindow.Size.Height / settings.GetHeight();

            Random r = new Random();

            int yRand;
            int xRand;
            //Check to make sure food doesn't spawn inside of the snake
            while(true == true)
            {
                //Inifinite loop until a spot is found
                yRand = r.Next(0, yMax);
                xRand = r.Next(0, xMax);
                bool unique = true;
                //Checks every part of the snake
                for(int i = Snake.Count-1; i >= 0; i--)
                {
                    if(Snake[i].GetX() == xRand && Snake[i].GetY() == yRand)
                    {
                        unique = false;
                        break;
                    }
                }
                if(unique == true)
                {
                    food.SetX(xRand);
                    food.SetY(yRand);
                    break;
                }

            }
           

        }

        private void EatFood()
        {
            Body x = new Body(Snake[Snake.Count - 1].GetX(), Snake[Snake.Count - 1].GetY());
            Snake.Add(x);
            settings.SetScore(settings.GetScore() + 1);
            ScoreLabel.Text = Convert.ToString(settings.GetScore());
            CreateFood();
        }

        private void EndGame()
        {
            settings.SetGameOver(true);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            //Input.changeState(e.KeyCode, true)
            label2.Text = "test5 worked";
        }
    }
}
