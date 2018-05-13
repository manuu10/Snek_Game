using System.Drawing;

namespace Snek_Game
{
    public class Obstacle
    {
        public Obstacle(Point loc)
        {
            Loc = loc;
        }

        public readonly Point Loc;
        public readonly Color c = Color.Gray;
        public static readonly int score = 20;

        public void Draw(Board brd)
        {
            brd.DrawCell(Loc, c);
        }

        public void DrawGlowing(Board brd)
        {
            brd.DrawGlowingCell(Loc, c, c, 5, 255);
        }
    }
}