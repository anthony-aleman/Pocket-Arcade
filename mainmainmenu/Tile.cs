using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainmainmenu
{
    class Tile
    {
        private int[,] tile = new int[4, 4];
        private int totaltiles;

        public Tile()
        {
            Array.Clear(tile, 0, tile.Length);
            this.totaltiles = 16;
        }

        public void Set0(int i, int j)
        {
            this.tile[i, j] = 0;
        }

        public int GetValue(int i, int j)
        {
            return this.tile[i, j];
        }
        public void SetValues(int i, int j)
        {
            Mine mine = new Mine();

            if ((i == 1 || i == 2) && (j == 1 || j == 2))//Positions {(2,2),(2,3),(3,2),(3,3)}
            {
                if (mine.GetMine(i + 1, j) == false)
                {
                    this.tile[i + 1, j] += 1;
                }
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j + 1) == false)
                {
                    this.tile[i, j + 1] += 1;
                }
                if (mine.GetMine(i, j - 1) == false)
                {
                    this.tile[i, j - 1] += 1;
                }
            }
            //Left 
            if (i == 0 && (j == 1 || j == 2))//Positions {(1,2),(1, 3)}
            {
                if (mine.GetMine(i + 1, j) == false)
                {
                    this.tile[i + 1, j] += 1;
                }
                if (mine.GetMine(i, j - 1) == false)
                {
                    this.tile[i, j - 1] += 1;
                }
                if (mine.GetMine(i, j + 1) == false)
                {
                    this.tile[i, j + 1] += 1;
                }
            }
            //Right
            if (i == 3 && (j == 1 || j == 2))//Positions {(4,2),(4,3)}
            {
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j + 1) == false)
                {
                    this.tile[i, j + 1] += 1;
                }
                if (mine.GetMine(i, j - 1) == false)
                {
                    this.tile[i, j + 1] += 1;
                }
            }
            //Top
            if ((i == 1 || i == 2) && j == 0)//Positions {(2, 1)(3,1)}
            {
                if (mine.GetMine(i + 1, j) == false)
                {
                    this.tile[i + 1, j] += 1;
                }
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j + 1) == false)
                {
                    this.tile[i, j + 1] += 1;
                }
            }
            if ((i == 1 || i == 2) && (j == 3))//Position {(2,4),(3,4)}
            {
                if (mine.GetMine(i + 1, j) == false)
                {
                    this.tile[i + 1, j] += 1;
                }
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j - 1) == false)
                {
                    this.tile[i, j - 1] += 1;
                }
            }
            //Corners
            if ((i == 0 && j == 0))// Position {(1,1)}
            {
                if (mine.GetMine(i + 1, j) == false)
                {
                    this.tile[i + 1, j] += 1;
                }
                if (mine.GetMine(i, j + 1) == false)
                {
                    this.tile[i + 1, j] += 1;
                }
            }
            if ((i == 0 && j == 3))//Position {1,4)}
            {
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j - 1) == false)
                {
                    this.tile[i, j - 1] += 1;
                }
            }
            if ((i == 3 && j == 0))//Postion {(4,1)}
            {
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j + 1) == false)
                {
                    this.tile[i, j + 1] += 1;
                }
            }
            if ((i == 3 && j == 3))//Position {(4,4)}
            {
                if (mine.GetMine(i - 1, j) == false)
                {
                    this.tile[i - 1, j] += 1;
                }
                if (mine.GetMine(i, j - 1) == false)
                {
                    this.tile[i, j - 1] += 1;
                }
            }
        }


    }
}
