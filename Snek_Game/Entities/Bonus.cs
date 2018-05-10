using System.Drawing;

namespace Snek_Game
{
    public class Bonus
    {
        public Bonus(Point Loc, PowerUps pow)
        {
            loc = Loc;
            PowerUpType = (int)pow;
        }
        
        public readonly Point loc;
        private readonly int PowerUpType;
        public int duration { get; private set; }
        private bool _started;
        private bool _canBeDeleted;

        public bool IsStarted()
        {
            return _started;
        }
        public bool CanBeDeleted()
        {
            return _canBeDeleted;
        }

        public void StartTimer()
        {
            _started = true;
            duration = 0;
        }


        public void Update()
        {
            duration++;
            if (duration >= durationsMax[PowerUpType])
            {
                _started = false;
                _canBeDeleted = true;
            }
        }
        public void Draw(Board brd)
        {
            if (!_started)
            {
                if(PowerUpType == (int)PowerUps.Ghost)
                {
                    DrawGlowing(brd);
                    return;
                }
                brd.DrawRoundedRectCell(loc, colPallete[PowerUpType]);
            }
        }
        public void DrawGlowing(Board brd)
        {
            if (!_started)
            {
                if(PowerUpType == (int)PowerUps.Ghost)
                {
                    brd.DrawRoundedRectGlowingCell(loc, colPallete[PowerUpType], Color.White, 5, 255);
                    return;
                }
                brd.DrawRoundedRectGlowingCell(loc, colPallete[PowerUpType], colPallete[PowerUpType], 5, 255);
            }
        }
        public int GetPowerUpType()
        {
            return PowerUpType;
        }

        #region static Information about Powerups
        public static readonly Color[] colPallete =
        {
            Color.Magenta,      // Invincible
            Color.Yellow,       // DoubleFood
            Color.DeepSkyBlue,  // Slow
            Color.Red,          // Speedy
            Color.White,        // Bullets
            Color.Black         // Ghost

        };

        public static readonly int[] durationsMax =
        {
            400,    // Invincible
            500,    // DoubleFood
            300,    // Slow
            250,    // Speedy
            650,    // Bullets
            350     // Ghost
        };
        public static readonly int[] score =
        {
            10,    // Invincible
            5,     // DoubleFood
            15,    // Slow
            20,    // Speedy
            7,     // Bullets
            30     // Ghost
        };
        public enum PowerUps
        {
            Invincible,
            DoubleFood,
            Slow,
            Speedy,
            Bullets,
            Ghost
        }
        #endregion  
    }
}
