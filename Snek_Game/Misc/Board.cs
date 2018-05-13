using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Snek_Game
{
    public class Board
    {
        public Board(int w, int h, int maxw, int maxh)
        {
            _fieldWidth = w;
            _fieldHeight = h;
            offset_x = maxw / 2 - _fieldWidth * dimension / 2;
            offset_y = maxh / 2 - _fieldHeight * dimension / 2;
        }

        public Graphics gfx { get; set; }
        public const int dimension = 30;

        public readonly int _fieldWidth;
        public readonly int _fieldHeight;

        private const int Padding = 3;

        private readonly int offset_x;
        private readonly int offset_y;

        public void DrawCell(Point loc, Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            using (var solidBrush = new SolidBrush(c))
            {
                gfx.FillRectangle(solidBrush, rect);
            }
        }
        public void DrawMultipleCells(Point[] pts, Color c)
        {
            var unitedregion = new Region();
            unitedregion.MakeEmpty();
            for (int i = 0; i < pts.Length; i++)
            {
                Point loc = pts[i];
                Rectangle hori = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);
                Rectangle verti = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);
                bool hoti = false ;
                bool veti = false;
                if(i != 0)
                {
                    var prv = pts[i - 1];
                    if(loc.X > prv.X)
                    {
                        hori.Location = Point.Subtract(hori.Location, new Size(Padding, 0));
                        hori.Size += new Size(Padding, 0);
                        hoti = true;
                    }
                    else if( loc.X < prv.X)
                    {
                        hori.Size += new Size(Padding, 0);
                        hoti = true;
                    }
                    else if( loc.Y > prv.Y)
                    {
                        verti.Location = Point.Subtract(verti.Location, new Size(0, Padding));
                        verti.Size += new Size(0, Padding);
                        veti = true;
                    }
                    else if(loc.Y < prv.Y)
                    {
                        verti.Size += new Size(0, Padding);
                        veti = true;
                    }
                }
                if(i != pts.Length-1)
                {
                    var prv = pts[i + 1];
                    if (loc.X > prv.X)
                    {
                        hori.Location = Point.Subtract(hori.Location, new Size(Padding, 0));
                        hori.Size += new Size(Padding, 0);
                        hoti = true;
                    }
                    else if (loc.X < prv.X)
                    {
                        hori.Size += new Size(Padding, 0);
                        hoti = true;
                    }
                    else if (loc.Y > prv.Y)
                    {
                        verti.Location = Point.Subtract(verti.Location, new Size(0, Padding));
                        verti.Size += new Size(0, Padding);
                        veti = true;
                    }
                    else if (loc.Y < prv.Y)
                    {
                        verti.Size += new Size(0, Padding);
                        veti = true;
                    }
                }

                
                if(hoti)unitedregion.Union(hori);
                if(veti)unitedregion.Union(verti);
            }

            using (var solidBrush = new SolidBrush(c))
            {
                gfx.FillRegion(solidBrush, unitedregion);
            }


        }
        public void DrawCellOutlined(Point loc, Color cellColor, Color outlineColor)
        {
            DrawCell(loc, cellColor);

            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            using (var pen = new Pen(outlineColor, 2))
            {
                gfx.DrawRectangle(pen, rect);
            }
        }
        public void DrawGlowingCell(Point loc, Color cellColor, Color glowColor, int size, int opacity)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();
            for (int i = 0; i < dimension / 2 + size; i++)
            {
                rects.Add(Misc.RectFromCenter(center, i, i));
            }

            //draw all rectangles from the very outer to the most inner
            for (int i = rects.Count - 1; i >= 0; i--)
            {
                float test = opacity / (float)rects.Count;
                float alpha = opacity - ((i + 1) * test);
                glowColor = Color.FromArgb((int)alpha, glowColor.R, glowColor.G, glowColor.B);
                Brush b = new SolidBrush(glowColor);
                gfx.FillRectangle(b, rects[i]);
                b.Dispose();
            }
            DrawCellOutlined(loc, cellColor, Color.Black);
        }

        public void DrawRoundCell(Point loc, Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            using (var solidBrush = new SolidBrush(c))
            {
                gfx.FillEllipse(solidBrush, rect);
            }
        }
        public void DrawRoundCellOutlined(Point loc, Color cellColor, Color outlineColor)
        {
            DrawRoundCell(loc, cellColor);

            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            using (var pen = new Pen(outlineColor, 2))
            {
                gfx.DrawEllipse(pen, rect);
            }
        }
        public void DrawRoundGlowingCell(Point loc, Color cellColor, Color glowColor, int size, int opacity)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();
            for (int i = 0; i < dimension / 2 + size; i++)
            {
                rects.Add(Misc.RectFromCenter(center, i, i));
            }

            //draw all rectangles from the very outer to the most inner
            for (int i = rects.Count - 1; i >= 0; i--)
            {
                float test = opacity / (float)rects.Count;
                float alpha = opacity - ((i + 1) * test);
                glowColor = Color.FromArgb((int)alpha, glowColor.R, glowColor.G, glowColor.B);
                Brush b = new SolidBrush(glowColor);
                gfx.FillEllipse(b, rects[i]);
                b.Dispose();
            }
            DrawRoundCellOutlined(loc, cellColor, Color.Black);
        }

        public void DrawRoundedRectCell(Point loc, Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            GraphicsPath gp = Misc.MakeRoundedRect(rect, 4, 4, true);
            using (var solidBrush = new SolidBrush(c))
            {
                gfx.FillPath(solidBrush, gp);
            }
        }
        public void DrawRoundedRectCellOutlined(Point loc, Color cellColor, Color outlineColor)
        {
            DrawRoundedRectCell(loc, cellColor);

            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            GraphicsPath gp = Misc.MakeRoundedRect(rect, 4, 4, true);

            using (var pen = new Pen(outlineColor, 2))
            {
                gfx.DrawPath(pen, gp);
            }
        }
        public void DrawRoundedRectGlowingCell(Point loc, Color cellColor, Color glowColor, int size, int opacity)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);

            List<GraphicsPath> rects = new List<GraphicsPath>();
            for (int i = 0; i < dimension / 2 + size; i++)
            {
                var rect = Misc.RectFromCenter(center, i, i);
                GraphicsPath gp = Misc.MakeRoundedRect(rect, 8, 8, true);
                rects.Add(gp);
            }
            //draw all rectangles from the very outer to the most inner
            for (int i = rects.Count - 1; i >= 0; i--)
            {
                float test = opacity / (float)rects.Count;
                float alpha = opacity - ((i + 1) * test);
                glowColor = Color.FromArgb((int)alpha, glowColor.R, glowColor.G, glowColor.B);
                Brush b = new SolidBrush(glowColor);
                gfx.FillPath(b, rects[i]);
                b.Dispose();
            }

            DrawRoundedRectCellOutlined(loc, cellColor, Color.Black);
        }

        public void DrawBullet(Point loc, Color c, Size dir)
        {
            Rectangle rect = new Rectangle();
            if (dir.Width == 0)
            {
                rect = new Rectangle(loc.X * dimension + Padding + offset_x + dimension / 3, loc.Y * dimension + Padding + offset_y, dimension / 3 - Padding * 2, dimension - Padding * 2);
            }

            if (dir.Height == 0)
            {
                rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y + dimension / 3, dimension - Padding * 2, dimension / 3 - Padding * 2);
            }
            using (var solidBrush = new SolidBrush(c))
            {
                gfx.FillRectangle(solidBrush, rect);
            }
        }

        public void DrawBulletGlowing(Point loc, Color cellColor, Size dir, Color glowColor, int size, int opacity)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();

            if (dir.Width == 0)
            {
                //rect = new Rectangle(loc.X * dimension + Padding + offset_x + dimension / 3, loc.Y * dimension + Padding + offset_y, dimension / 3 - Padding * 2, dimension - Padding * 2);

                for (int i = 0; i < dimension / 2 + size; i++)
                {
                    rects.Add(Misc.RectFromCenter(center, i / 3, i));
                }
            }

            if (dir.Height == 0)
            {
                //rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y + dimension / 3, dimension - Padding * 2, dimension / 3 - Padding * 2);

                for (int i = 0; i < dimension / 2 + size; i++)
                {
                    rects.Add(Misc.RectFromCenter(center, i, i / 3));
                }
            }

            //draw all rectangles from the very outer to the most inner
            for (int i = rects.Count - 1; i >= 0; i--)
            {
                float test = opacity / (float)rects.Count;
                float alpha = opacity - ((i + 1) * test);
                glowColor = Color.FromArgb((int)alpha, glowColor.R, glowColor.G, glowColor.B);
                Brush b = new SolidBrush(glowColor);
                gfx.FillRectangle(b, rects[i]);
                b.Dispose();
            }
            DrawBullet(loc, cellColor, dir);
        }

        public void DrawBorders()
        {
            using (var pen = new Pen(Color.DarkSlateGray, 4))
            {
                gfx.DrawRectangle(pen, offset_x, offset_y, _fieldWidth * dimension, _fieldHeight * dimension);
            }
        }

        public void DrawGrid()
        {
            Color c = Color.FromArgb(100, Color.White);
            Pen p = new Pen(c);

            for (int x = 0; x < _fieldWidth; x++)
            {
                gfx.DrawLine(p, x * dimension + offset_x, offset_y, x * dimension + offset_x, _fieldHeight * dimension + offset_y);
            }
            for (int y = 0; y < _fieldHeight; y++)
            {
                gfx.DrawLine(p, offset_x, y * dimension + offset_y, _fieldWidth * dimension + offset_x, y * dimension + offset_y);
            }
        }

        public void DrawGameOver()
        {
            gfx.DrawImage(Misc.gameOverBitmap, offset_x + Padding * 3, offset_y + Padding * 3, _fieldWidth * dimension - Padding * 6, _fieldHeight * dimension - Padding * 6);
        }

        public bool IsInsideBoard(Point loc)
        {
            return loc.X >= 0 &&
                   loc.X < _fieldWidth &&
                   loc.Y >= 0 &&
                   loc.Y < _fieldHeight;
        }


    }
}