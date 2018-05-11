using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class DarkMessageBox : Form
    {
        public DarkMessageBox(string message, string title)
        {
            InitializeComponent();
            lbl_WndInfo.Text = title;
            lbl_text.Text = message;
            btn_Ok.Left = (this.ClientSize.Width - btn_Ok.Width) / 2;
            
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

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
        int thickness = 1;
        private void DarkMessageBox_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.CadetBlue;
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,    c, thickness, ButtonBorderStyle.Solid,
                                                                    c, thickness, ButtonBorderStyle.Solid,
                                                                    c, thickness, ButtonBorderStyle.Solid,
                                                                    c, thickness, ButtonBorderStyle.Solid);
            }

        private void lbl_text_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.CadetBlue;
            ControlPaint.DrawBorder(e.Graphics, lbl_text.ClientRectangle, c, thickness, ButtonBorderStyle.Solid,
                                                                          c, 0, ButtonBorderStyle.Solid,
                                                                          c, thickness, ButtonBorderStyle.Solid,
                                                                          c, 0, ButtonBorderStyle.Dashed);
            
        }

        private void lbl_WndInfo_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.CadetBlue;
            ControlPaint.DrawBorder(e.Graphics, lbl_text.ClientRectangle, c, thickness, ButtonBorderStyle.Solid,
                                                                          c, thickness, ButtonBorderStyle.Solid,
                                                                          c, thickness, ButtonBorderStyle.Solid,
                                                                          c, 0, ButtonBorderStyle.Dashed);
        }
    }
}