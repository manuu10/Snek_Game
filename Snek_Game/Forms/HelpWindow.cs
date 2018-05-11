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
            foreach (var val in Enum.GetValues(typeof(Bonus.PowerUps)))
            {
                Label txt = new Label
                {
                    Location = new Point(startX, startY),
                    Text = Enum.GetName(typeof(Bonus.PowerUps), val),
                    AutoSize = false,
                    Size = new Size(150,30),
                    Font = new Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Pixel),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label col = new Label
                {
                    Name = txt.Text,
                    Location = new Point(startX + txt.Width - 30, startY+5),
                    BackColor = Bonus.colPallete[(int)val],
                    AutoSize = false,
                    Size = new Size(20,20)
                };
                col.Click += Pickable_info_Click;
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
                    Name = txt.Text,
                    Location = new Point(startX + txt.Width - 30, startY + 5 + space),
                    AutoSize = false,
                    Size = new Size(20, 20)
                };
                col.Click += Pickable_info_Click;
                
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
                    Name = txt.Text,
                    Location = new Point(startX + txt.Width - 30, startY + 5 + space),
                    AutoSize = false,
                    Size = new Size(20, 20)
                };
                col.Click += Pickable_info_Click;

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

        private void Pickable_info_Click(object sender, EventArgs e)
        {
            
            string message = "";
            string title = "";
            switch(((Label)sender).Name)
            {
                case nameof(Bonus.PowerUps.Invincible):
                    {
                        title = nameof(Bonus.PowerUps.Invincible);
                        message = "With this powerup you will have the\n" +
                            "ability to go through walls and be immune\n" +
                            "against any Collision that would kill you.";
                        break;
                    }
                case nameof(Bonus.PowerUps.DoubleFood):
                    {
                        title = nameof(Bonus.PowerUps.DoubleFood);
                        message = "With this powerup your points you earn get\n" +
                            "doubled while active and when picking up food you\n" +
                            "earn two Segments instead of one.";
                        break;
                    }
                case nameof(Bonus.PowerUps.Speedy):
                    {
                        title = nameof(Bonus.PowerUps.Speedy);
                        message = "You are gonna be speedy as fuck with that shit.";
                        break;
                    }
                case nameof(Bonus.PowerUps.Slow):
                    {
                        title = nameof(Bonus.PowerUps.Slow);
                        message = "While active your speed is\n" +
                            "decreased abnormous.";
                        break;
                    }
                case nameof(Bonus.PowerUps.Bullets):
                    {
                        title = "The " + nameof(Bonus.PowerUps.Bullets) + " powerup";
                        message = "With that powerup you will have the\n" +
                            "ability to shoot Bullets when pressing the\n" +
                            "'F' Key on your Keyboard.\n" +
                            "They will destroy obstacles if you hit them.";
                        break;
                    }
                case nameof(Bonus.PowerUps.Ghost):
                    {
                        title = "The " + nameof(Bonus.PowerUps.Ghost) + " powerup";
                        message = "If you pick this powerup up, you will become\n" +
                            "a ghost, meaning that you can go through everthing but\n" +
                            "also wont be able to pick anything up.\n" +
                            "You cannont go through walls";
                        break;
                    }
                case "Food":
                    {
                        title = "The Food";
                        message = "Your classic Snek Food.\n" +
                            "If you pick it you will grow.";
                        break;
                    }
                case "Obstacle":
                    {
                        title = "The Obstacle";
                        message = "If you hit one of these fuckers, you are\n" +
                            "probably not living for much longer.";
                        break;
                    }
            }
            if(!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(title))
            {
                using (var dmsg = new DarkMessageBox(message, title)
                {
                    Parent = ParentForm,
                    StartPosition = FormStartPosition.CenterParent
                })
                {
                    dmsg.ShowDialog();
                }
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
