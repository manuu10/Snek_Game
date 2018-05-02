using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Snek_Game
{
    class Board
    {
        public Board(int w,int h, int maxw,int maxh)
        {
            _fieldWidth = w;
            _fieldHeight = h;
            offset_x = maxw / 2 - _fieldWidth * dimension / 2;
            offset_y = maxh / 2 - _fieldHeight * dimension / 2;
        }

        public bool IsInsideBoard(Point loc)
        {
            return loc.X >= 0 &&
                   loc.X < _fieldWidth &&
                   loc.Y >= 0 &&
                   loc.Y < _fieldHeight;
        }

        public void DrawCell(Point loc,Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);
            
            gfx.FillRectangle(new SolidBrush(c), rect);
        }
        public void DrawGlowingCell(Point loc,Color cellColor,Color glowColor,int size,int opacity)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();
            for (int i = 0; i < dimension/2 + size; i++)
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
            }
            DrawCell(loc, cellColor);
        }

        public void DrawRoundCell(Point loc, Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            gfx.FillEllipse(new SolidBrush(c), rect);
            
        }
        public void DrawRoundGlowingCell(Point loc, Color cellColor, Color glowColor, int size,int opacity)
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
            }
            DrawRoundCell(loc, cellColor);
        }

        public void DrawRoundedRectCell(Point loc,Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            GraphicsPath gp = Misc.MakeRoundedRect(rect, 4, 4, true);
            gfx.FillPath(new SolidBrush(c), gp);
        }
        public void DrawRoundedRectGlowingCell(Point loc, Color cellColor, Color glowColor, int size,int opacity)
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
            }

            DrawRoundedRectCell(loc, cellColor);
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
            gfx.FillRectangle(new SolidBrush(c),rect );
            
        }
        public void DrawBulletGlowing(Point loc, Color cellColor, Size dir, Color glowColor, int size, int opacity)
        {
            Rectangle rect = new Rectangle();
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();

            if (dir.Width == 0)
            {
                //rect = new Rectangle(loc.X * dimension + Padding + offset_x + dimension / 3, loc.Y * dimension + Padding + offset_y, dimension / 3 - Padding * 2, dimension - Padding * 2);
                
                for (int i = 0; i < dimension / 2 + size; i++)
                {
                    rects.Add(Misc.RectFromCenter(center, i/3, i));
                }
            }

            if (dir.Height == 0)
            {
                //rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y + dimension / 3, dimension - Padding * 2, dimension / 3 - Padding * 2);
              
                for (int i = 0; i < dimension / 2 + size; i++)
                {
                    rects.Add(Misc.RectFromCenter(center, i, i/3));
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
            }
            DrawBullet(loc, cellColor, dir);

        }

        public void DrawBorders()
        {
            gfx.DrawRectangle(new Pen(Color.DarkSlateGray,4), offset_x,offset_y,_fieldWidth*dimension,_fieldHeight*dimension);
        }
        public void DrawGrid()
        {
            Color c = Color.FromArgb(100, Color.White);
            Pen p = new Pen(c);

            for (int x = 0; x < _fieldWidth; x++)
            {
                gfx.DrawLine(p, x * dimension + offset_x,offset_y, x * dimension + offset_x, _fieldHeight * dimension + offset_y);
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

        public Graphics gfx { get; set; }
        public int dimension = 30;

        public readonly int _fieldWidth;
        public readonly int _fieldHeight;

        private const int Padding = 3;

        private readonly int offset_x;
        private readonly int offset_y;

        

    }
}
