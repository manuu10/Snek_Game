using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class Form1
    {
        public Random Rnd = new Random();

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
        private int _snakeMovePeriodMax = 40;
        private int _snakeMovePeriodMaxMax = 50;
        private int _oldsnakeMovePeriodMax;
        private int _snakeMovePeriodMin = 6;
        private int _snakeMovePeriodMinMin = 3;
        private int _snakeSpeedUpPeriod;
        private int _snakeSpeedUpPeriodMax = 240;

        private int _powerUpSpawnPeriod;
        private int _powerUpSpawnPeriodMax = 720;
        private int _powerUpAmountMax = 10;

        private int _obstacleSpawnPeriod;
        private int _obstacleSpawnPeriodMax = 900;
        private int _obstacleAmountMax = 100;

        private int _bulletMovePeriod;
        private int _bulletMovePeriodMax = 5;


        private bool doubleMaFood;
        private bool invincible;

        private bool slow;
        private bool useSlowOrSpeed;
        private bool speedy;

        private bool canShootBullets;


    }
}
