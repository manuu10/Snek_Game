using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Snek_Game
{
    class Bullet
    {
        public Bullet(Point loc, Size dir)
        {
            Loc = loc;
            Dir = dir;
        }
        private Size Dir;
        public Point Loc;
        public Color c = Color.OrangeRed;
        public void Update()
        {
            Loc = Point.Add(Loc, Dir);
        }

        public void Draw(Board brd)
        {
            brd.DrawBullet(Loc, c, Dir);
        }

        public bool HitObject(Point loc)
        {
            if (loc == Loc) return true;
            return false;
        }

    }
}
