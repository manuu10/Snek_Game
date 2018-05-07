using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IniParser;
using IniParser.Model;

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

            chk_glowing.Checked = mainForm.glowing;
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
            ofd.Filter = "Ini files (*.ini)|*.ini";
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
        private void loadconf(string path)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(path);

            txt_startspeed.Text = data["snake"]["startspeed"];
            txt_maxspeed.Text = data["snake"]["maxspeed"];
            txt_speedySpeed.Text = data["snake"]["speedyspeed"];
            txt_slowSpeed.Text = data["snake"]["slowspeed"];
            txt_speedUpTime.Text = data["snake"]["speeduptime"];

            txt_pwupTime.Text = data["powerup"]["spawnTime"];
            txt_maxPwup.Text = data["powerup"]["maxAmount"];

            txt_obsTime.Text = data["obstacle"]["spawnTime"];
            txt_maxObs.Text = data["obstacle"]["maxAmount"];

            bool flag;
            if (bool.TryParse(data["other"]["glowing"], out flag))
            {
                chk_glowing.Checked = flag;
            }
            else
            {
                chk_glowing.Checked = false;
            }
        }

        private void btn_savecfg_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Ini files (*.ini)|*.ini";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
            }
            sfd.Dispose();
            if (!string.IsNullOrEmpty(path))
            {
                saveconf(path);
                debuglabel.Text = "Configuration saved!";
                return;
            }
            debuglabel.Text = "Saving cancelled";
        }
        private void saveconf(string path)
        {
            var parser = new FileIniDataParser();
            var data = new IniData();
            data["snake"]["startspeed"] = txt_startspeed.Text;
            
            data["snake"]["maxspeed"] = txt_maxspeed.Text;
            data["snake"]["speedyspeed"] = txt_speedySpeed.Text;
            data["snake"]["slowspeed"] = txt_slowSpeed.Text;
            data["snake"]["speeduptime"] = txt_speedUpTime.Text;

            data["powerup"]["spawnTime"] = txt_pwupTime.Text;
            data["powerup"]["maxAmount"] = txt_maxPwup.Text;

            data["obstacle"]["spawnTime"] = txt_obsTime.Text;
            data["obstacle"]["maxAmount"] = txt_maxObs.Text;

            data["other"]["glowing"] = Convert.ToString(chk_glowing.Checked);
            parser.WriteFile(path, data);
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

            mainForm.glowing = chk_glowing.Checked;
            debuglabel.Text = "Configuration applied!";
        }

        //private string StringFromAllOptions()
        //{
            
        //    var output = String.Format(
        //            "[startspeed]\n" +
        //            "{0}\n" +
        //            "[maxspeed]\n" +
        //            "{1}\n" +
        //            "[speedyspeed]\n" +
        //            "{2}\n" +
        //            "[slowspeed]\n" +
        //            "{3}\n" +
        //            "[speeduptime]\n" +
        //            "{4}\n\n" +

        //            "[powerupspawntime]\n" +
        //            "{5}\n" +
        //            "[maxpowerups]\n" +
        //            "{6}\n\n" +

        //            "[obstaclespawntime]\n" +
        //            "{7}\n" +
        //            "[maxobstacle]\n" +
        //            "{8}",
        //            txt_startspeed.Text,
        //            txt_maxspeed.Text,
        //            txt_speedySpeed.Text,
        //            txt_slowSpeed.Text,
        //            txt_speedUpTime.Text,
        //            txt_pwupTime.Text,
        //            txt_maxPwup.Text,
        //            txt_obsTime.Text,
        //            txt_maxObs.Text);
        //    output = output.Replace("\n", Environment.NewLine);
        //    return output;
        //}

        private void btn_res_def_Click(object sender, EventArgs e)
        {
            loadconf("defaultconfig.DEFAULT_INI");
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = "0";
            }
            ((TextBox)sender).Text = ((TextBox)sender).Text.Replace("-", "");
        }
    }
}
