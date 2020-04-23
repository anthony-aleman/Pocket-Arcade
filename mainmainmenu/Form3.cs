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
    public partial class PacMan : Form
    {
        public PacMan()
        {
            InitializeComponent();
        }

        private void PacMan_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_BTN_Click(object sender, EventArgs e)
        {
            PacManGameScreen pmGameScreen = new PacManGameScreen();
            pmGameScreen.Show();
        }

        private void Options_BTN_Click(object sender, EventArgs e)
        {
            PacManOptions pmOptionsScreen = new PacManOptions();
            pmOptionsScreen.Show();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_MouseEnter(object sender, EventArgs e)
        {
            var BTN = (Button)sender;
            BTN.BackColor = Color.LightGray;
        }

        private void BTN_MouseLeave(object sender, EventArgs e)
        {
            var BTN = (Button)sender;
            BTN.BackColor = Color.Black;
        }
    }
}
