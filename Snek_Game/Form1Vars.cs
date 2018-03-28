using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snek_Game
{
    public partial class Form1
    {
        public Random Rnd = new Random();

        private readonly Point startLocation = new Point(8,1);
        private Snek snakeSnek;
        private Food snakeFood;
        private Board brd;
        private List<Bonus> _bonuses;
        private List<Obstacle> _obstacles;
        private List<Bullet> _bullets;

        private bool _gameOver;
        private const int widht = 50;
        private const int height = 25;
       
        private int _snakeMovePeriod;
        private int _snakeMovePeriodMax = 40; // changes over time, snake starts with that speed
        private int _snakeMovePeriodMaxMax = 50; // the speed that the snake is getting with the slow powerup
        private int _oldsnakeMovePeriodMax; // stores the current speed when slow or speedy is picked up
        private int _snakeMovePeriodMin = 6; // normal speedup wont pass this value
        private int _snakeMovePeriodMinMin = 3; // speed when speedy powerup is active
        private int _snakeSpeedUpPeriod;
        private int _snakeSpeedUpPeriodMax = 240; // time for the snake to speed up

        private int _powerUpSpawnPeriod;
        private int _powerUpSpawnPeriodMax = 720; // time for powerups to spawn
        private int _powerUpAmountMax = 10;

        private int _obstacleSpawnPeriod;
        private int _obstacleSpawnPeriodMax = 900; // time for obstacles to spawn
        private int _obstacleAmountMax = 100;

        private int _bulletMovePeriod;
        private int _bulletMovePeriodMax = 5; // speed for the bullets


        private bool doubleMaFood;
        private bool invincible;

        private bool slow;
        private bool useSlowOrSpeed;
        private bool speedy;

        private bool canShootBullets;


    }
}
