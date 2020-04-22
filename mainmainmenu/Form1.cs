using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainmainmenu
{
    public partial class PocketArcade : Form
    {
        public PocketArcade()
        {
            InitializeComponent();
        }

        private void PocketArcade_Load(object sender, EventArgs e)
        {

        }

        private void PocketArcade_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minesweeper_BTN_Click(object sender, EventArgs e)
        {

        }

        private void Snake_BTN_Click(object sender, EventArgs e)
        {

        }

        private void PacMan_BTN_Click(object sender, EventArgs e)
        {
            PacMan pacManMenu = new PacMan();
            pacManMenu.Show();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_MouseEnter(object sender, EventArgs e)
        {
            var BTN = (Button)sender;
            BTN.BackColor = Color.BlueViolet;
        }

        private void BTN_MouseLeave(object sender, EventArgs e)
        {
            var BTN = (Button)sender;
            BTN.BackColor = Color.Orchid;
        }
    }
}
