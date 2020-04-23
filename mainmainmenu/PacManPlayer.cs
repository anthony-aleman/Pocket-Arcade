using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainmainmenu
{
    class PacManPlayer
    {
        private int pacManSpeed { get; set; }

        private int userScore { get; set; }
        private bool upDirection { get; set; }
        private bool downDirection { get; set; }
        private bool rightDirection { get; set; }
        private bool leftDirection { get; set; }

        public PacManPlayer()
        {
            this.upDirection = false;
            this.downDirection = false;
            this.rightDirection = false;
            this.leftDirection = false;

            //Game score
            this.userScore = 0;

            //Player Speeds
            this.pacManSpeed = 10;
        }

        //Pacman direction behavior

        public void SetRight()
        {
            this.rightDirection = true;
        }

        public void SetLeft()
        {
            this.leftDirection = true;
        }

        public void SetUp()
        {
            this.upDirection = true;
        }

        public void SetDown()
        {
            this.downDirection = true;
        }

        public void ChangeUp()
        {
            this.upDirection = !upDirection;
        }

        public void ChangeDown()
        {
            this.downDirection = !downDirection;
        }

        public void ChangeRight()
        {
            this.rightDirection = !rightDirection;
        }

        public void ChangeLeft()
        {
            this.leftDirection = !leftDirection;
        }





        //Keyup event 

        public void SetFalse(string direction)
        {
            if (direction == "left")
            {
                this.leftDirection = false;
            }
            if (direction == "right")
            {
                this.rightDirection = false;
            }
            if (direction == "up")
            {
                this.upDirection = false;
            }
            if (direction == "down")
            {
                this.downDirection = false;
            }
        }

        //Pacman speed
        public int Speed()
        {
            return this.pacManSpeed;
        }

        //Game Score
        public void Score()
        {
            ++userScore;
        }

        //Returns directional behavior
        public int GetScore()
        {
            return this.userScore;
        }

        public bool PacManUp()
        {
            return this.upDirection;
        }

        public bool PacManDown()
        {
            return this.downDirection;
        }

        public bool PacManRight()
        {
            return this.rightDirection;
        }

        public bool PacManLeft()
        {
            return this.leftDirection;
        }

    }
}
