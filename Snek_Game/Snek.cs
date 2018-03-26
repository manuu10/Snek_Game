﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace Snek_Game
{
    class Snek
    {
        class Segment
        {
            public Segment(Point loc,Color c)
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
                brd.DrawCell(Loc, col);
            }
        }

        public Snek(Point start)
        {
            nSegments.Add(new Segment(start,_headColor));
        }
    
        private readonly List<Segment> nSegments = new List<Segment>();
        private int dirX = 1;
        private int dirY;


        private readonly Color _headColor = Color.FromArgb(0,67,10);
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
    
        public void Draw(Board brd)
        {
            for (int i = nSegments.Count - 1; i >= 0; i--)
            {
                nSegments[i].Draw(brd);
            }
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
                dummyx = dirX;
                dummyy = dirY;
            }

            Point p = new Point(nSegments[index].Loc.X - dummyx, nSegments[index].Loc.Y - dummyy);
            nSegments.Add(new Segment(p,_bodyColors[index % _bodyColors.Length]));
        }
        public void SetDirection(int dx,int dy)
        {
            //Richtung ändern
            dirX = dx;
            dirY = dy;
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


        public void Update()
        {
            //von hinten nach vorne folgt jedes segment seinen vordermann
            for( int i = nSegments.Count-1; i > 0 ; i--)
            {
                nSegments[i].Follow(nSegments[i - 1]);
            }
            nSegments[0].Loc = new Point(nSegments[0].Loc.X + dirX, nSegments[0].Loc.Y + dirY);
        }

        

        public void GoThroughWalls(Board brd)
        { 
            ref var first = ref nSegments[0].Loc;
            if (first.X < 0) first.X = brd._fieldWidth-1;
            if (first.X > brd._fieldWidth-1) first.X = 0;
            if (first.Y < 0) first.Y = brd._fieldHeight-1;
            if (first.Y > brd._fieldHeight-1) first.Y = 0;
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
