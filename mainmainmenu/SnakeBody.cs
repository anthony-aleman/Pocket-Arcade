using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainmainmenu
{
    class SnakeBody
    {
        private int x;
        private int y;

        public SnakeBody()
        {
            x = 0;
            y = 0;
        }

        public SnakeBody(int num1, int num2)
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

