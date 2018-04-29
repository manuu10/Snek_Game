﻿using System.Drawing;
using System.Collections.Generic;

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
        public void DrawGlowingCell(Point loc,Color Cellcolor,Color glowColor,int size)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();
            for (int i = 0; i < dimension/2 + size; i++)
            {
                rects.Add(Misc.RectFromCenter(center, i, i));
            }

            for (int i = 0; i < rects.Count; i++)
            {
                gfx.DrawRectangle(new Pen(glowColor), rects[i]);
                int alpha = 255 - ((255 / (rects.Count + 1)) * (i + 1));
                glowColor = Color.FromArgb(alpha, glowColor);
            }
            DrawCell(loc, Cellcolor);
        }
        public void DrawRoundCell(Point loc, Color c)
        {
            Rectangle rect = new Rectangle(loc.X * dimension + Padding + offset_x, loc.Y * dimension + Padding + offset_y, dimension - Padding * 2, dimension - Padding * 2);

            gfx.FillEllipse(new SolidBrush(c), rect);
            
        }
        public void DrawRoundGlowingCell(Point loc, Color Cellcolor, Color glowColor, int size)
        {
            Point center = new Point(loc.X * dimension + dimension / 2 + offset_x, loc.Y * dimension + dimension / 2 + offset_y);
            List<Rectangle> rects = new List<Rectangle>();
            for (int i = 0; i < dimension / 2 + size; i++)
            {
                rects.Add(Misc.RectFromCenter(center, i, i));
            }

            for (int i = 0; i < rects.Count; i++)
            {
                gfx.DrawEllipse(new Pen(glowColor), rects[i]);
                int alpha = 255 - ((255 / (rects.Count + 1)) * (i + 1));
                glowColor = Color.FromArgb(alpha, glowColor);
            }
            DrawRoundCell(loc, Cellcolor);
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
        public int dimension = 26;

        public readonly int _fieldWidth;
        public readonly int _fieldHeight;

        private const int Padding = 3;

        private readonly int offset_x;
        private readonly int offset_y;

        

    }
}
