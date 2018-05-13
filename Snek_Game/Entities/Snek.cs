using System.Collections.Generic;
using System.Drawing;

namespace Snek_Game
{
    public class Snek
    {
        private class Segment
        {
            public Segment(Point loc, Color c)
            {
                Loc = loc;
                col = c;
            }

            public Point Loc;
            public Color col;

            public void Follow(Segment seg)
            {
                Loc = seg.Loc;
            }

            public void Draw(Board brd)
            {
                brd.DrawRoundedRectCell(Loc, col);
            }

            public void DrawOutlined(Board brd, Color outlineColor)
            {
                brd.DrawRoundedRectCellOutlined(Loc, Color.Black, Color.Maroon);
            }

            public void DrawGlowing(Board brd, Color glowColor)
            {
                brd.DrawRoundedRectGlowingCell(Loc, col, glowColor, 7, 128);
            }

            public void DrawGlowingOutlined(Board brd, Color glowColor)
            {
                brd.DrawRoundedRectGlowingCell(Loc, Color.Black, glowColor, 8, 200);
            }
        }

        public Snek(Point start)
        {
            nSegments.Add(new Segment(start, _headColor));
            for (int i = 0; i < 6; i++)
            {
                AddSegment();
            }
        }

        private readonly List<Segment> nSegments = new List<Segment>();
        private Size dir = new Size(1, 0);

        private bool _ghosting = false;
        private readonly Color _headColor = Color.FromArgb(0, 67, 10);
        private readonly Color _ghostColor = Color.Maroon;
        private readonly Color[] _bodyColors =
        {
            Color.FromArgb(0,0,128),
            Color.FromArgb(17,30,108),
            Color.FromArgb(16,52,166),
            Color.FromArgb(14,77,146),
            Color.FromArgb(16,52,166),
            Color.FromArgb(17,30,108)
        };
        private readonly Color[] _bodyColorsRainbow =
        {
            Color.FromArgb(148,0,211),
            Color.FromArgb(75,0,130),
            Color.FromArgb(0,0,255),
            Color.FromArgb(0,255,0),
            Color.FromArgb(255,255,0),
            Color.FromArgb(255,127,0),
            Color.FromArgb(255,0,0)
        };

        public Point GetHeadLocation()
        {
            return nSegments[0].Loc;
        }
        public int GetSnakeLength()
        {
            return nSegments.Count;
        }
        public Size GetSnakeDirection()
        {
            return dir;
        }

        public void Draw(Board brd)
        {
            if (!_ghosting)
            {
                for (int i = nSegments.Count - 1; i >= 0; i--)
                {
                    nSegments[i].Draw(brd);
                }
            }
            else
            {
                DrawOutlined(brd, _ghostColor);
            }
        }
        public void DrawOutlined(Board brd, Color outlineColor)
        {
            for (int i = nSegments.Count - 1; i >= 0; i--)
            {
                nSegments[i].DrawOutlined(brd, outlineColor);
            }
        } 
        public void DrawGlowing(Board brd, Color glowColor)
        {
            if (_ghosting)
            {
                glowColor = _ghostColor;
                for (int i = nSegments.Count - 1; i >= 0; i--)
                {
                    nSegments[i].DrawGlowingOutlined(brd, glowColor);
                }
            }
            else
            {
                for (int i = nSegments.Count - 1; i >= 0; i--)
                {
                    nSegments[i].DrawGlowing(brd, glowColor);
                }
            }
        }

        public void DrawFull(Board brd)
        {
            var arr = new Point[nSegments.Count];
            for (int i = 0; i < nSegments.Count; i++)
            {
                arr[i] = nSegments[i].Loc;
            }
            brd.DrawMultipleCells(arr, Color.Maroon);
        }

        public void AddSegment()
        {
            int dummyx = 0;
            int dummyy = 0;
            int index = nSegments.Count - 1;
            if (nSegments.Count > 1)
            {
                //herausfinden wo das nächste segment angeknüpft werden soll
                // links rechts oben oder unten neben dem letzten segment
                Point dummyp = nSegments[index - 1].Loc;
                Point dummyp2 = nSegments[index].Loc;
                if (dummyp.X < dummyp2.X) dummyx = -1;
                else if (dummyp.X > dummyp2.X) dummyx = 1;

                if (dummyp.Y < dummyp2.Y) dummyy = -1;
                else if (dummyp.Y > dummyp2.Y) dummyy = 1;
            }
            else
            {
                dummyx = dir.Width;
                dummyy = dir.Height;
            }

            Point p = new Point(nSegments[index].Loc.X - dummyx, nSegments[index].Loc.Y - dummyy);
            nSegments.Add(new Segment(p, _bodyColors[index % _bodyColors.Length]));
        }
        public void SetDirection(Size newdir)
        {
            //Richtung ändern
            dir = newdir;
        }

        public void ApplyRainbowEffect()
        {
            for (int i = 1; i < nSegments.Count; i++)
            {
                nSegments[i].col = _bodyColorsRainbow[i % _bodyColorsRainbow.Length];
            }
        }
        public void ApplyStandardColors()
        {
            for (int i = 1; i < nSegments.Count; i++)
            {
                nSegments[i].col = _bodyColors[i % _bodyColors.Length];
            }
        }

        public void EnableGhostEffect()
        {
            _ghosting = true;
        }
        public void DisableGhostEffect()
        {
            _ghosting = false;
        }

        public void Update()
        {
            //von hinten nach vorne folgt jedes segment seinen vordermann
            for (int i = nSegments.Count - 1; i > 0; i--)
            {
                nSegments[i].Follow(nSegments[i - 1]);
            }

            nSegments[0].Loc = Point.Add(nSegments[0].Loc, dir);
        }

        public void GoThroughWalls(Board brd)
        {
            ref var first = ref nSegments[0].Loc;
            if (first.X < 0) first.X = brd._fieldWidth - 1;
            if (first.X > brd._fieldWidth - 1) first.X = 0;
            if (first.Y < 0) first.Y = brd._fieldHeight - 1;
            if (first.Y > brd._fieldHeight - 1) first.Y = 0;
        }
        public bool HitObject(Point p)
        {
            var first = nSegments[0].Loc;

            if (first == p) return true;
            return false;
        }
        public bool HitOwnBody()
        {
            for (var i = 1; i < nSegments.Count; i++)
            {
                if (HitObject(nSegments[i].Loc)) return true;
            }

            return false;
        }
        public bool IsInsideSnake(Point loc)
        {
            foreach (var seg in nSegments)
            {
                if (seg.Loc == loc) return true;
            }

            return false;
        }
    }
}