using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snek_Game
{
    public static class Misc
    {
        public static readonly Bitmap gameOverBitmap = Snek_Game.Properties.Resources.GameOver;
        public static Rectangle RectFromCenter(Point center,int hWidth,int hHeight)
        {
            return new Rectangle(center.X - hWidth, center.Y - hHeight, hWidth * 2, hHeight * 2);
        }
    }
}
