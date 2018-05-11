using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(int score)
        {
            InitializeComponent();
            lbl_WndInfo.Text = Text;
            btn_submit.Left = (this.ClientSize.Width - btn_submit.Width) / 2;

            Score = score;
            lbl_score.Text = "Your final Score\n" +
                                    "is\n" +
                               Score.ToString();
        }

        #region Window tasks

        private Point lastlocation;
        private bool mousedown;

        private void btn_CloseWnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_WndInfo_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastlocation = e.Location;
        }

        private void lbl_WndInfo_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void lbl_WndInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - lastlocation.X) + e.X, (this.Location.Y - lastlocation.Y) + e.Y);

                this.Update();
            }
        }

        #endregion Window tasks

        private int Score;
        private List<Score_info> Scoreboard = new List<Score_info>();

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Scoreboard = Misc.GetScoreboard("Scoreboard.txt");
            Scoreboard.Add(new Score_info(txt_name.Text, Score));
            Scoreboard = Scoreboard.OrderByDescending(x => x.score).ToList();

            StreamWriter sw = new StreamWriter("Scoreboard.txt");
            foreach (var item in Scoreboard)
            {
                sw.Write("{0}:{1}" + Environment.NewLine, item.name, item.score);
            }
            sw.Dispose();
            this.Close();
        }
    }
}