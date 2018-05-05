using System.Drawing;
using System.Collections.Generic;

namespace Snek_Game.Entities
{
    abstract class BonusRefactor
    {
       
        public abstract Color col { get; }
        public abstract int durationMax { get; }
        public abstract string BonusName { get; }
        public Point Loc { get; protected set; }
        public int duration { get; protected set; }
        public bool _started { get; protected set; }
        public bool _canBeDeleted { get; protected set; }
        public void StartTimer()
        {
            _started = true;
            duration = 0;
        }
        public void Update()
        {
            duration++;
            if (duration >= durationMax)
            {
                _started = false;
                _canBeDeleted = true;
            }
        }
        public void Draw(Board brd)
        {
            if (!_started)
            {
                brd.DrawRoundedRectCell(Loc, col);
            }
        }
        public void DrawGlowing(Board brd)
        {
            if (!_started)
            {
                brd.DrawRoundedRectGlowingCell(Loc, col, col, 5, 255);
            }
        }
    }

    class B_Invincible : BonusRefactor
    {
        public B_Invincible() { }

        public override Color col => Color.Magenta;

        public override int durationMax => 400;

        public override string BonusName => "Invincible";
    }
    class B_DoubleFood : BonusRefactor
    {
        public B_DoubleFood() { }

        public override Color col => Color.Yellow;

        public override int durationMax => 500;

        public override string BonusName => "DoubleFood";
    }
    class B_Slow : BonusRefactor
    {
        public B_Slow() { }

        public override Color col => Color.DeepSkyBlue;

        public override int durationMax => 300;

        public override string BonusName => "Slow";
    }
    class B_Speedy : BonusRefactor
    {
        public B_Speedy() { }

        public override Color col => Color.Red;

        public override int durationMax => 250;

        public override string BonusName => "Speedy";
    }
    class B_Bullets : BonusRefactor
    {
        public B_Bullets() { }

        public override Color col => Color.White;

        public override int durationMax => 650;

        public override string BonusName => "Bullets";
    }

    
}
