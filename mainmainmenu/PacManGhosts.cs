using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainmainmenu
{
    class PacManGhosts
    {
        private int ghostSpeed;

        private bool RedGhost1 { get; set; }
        private bool RedGhost2 { get; set; }
        private bool GreyGhostLR { get; set; }
        private bool GreyGhost2 { get; set; }

        public PacManGhosts()
        {
            this.ghostSpeed = 15;
            this.RedGhost1 = false;
            this.RedGhost2 = false;
            this.GreyGhostLR = false;
            this.GreyGhost2 = false;
        }

        //Sets Direction of the Ghosts

        //Red Ghost 1
        public void RedGhost1Right()
        {
            this.RedGhost1 = false;
        }

        public void RedGhost1Left()
        {
            this.RedGhost1 = true;
        }

        //RedGhost2
        public void RedGhost2Right()
        {
            this.RedGhost2 = false;
        }

        public void RedGhost2Left()
        {
            this.RedGhost2 = true;
        }

        //GreyGhost2
        public void GreyGhostUp()
        {
            this.GreyGhost2 = false;
        }

        public void GreyGhostDown()
        {
            this.GreyGhost2 = true;
        }

        //Change Direction

        public void ChangedGreyGhost1DirectionX()
        {
            this.GreyGhostLR = !GreyGhostLR;
        }
        public void ChangeGreyGhost2Direction()
        {
            this.GreyGhost2 = !GreyGhost2;
        }

        public void ChangeRedGhost1Direction()
        {
            this.RedGhost1 = !RedGhost1;
        }

        public void ChangeRedGhost2Direction()
        {
            this.RedGhost2 = !RedGhost2;
        }



        //Gets Ghost direction
        public bool GetGreyGhost1XDirection()
        {
            return this.GreyGhostLR;
        }
        public bool GetGreyGhost2Direction()
        {
            return this.GreyGhost2;
        }

        public bool GetRedGhost1Direction()
        {
            return this.RedGhost1;
        }

        public bool GetRedGhost2Direction()
        {
            return this.RedGhost2;
        }

        public int GhostSpeed()
        {
            return ghostSpeed;
        }

    }
}
