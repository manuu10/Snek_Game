using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Snek_Game
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow(Form1 form)
        {
            InitializeComponent();
            lbl_WndInfo.Text = Text;
            mainForm = form;

            txt_startspeed.Text = mainForm._snakeMovePeriodStart.ToString();
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

        private void btn_loadcfg_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Config files (*.cfg)|*.cfg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            ofd.Dispose();
            if (!string.IsNullOrEmpty(path))
            {
                loadconf(path);
                debuglabel.Text = "Configuration loaded!";
                return;
            }
            debuglabel.Text = "Loading cancelled";           
        }

        private void btn_savecfg_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Config files (*.cfg)|*.cfg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
            }
            sfd.Dispose();
            StreamWriter sw = new StreamWriter(path);
            sw.Write(StringFromAllOptions());
            sw.Dispose();
            debuglabel.Text = "Configuration saved!";
        }

        private void btn_applycfg_Click(object sender, EventArgs e)
        {
            mainForm._snakeMovePeriodStart = Convert.ToInt32(txt_startspeed.Text);
            mainForm._snakeMovePeriodMin = Convert.ToInt32(txt_maxspeed.Text);
            mainForm._snakeMovePeriodMinMin = Convert.ToInt32(txt_speedySpeed.Text);
            mainForm._snakeMovePeriodMaxMax = Convert.ToInt32(txt_slowSpeed.Text);
            mainForm._snakeSpeedUpPeriodMax = Convert.ToInt32(txt_speedUpTime.Text);

            mainForm._powerUpSpawnPeriodMax = Convert.ToInt32(txt_pwupTime.Text);
            mainForm._powerUpAmountMax = Convert.ToInt32(txt_maxPwup.Text);

            mainForm._obstacleSpawnPeriodMax = Convert.ToInt32(txt_obsTime.Text);
            mainForm._obstacleAmountMax = Convert.ToInt32(txt_maxObs.Text);
            debuglabel.Text = "Configuration applied!";
        }

        private string StringFromAllOptions()
        {
            
            var output = String.Format(
                    "[startspeed]\n" +
                    "{0}\n\n" +
                    "[maxspeed]\n" +
                    "{1}\n\n" +
                    "[speedyspeed]\n" +
                    "{2}\n\n" +
                    "[slowspeed]\n" +
                    "{3}\n\n" +
                    "[speeduptime]\n" +
                    "{4}\n\n\n\n" +

                    "[powerupspawntime]\n" +
                    "{5}\n\n" +
                    "[maxpowerups]\n" +
                    "{6}\n\n\n\n" +

                    "[obstaclespawntime]\n" +
                    "{7}\n\n" +
                    "[maxobstacle]\n" +
                    "{8}",
                    txt_startspeed.Text,
                    txt_maxspeed.Text,
                    txt_speedySpeed.Text,
                    txt_slowSpeed.Text,
                    txt_speedUpTime.Text,
                    txt_pwupTime.Text,
                    txt_maxPwup.Text,
                    txt_obsTime.Text,
                    txt_maxObs.Text);
            output = output.Replace("\n", Environment.NewLine);
            return output;
        }

        private void btn_res_def_Click(object sender, EventArgs e)
        {
            loadconf("defaultconfig.manu");
        }

        private void loadconf(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "[startspeed]")
                    txt_startspeed.Text = sr.ReadLine();
                else if (line == "[maxspeed]")
                    txt_maxspeed.Text = sr.ReadLine();
                else if (line == "[speedyspeed]")
                    txt_speedySpeed.Text = sr.ReadLine();
                else if (line == "[slowspeed]")
                    txt_slowSpeed.Text = sr.ReadLine();
                else if (line == "[speeduptime]")
                    txt_speedUpTime.Text = sr.ReadLine();

                else if (line == "[powerupspawntime]")
                    txt_pwupTime.Text = sr.ReadLine();
                else if (line == "[maxpowerups]")
                    txt_maxPwup.Text = sr.ReadLine();

                else if (line == "[obstaclespawntime]")
                    txt_obsTime.Text = sr.ReadLine();
                else if (line == "[maxobstacle]")
                    txt_maxObs.Text = sr.ReadLine();

            }
            sr.Dispose();
        }
    }
}
