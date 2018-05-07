﻿using System.Drawing;

namespace Snek_Game
{
    class Bonus
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
                brd.DrawRoundedRectCell(loc, colPallete[PowerUpType]);
            }
        }
        public void DrawGlowing(Board brd)
        {
            if (!_started)
            {
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
            Color.White         // Bullets
        };

        public static readonly int[] durationsMax =
        {
            400,    // Invincible
            500,    // DoubleFood
            300,    // Slow
            250,    // Speedy
            650     // Bullets
        };
        public enum PowerUps
        {
            Invincible,
            DoubleFood,
            Slow,
            Speedy,
            Bullets
        }
        #endregion  
    }
}