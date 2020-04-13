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
    public partial class Game : Form
    {
        Button[,] btn = new Button[41, 45];
        int[,] btn_prop = new int[41, 41];
        int[,] saved_btn_prop = new int[41, 41];
        Point coord;

        bool firstPlay = true;
        bool gameover = false;

        //points that are around
        int[] dx8 = { 1, 0, -1, 0, 1, -1, -1, 1 };
        int[] dy8 = { 0, 1, 0, -1, 1, -1, 1, -1 };

        //table aspect
        int start_x, start_y;
        int height, width;

        //game variables
        int mines;
        int flag_value = 10;
        int gameDifficulty;
        int flags;

        //button aspect
        int buttonSize = 20;
        int distance_between = 20;

        //coefficients for difficulty 
        double easyCoef = 0.1f;
        double mediumCoef = 0.2f;
        double hardCoef = 0.3f;

        public Game()
        {
            InitializeComponent();
        }

        private void loadgame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        bool MenuIsOpen = false;
        private void dropdown_Click(object sender, EventArgs e)
        {
            //show difficulty levels
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MenuIsOpen)
            {
                diffpanel.Height -= 20;
                if (diffpanel.Height == 0)
                {
                    timer1.Stop();
                    MenuIsOpen = false;
                }
            }
            else if (!MenuIsOpen)
            {
                diffpanel.Height += 20;
                if (diffpanel.Height == 88)
                {
                    timer1.Stop();
                    MenuIsOpen = true;
                }
            }
        }


        void set_ButtonImage(int x, int y)
        {
            btn[x, y].Enabled = false;
            btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;

            if (gameover && btn_prop[x, y] == flag_value)
               btn_prop[x, y] = saved_btn_prop[x, y];  

            if (gameover)
               timer.Stop();

            switch (btn_prop[x, y])
            {
                case 0:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.tile;
                    EmptySpace(x, y);
                    break;
                case 1:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_1;
                    break;
                case 2:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_2;
                    break;
                case 3:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_3;
                    break;
                case 4:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_4;
                    break;
                case 5:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_5;
                    break;
                case 6:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_6;
                    break;
                case 7:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_7;
                    break;
                case 8:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.emptytile_8;
                    break;
                case -1:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.mine;
                    if (!gameover)
                      gameover(); 
                    break;
            }
        }

        int isPointOnMap(int x, int y)
        {
            if (x < 1 || x > width || y < 1 || y > height)
                return 0;
            return 1;
        }

        void EmptySpace(int x, int y)
        {
            if (btn_prop[x, y] == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int cx = x + dx8[i];
                    int cy = y + dy8[i];

                    if (isPointOnMap(cx, cy) == 1)
                        if (btn[cx, cy].Enabled == true && btn_prop[cx, cy] != -1 && !gameover)
                        {
                           gameProgress.Value++; 
                           score.Text = "Score:" + gameProgress.Value.Tostring(); 
                            set_ButtonImage(cx, cy);
                        }
                }
            }
        }

        void Discover_Map()
        {
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i, j].Enabled == true)
                    {
                        set_ButtonImage(i, j);
                    }
        }
        void GameOver()
        {
        gameover = true;
        Discover_Map();
        MessageBox.Show("Game Over!!");
        }

        void Check_FlagWin()
        {
            bool win = true;
            for (int i = 1; i <= width; i++)
                for (int j = 1; i <= height; j++)
                if (btn_prop[i, j] == -1)
                    win = false;

            if (win)
            {
                WinGame();
            }
        }

        void WinGame()
        {
            gameover = true;
            Discover_Map();
            gameProgress.Value = 0; 
            MessageBox.Show("Win!");
        }

        void Check_ClickWin()
        {
            bool win = true;
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i, j].Enabled == true && saved_btn_prop[i, j] != -1) 
                        win = false;

            if (win)
            {
                WinGame();
            }
        }

        private void OneClick(object sender, EventArgs e)
        {
            coord = ((Button)sender).Location;
            int x = (coord.X = start_x) / buttonSize;
            int y = (coord.Y = start_y) / buttonSize;

            if (btn_prop[x,y] != flag_value)
            {
                ((Button)sender).Enabled = false;
                ((Button)sender).Text = "";

                ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;


                if (btn_prop[x, y] != -1 && !gameover)
                {
                  gameprogess.Value++; 
                  score.Text = "Score" + gameProgress.Value.ToString(); 
                    Check_ClickWin();
                }

                set_ButtonImage(x, y);
            }
        }

        int MinesAround (int x, int y)
        {
            int score = 0;
            for (int i =0; i < 8; i++)
            {
                int cx = x + dx8[i];
                int cy = y + dy8[i];

                if (isPointOnMap(cx, cy) == 1 && btn_prop[cx, cy] == -1)
                    score++;
            }
            return score;
        }
        void SetMapNumbers(int x, int y)
        {
            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                    if (btn_prop[i, j] != -1)
                    {
                        btn_prop[i, j] = MinesAround(i, j);
                        saved_btn_prop[i, j] = MinesAround(i, j); 
                    }
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                coord = ((Button)sender).Location;
                int x = (coord.X = start_x) / buttonSize;
                int y = (coord.Y = start_y) / buttonSize;

                if ( btn_prop[x,y] != flag_value && flags > 0)
                {
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImageLayout = Minesweeper.Properties.Resources.flag;
                    btn_prop[x, y] = flag_value;
                    flags--;
                    Check_FlagWin();
                }
                else
                    if(btn_prop[x,y] = flag_value) 
                {
                    btn_prop[x, y] = saved_btn_prop[x, y];  
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImageLayout = null;  
                    flags++;
                }
                    remainingFlags.Text = "Flags: " + flags;  
            }
        }

        void CreateButtons(int x, int y)
        {
            for(int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(i * buttonSize + start_x, j * buttonSize + start_y, distance_between, distance_between);
                    btn[i, j].Click += new EventHandler(OneClick);
                    btn[i, j].MouseUp += new MouseEventHandler(RightClick);
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;  
                    btn[i, j].TabStop = false;
                    Controls.Add(btn[i, j]);
                }
        }

        void GenerateMap(int x, int y, int mines)
        {
            Random rand = new Random();
            List<int> coordx = new List<int>();
            List<int> coordy = new List<int>();

            while (mines > 0)
            {
                coordx.Clear();
                coordy.Clear();

                for (int i = 1; i <= x; i++)
                    for (int j = 1; j <= y; j++)
                        if (btn_prop[i, j] != -1)
                        {
                            coordx.Add(i);
                            coordy.Add(j);
                        }

                int randNum = rand.Next(0, coordx.Count);
                btn_prop[coordx[randNum], coordy[randNum]] = -1;
                saved_btn_prop[coordx[randNum], coordy[randNum]] = -1;  
                mines--;
            }
        }

        void loadame()
        {
            switch (difficulty.Text)
            {
                case "Easy":
                    mines = (int)(height * width * easyCoef);
                    break;

                case "Medium":
                    mines = (int)(height * width * mediumCoef);
                    break;

                case "Hard":
                    mines = (int)(height * width * hardCoef);
                    break;
            }

            flags = mines;
            gameover = false;

            gameProgress.Value = 0;  
            gameProgress.Maximum = height * width - mines;

            remainingFlags.Text = "Flags: " + flags; 
            score.Text = "Score: " + 0;

            if (firstPlay)
                CreateButtons(width, height);

            GenerateMap(width, height, mines);
            SetMapNumbers(width, height);

        }
        void TableMargins(int x, int y)
        {
            start_x = (this.Size.Width - (width + 2) * distance_between) / 2;
            start_y = (this.Size.Height - (height + 2) * distance_between) / 2;
        }

        }

    }
