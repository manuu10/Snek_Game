using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow(Form1 form)
        {
            InitializeComponent();
            lbl_WndInfo.Text = Text;
            mainForm = form;

            txt_startspeed.Text = mainForm._snakeMovePeriodMax.ToString();
            txt_maxspeed.Text = mainForm._snakeMovePeriodMin.ToString();
            txt_speedySpeed.Text = mainForm._snakeMovePeriodMinMin.ToString();
            txt_slowSpeed.Text = mainForm._snakeMovePeriodMaxMax.ToString();
            txt_speedUpTime.Text = mainForm._snakeSpeedUpPeriodMax.ToString();

            txt_pwupTime.Text = mainForm._powerUpSpawnPeriodMax.ToString();
            txt_maxPwup.Text = mainForm._powerUpAmountMax.ToString();

            txt_obsTime.Text = mainForm._obstacleSpawnPeriodMax.ToString();
            txt_maxObs.Text = mainForm._obstacleAmountMax.ToString();
        }
        private Form1 mainForm;
        #region Window tasks
        Point lastlocation;
        bool mousedown;
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
        #endregion
    }
}
