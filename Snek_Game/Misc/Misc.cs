using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

namespace Snek_Game
{
    public static class Misc
    {
        private static Random rnd = new Random();

        public static readonly Bitmap gameOverBitmap = Snek_Game.Properties.Resources.GameOver;

        public static Rectangle RectFromCenter(Point center, int hWidth, int hHeight)
        {
            return new Rectangle(center.X - hWidth, center.Y - hHeight, hWidth * 2, hHeight * 2);
        }

            // Draw a rectangle in the indicated Rectangle
            // rounding the indicated corners.
            public static GraphicsPath MakeRoundedRect(
            RectangleF rect, float xradius, float yradius,
            bool round_ul, bool round_ur, bool round_lr, bool round_ll)
        {
            // Make a GraphicsPath to draw the rectangle.
            PointF point1, point2;
            GraphicsPath path = new GraphicsPath();

            // Upper left corner.
            if (round_ul)
            {
                RectangleF corner = new RectangleF(
                    rect.X, rect.Y,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 180, 90);
                point1 = new PointF(rect.X + xradius, rect.Y);
            }
            else point1 = new PointF(rect.X, rect.Y);

            // Top side.
            if (round_ur)
                point2 = new PointF(rect.Right - xradius, rect.Y);
            else
                point2 = new PointF(rect.Right, rect.Y);
            path.AddLine(point1, point2);

            // Upper right corner.
            if (round_ur)
            {
                RectangleF corner = new RectangleF(
                    rect.Right - 2 * xradius, rect.Y,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 270, 90);
                point1 = new PointF(rect.Right, rect.Y + yradius);
            }
            else point1 = new PointF(rect.Right, rect.Y);

            // Right side.
            if (round_lr)
                point2 = new PointF(rect.Right, rect.Bottom - yradius);
            else
                point2 = new PointF(rect.Right, rect.Bottom);
            path.AddLine(point1, point2);

            // Lower right corner.
            if (round_lr)
            {
                RectangleF corner = new RectangleF(
                    rect.Right - 2 * xradius,
                    rect.Bottom - 2 * yradius,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 0, 90);
                point1 = new PointF(rect.Right - xradius, rect.Bottom);
            }
            else point1 = new PointF(rect.Right, rect.Bottom);

            // Bottom side.
            if (round_ll)
                point2 = new PointF(rect.X + xradius, rect.Bottom);
            else
                point2 = new PointF(rect.X, rect.Bottom);
            path.AddLine(point1, point2);

            // Lower left corner.
            if (round_ll)
            {
                RectangleF corner = new RectangleF(
                    rect.X, rect.Bottom - 2 * yradius,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 90, 90);
                point1 = new PointF(rect.X, rect.Bottom - yradius);
            }
            else point1 = new PointF(rect.X, rect.Bottom);

            // Left side.
            if (round_ul)
                point2 = new PointF(rect.X, rect.Y + yradius);
            else
                point2 = new PointF(rect.X, rect.Y);
            path.AddLine(point1, point2);

            // Join with the start point.
            path.CloseFigure();

            return path;
        }

        public static GraphicsPath MakeRoundedRect(RectangleF rect, float xradius, float yradius, bool All)
        {
            return MakeRoundedRect(rect, xradius, yradius, All, All, All, All); 
            
        }

        public static Color MakeRandomARGB(int alpha)
        {
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            return Color.FromArgb(alpha, red, green, blue);
        }

        public static Color MakeRandomRGB()
        {
            return MakeRandomARGB(255);
        }

        public static List<Score_info> GetScoreboard(string path)
        {
            List<Score_info> Scoreboard = new List<Score_info>();
            if (File.Exists(path))
            {
                try
                {
                    string line;
                    StreamReader sr = new StreamReader(path);
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] teile = line.Split(':');
                        string name = teile[0];
                        int score = Convert.ToInt32(teile[1]);
                        Scoreboard.Add(new Score_info(name, score));
                    }
                    sr.Dispose();
                }
                catch
                {
                    throw new FileLoadException("Could not load Scoreboard beacause of bad formatting", path);
                }
            }
            Scoreboard = Scoreboard.OrderByDescending(x => x.score).ToList();
            return Scoreboard;
        }
    }

    public class ManuProgressBar
    {
        public ManuProgressBar(Rectangle Region, int MaxValue)
        {
            maxval = MaxValue;
            region = Region;
            muliplier = (float)region.Size.Width / (float)maxval;
        }

        private int maxval;
        public readonly Rectangle region;
        private float muliplier;

        public void Draw(Graphics gfx, int currentval)
        {
            float width = muliplier * currentval;
            Size s = new Size((int)width, region.Size.Height);
            Rectangle rect = new Rectangle(region.Location, s);
            gfx.FillRectangle(Brushes.Green, rect);
            gfx.DrawRectangle(Pens.White, region);
        }
    }

    public class Score_info
    {
        public string name;
        public int score;

        public Score_info(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    public static class Directions
    {
        public static Size up()
        {
            return new Size(0, -1);
        }

        public static Size down()
        {
            return new Size(0, 1);
        }

        public static Size left()
        {
            return new Size(-1, 0);
        }

        public static Size right()
        {
            return new Size(1, 0);
        }
    }
}