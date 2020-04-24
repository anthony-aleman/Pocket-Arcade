using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Settings  //Holds all settings so that they can be easily changed
    {
        private int Width;
        private int Height;
        private int Speed;
        private int Score;
        private bool GameOver;
        private string Direction;

        public Settings()
        {
            Width = 18;
            Height = 18;
            Speed = 20;
            Score = 0;
            GameOver = false;
            Direction = "Down";
        }

        public int GetWidth()
        {
            return Width;
        }
        public int GetHeight()
        {
            return Height; 
        }
        public int GetSpeed()
        {
            return Speed;
        }
        public int GetScore()
        {
            return Score;
        }
        public bool GetGameOver()
        {
            return GameOver;
        }
        public string GetDirection()
        {
            return Direction;
        }

        public void SetWidth(int num)
        {
            Width = num;
        }
        public void SetHeight(int num)
        {
            Height = num;
        }
        public void SetSpeed(int num)
        {
            Speed = num;
        }
        public void SetScore(int num)
        {
            Score = num;
        }
        public void SetGameOver(bool x)
        {
            GameOver = x;
        }
        public void SetDirection(string x)
        {
            Direction = x;
        }
    }
}
