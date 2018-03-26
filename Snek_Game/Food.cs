using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Snek_Game
{
    class Food
    {
        public Food(Point loc)
        {
            Loc = loc;
        }
        public readonly Point Loc;

        public readonly Color c = Color.IndianRed;
        public void Draw(Board brd)
        {
            brd.DrawRoundCell(Loc,c);
        }
    }
}
