using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snek_Game
{
    class Obstacle
    {
        public Obstacle(Point loc)
        {
            Loc = loc;
        }
        public readonly Point Loc;
        public readonly Color c = Color.Gray;

        public void Draw(Board brd)
        {
            brd.DrawCell(Loc,c);
        }
    }
}
