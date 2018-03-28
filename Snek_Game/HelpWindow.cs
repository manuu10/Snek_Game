using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
            lbl_WndInfo.Text = Text;
            int startX = 20;
            int startY = 20;

            int space = 15;
            foreach (var val in Enum.GetValues(typeof(Bonus.Powerups)))
            {
                Label txt = new Label
                {
                    Location = new Point(startX, startY),
                    Text = Enum.GetName(typeof(Bonus.Powerups), val),
                    AutoSize = false,
                    Size = new Size(150,30),
                    Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                
                Label col = new Label
                {
                    Location = new Point(startX + txt.Width - 30, startY+5),
                    BackColor = Bonus.colPallete[(int)val],
                    AutoSize = false,
                    Size = new Size(20,20)
                };
                pnl_powerups.Controls.Add(txt);
                pnl_powerups.Controls.Add(col);
                txt.SendToBack();
                col.BringToFront();
                startY += 30;
            }
            // Food
            {
                Label txt = new Label
                {
                    Location = new Point(startX, startY + space),
                    Text = "Food",
                    AutoSize = false,
                    Size = new Size(150, 30),
                    Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label col = new Label
                {
                    Location = new Point(startX + txt.Width - 30, startY + 5 + space),
                    AutoSize = false,
                    Size = new Size(20, 20)
                };
                
                col.Paint += FoodInfo_Paint;
                pnl_powerups.Controls.Add(txt);
                pnl_powerups.Controls.Add(col);
                txt.SendToBack();
                col.BringToFront();
                startY += 30;
            }
            // Obstacle
            {
                Label txt = new Label
                {
                    Location = new Point(startX, startY + space),
                    Text = "Obstacle",
                    AutoSize = false,
                    Size = new Size(150, 30),
                    Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label col = new Label
                {
                    Location = new Point(startX + txt.Width - 30, startY + 5 + space),
                    AutoSize = false,
                    Size = new Size(20, 20)
                };

                col.Paint += ObstacleInfo_Paint;
                pnl_powerups.Controls.Add(txt);
                pnl_powerups.Controls.Add(col);
                txt.SendToBack();
                col.BringToFront();
                startY += 30;
            }

            if (this.Size.Height < startY)
            {
                this.Size = new Size(this.Size.Width,startY + 60);
            }

        }

        private void FoodInfo_Paint(object sender, PaintEventArgs e)
        {
            Label l = (Label) sender;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(new SolidBrush(new Food(new Point(-1, -1)).c), 0, 0, l.Width, l.Height);
        }
        private void ObstacleInfo_Paint(object sender, PaintEventArgs e)
        {
            Label l = (Label)sender;
            e.Graphics.FillRectangle(new SolidBrush(new Obstacle(new Point(-1, -1)).c), 0, 0, l.Width, l.Height);
        }

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

        private void HelpWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
