using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MinesweeperMenu : MinesweeperForm
    {
        public MinesweeperMenu()
        {
            InitializeComponent();
        }

        private void PlayGame(object sender, EventArgs e)
        {
            Application.Run();
        }

        
    }
}
