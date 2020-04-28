using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainmainmenu
{
    class Mine
    {
        private bool[,] isMine = new bool[4, 4];
        private int minecount;

        public Mine()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.isMine[i, j] = false;
                }
            }
            this.minecount = 0;
        }

        public void SetTrue(int i, int j)
        {
            this.isMine[i, j] = true;
        }
        public void SetFalse(int i, int j)
        {
            this.isMine[i, j] = false;
        }
        public bool GetMine(int i, int j)
        {
            return this.isMine[i, j];
        }
        public void addMine()
        {
            this.minecount += 1;
        }

        public int GetMinecount()
        {
            return this.minecount;
        }
    }
}

