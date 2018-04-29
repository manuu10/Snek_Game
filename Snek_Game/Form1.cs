using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyShit();
            lbl_WndInfo.Text = Text;
            btn_reset_Click(null, null);
        }


        //UPDATE MODEL
        private void tmr_Game_Tick(object sender, EventArgs e)
        {
            UpdateModel();
        }

        //DRAWING MODEL
        private void pbGameCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias ;
            var g = e.Graphics;
            DrawingModel(g);
        }


        private void UpdLabelSpeed()
        {
            var buff = _snakeMovePeriodMaxMax - _snakeMovePeriodMax;
            lbl_snekSpeed.Text = "Speed: " + buff;
        }

        private void UpdLabelLength()
        {
            lbl_snekSize.Text = "Length : " + snakeSnek.GetSnakeLength();
        }

        private void UpdLabelObstacle()
        {
            lbl_info_obstacles.Text = "Obstacles : " + _obstacles.Count;
        }

        private void tmr_Draw_Tick(object sender, EventArgs e)
        {
            pbGameCanvas.Refresh();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            snakeSnek.AddSegment();
            pbGameCanvas.Refresh();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            tmr_Game.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tmr_Game.Stop();
        }

        private void btnControlss(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            switch (btn.Text)
            {
                case"up":
                    snakeSnek.SetDirection(new Size(0, -1));
                    break;
                case "down":
                    snakeSnek.SetDirection(new Size(0, 1));
                    break;
                case "left":
                    snakeSnek.SetDirection(new Size(-1, 0));
                    break;
                case "right":
                    snakeSnek.SetDirection(new Size(1, 0));
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
                snakeSnek.SetDirection(new Size(0, -1));
            else if (keyData == Keys.Down)
                snakeSnek.SetDirection(new Size(0, 1));
            else if (keyData == Keys.Left)
                snakeSnek.SetDirection(new Size(-1, 0));
            else if (keyData == Keys.Right)
                snakeSnek.SetDirection(new Size(1, 0));
            else if (keyData == Keys.K)
                snakeSnek.AddSegment();
            else if (keyData == Keys.F && canShootBullets)
                _bullets.Add(new Bullet(snakeSnek.GetHeadLocation(), snakeSnek.GetSnakeDirection()));

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            snakeSnek = new Snek(startLocation);
            snakeFood = new Food(new Point(Rnd.Next(0, widht), Rnd.Next(0, height)));
            _snakeMovePeriodMax = _snakeMovePeriodStart;
            _snakeMovePeriod = 0;
            _snakeSpeedUpPeriod = 0;
            _obstacleSpawnPeriod = 0;
            _powerUpSpawnPeriod = 0;
            _bonuses.Clear();
            _obstacles.Clear();
            _bullets.Clear();
            pbGameCanvas.Refresh();
            speedy = false;
            slow = false;
            invincible = false;
            doubleMaFood = false;
            canShootBullets = false;
            _gameOver = false;
            tmr_Game.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            var hw = new HelpWindow
            {
                Parent = ParentForm,
                StartPosition = FormStartPosition.CenterParent
            };
            tmr_Game.Stop();
            hw.ShowDialog();
            tmr_Game.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btn_Help.PerformClick();
        }


        #region Window tasks

        private Point lastlocation;
        private bool mousedown;

        private void btn_CloseWnd_Click(object sender, EventArgs e)
        {
            Close();
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
            if (!mousedown) return;
            Location = new Point(
                Location.X - lastlocation.X + e.X, Location.Y - lastlocation.Y + e.Y);

            Update();
        }

        #endregion

        private void btn_opencfg_Click(object sender, EventArgs e)
        {
            
            var hw = new ConfigWindow(this)
            {
                Parent = ParentForm,
                StartPosition = FormStartPosition.CenterParent
            };
            tmr_Game.Stop();
            hw.ShowDialog();
            tmr_Game.Start();
        }
    }
}