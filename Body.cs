using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Body  //Serves to create the parts of the snake and also will be used for food
    {
        private int x;
        private int y;

        public Body()
        {
            x = 0;
            y = 0;
        }

        public Body(int num1, int num2)
        {
            x = num1;
            y = num2;
        }


        //Getters
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        //Setters
        public void AddX()
        {
            x++;
        }

        public void AddY()
        {
            y++;
        }
        public void SubX()
        {
            x--;
        }

        public void SubY()
        {
            y--;
        }
        public void SetX(int num)
        {
            x = num;
        }

        public void SetY(int num)
        {
            y = num;
        }
    }
}
