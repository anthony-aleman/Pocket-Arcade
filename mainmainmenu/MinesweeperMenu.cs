﻿using System;
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
    public partial class MinesweeperMenu : Form
    {
        public MinesweeperMenu()
        {
            InitializeComponent();
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            MinesweeperGameScreen minesweeperGame = new MinesweeperGameScreen();
            minesweeperGame.Show();

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
