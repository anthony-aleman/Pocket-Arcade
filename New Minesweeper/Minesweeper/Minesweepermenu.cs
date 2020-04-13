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
    public partial class Minesweepermenu : Form
    {
        public Minesweepermenu()
        {
            InitializeComponent();
        }

        private void playbtn_Click(object sender, EventArgs e) 
        {
            Game newGame = new Game();
            newGame.Show();
        }

        private void playbtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.BlueViolet;
        }

        private void playbtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Black;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exitbtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.BlueViolet;
        }

        private void Exitbtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Black;
        }
    }
}
