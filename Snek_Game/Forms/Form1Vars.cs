using System;
using System.Collections.Generic;
using System.Drawing;
using SlimDX.DirectInput;

namespace Snek_Game
{
    public partial class Form1
    {
        public ManuInput mJoy = new ManuInput();
        public Joystick[] joysticks;
        public Random Rnd = new Random();

        private readonly Point startLocation = new Point(8,1);

        private ManuProgressBar[] manuProgress;

        private bool _gameOver;
        private const int widht = 44;
        private const int height = 24;


        #region entities
        private Snek snakeSnek;
        private Food snakeFood;
        private Board brd;
        private List<Bonus> _bonuses;
        private List<Obstacle> _obstacles;
        private List<Bullet> _bullets;
        #endregion

        #region speed etc.
        private int _snakeMovePeriod;
        public int _snakeMovePeriodStart = 40;
        private int _snakeMovePeriodMax = 0; // changes over time, snake starts with that speed
        public int _snakeMovePeriodMaxMax = 50; // the speed that the snake is getting with the slow powerup
        private int _oldsnakeMovePeriodMax; // stores the current speed when slow or speedy is picked up
        public int _snakeMovePeriodMin = 6; // normal speedup wont pass this value
        public int _snakeMovePeriodMinMin = 3; // speed when speedy powerup is active
        private int _snakeSpeedUpPeriod;
        public int _snakeSpeedUpPeriodMax = 240; // time for the snake to speed up

        private int _powerUpSpawnPeriod;
        public int _powerUpSpawnPeriodMax = 720; // time for powerups to spawn
        public int _powerUpAmountMax = 10;

        private int _obstacleSpawnPeriod;
        public int _obstacleSpawnPeriodMax = 900; // time for obstacles to spawn
        public int _obstacleAmountMax = 100;

        private int _bulletMovePeriod;
        private int _bulletMovePeriodMax = 5; // speed for the bullets
        #endregion

        #region powerUps
        private bool doubleMaFood;
        private bool invincible;

        private bool slow;
        private bool useSlowOrSpeed;
        private bool speedy;

        private bool canShootBullets;
        #endregion

        #region other settings
        public bool glowing;
        #endregion

    }
}
