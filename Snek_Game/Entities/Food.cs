using System.Drawing;

namespace Snek_Game
{
    public class Food
    {
        public static readonly int score = 5;
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
        public void DrawGlowing(Board brd, Color glowColor)
        {
            brd.DrawRoundGlowingCell(Loc, c, glowColor, 8, 180);
        }
    }
}
