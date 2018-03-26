using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Snek_Game
{
    public partial class Form1
    {
        public void InitMyShit()
        {
            brd = new Board(widht, height, pbGameCanvas.Width, pbGameCanvas.Height);
            snakeSnek = new Snek(new Point(1, 1));
            snakeFood = new Food(new Point(Rnd.Next(0, widht), Rnd.Next(0, height)));
            _bonuses = new List<Bonus>();
            _obstacles = new List<Obstacle>();
            _bullets = new List<Bullet>();
            
            updLabelSpeed();
            updLabelLength();
            tmr_Game.Interval = 1;
            tmr_Draw.Interval = 1;
            tmr_Draw.Start();
        }

       

        private void UpdateModel()
        {
            if (!_gameOver)
            {
                // if snek is not invicible,
                // Game is rip if snek left board or hit itself
                if ((!brd.IsInsideBoard(snakeSnek.GetHeadLocation()) || snakeSnek.HitOwnBody()) && !invincible)
                {
                    _gameOver = true;
                }
                // check if snake hit an obstacle
                foreach (var o in _obstacles)
                {
                    if (snakeSnek.HitObject(o.Loc) && !invincible)
                    {
                        _gameOver = true;
                        break;
                    }
                    
                }
                // snake can go through walls if invicibility is active
                if (invincible)
                {
                    snakeSnek.GoThroughWalls(brd);
                }

                #region Collision Detection
                // Grow snake when food is hit
                // place Food at new unused location
                if (snakeSnek.HitObject(snakeFood.Loc))
                {
                    snakeSnek.AddSegment();
                    if(doubleMaFood) snakeSnek.AddSegment();
                    Point rPoint;
                    do { rPoint = new Point(Rnd.Next(0, widht), Rnd.Next(0, height)); }
                    while (CheckIfTileIsUsed(rPoint));
                    snakeFood = new Food(rPoint);
                }

                // collision detection for bullets -> obstacles
                for (var i = 0; i < _bullets.Count; i++)
                {
                    bool skip = false;
                    for (var j = 0; j < _obstacles.Count; j++)
                    {
                        var obstacle = _obstacles[j];
                        if (_bullets[i].HitObject(obstacle.Loc))
                        {
                            _obstacles.RemoveAt(j);
                            _bullets.RemoveAt(i);
                            skip = true;
                            break;
                        }
                    }

                    if (skip) continue;
                    if (!brd.IsInsideBoard(_bullets[i].Loc))
                        _bullets.RemoveAt(i);
                }
                #endregion

                #region Powerup Handling
                for (var i = 0; i < _bonuses.Count; i++)
                {
                    // if snake hit powerup and powerup isnt started yet, start powerups Timer 
                    if (snakeSnek.HitObject(_bonuses[i].loc) && !_bonuses[i].IsStarted())
                    {
                        _bonuses[i].StartTimer();
                        // decision for which to use when looping through the active
                        // bonuses based on the lastest object you hit
                        if (_bonuses[i].GetPowerupType() == (int) Bonus.Powerups.Slow) useSlowOrSpeed = true;
                        if (_bonuses[i].GetPowerupType() == (int) Bonus.Powerups.Speedy) useSlowOrSpeed = false;
                    }

                    // apply shit for while Bonus is active
                    if (_bonuses[i].IsStarted())
                    {
                        switch (_bonuses[i].GetPowerupType())
                        {
                            case (int)Bonus.Powerups.Invincible:
                            {
                                snakeSnek.ApplyRainbowEffect();
                                invincible = true;
                                break;
                            }
                            case (int)Bonus.Powerups.DoubleFood:
                            {
                                doubleMaFood = true;
                                break;
                            }
                            case (int)Bonus.Powerups.Slow:
                            {
                                if (useSlowOrSpeed)
                                {
                                    if (!slow && !speedy)
                                    {
                                        _oldsnakeMovePeriodMax = _snakeMovePeriodMax;
                                    }
                                    _snakeMovePeriodMax = _snakeMovePeriodMaxMax-1;
                                    slow = true;
                                    speedy = false;
                                }

                                break;
                            }
                            case (int)Bonus.Powerups.Speedy:
                            {
                                if (!useSlowOrSpeed)
                                {
                                    if (!speedy && !slow)
                                    {
                                        _oldsnakeMovePeriodMax = _snakeMovePeriodMax;
                                    }
                                    _snakeMovePeriodMax = _snakeMovePeriodMinMin;
                                    speedy = true;
                                    slow = false;
                                }

                                break;
                            }
                            case (int)Bonus.Powerups.Bullets:
                            {
                                canShootBullets = true;
                                break;
                            }
                        }
                        _bonuses[i].Update();
                    }

                    // remove shit if bonus ran out
                    if (_bonuses[i].CanBeDeleted())
                    {
                        switch (_bonuses[i].GetPowerupType())
                        {
                            case (int)Bonus.Powerups.Invincible:
                            {
                                snakeSnek.ApplyStandardColors();
                                invincible = false;
                                break;
                            }
                            case (int)Bonus.Powerups.DoubleFood:
                            {
                                doubleMaFood = false;
                                break;
                            }
                            case (int)Bonus.Powerups.Slow:
                            {
                                slow = false;
                                _snakeMovePeriodMax = _oldsnakeMovePeriodMax;
                                break;
                            }
                            case (int)Bonus.Powerups.Speedy:
                            {
                                speedy = false;
                                _snakeMovePeriodMax = _oldsnakeMovePeriodMax;
                                break;
                            }
                            case (int)Bonus.Powerups.Bullets:
                            {
                                canShootBullets = false;
                                break;
                            }
                        }
                        _bonuses.RemoveAt(i);
                    }
                }
                #endregion

                #region SpawnAndSpeed Handling
                _snakeMovePeriod++;
                if (_snakeMovePeriod >= _snakeMovePeriodMax)
                {
                    snakeSnek.Update();
                    _snakeMovePeriod = 0;
                }

                if (!slow && !speedy)
                {
                    _snakeSpeedUpPeriod++;
                    if (_snakeSpeedUpPeriod >= _snakeSpeedUpPeriodMax)
                    {
                        _snakeMovePeriodMax = Math.Max(_snakeMovePeriodMax - 1, _snakeMovePeriodMin);
                        _snakeSpeedUpPeriod = 0;
                    }
                }

                if (_bonuses.Count < _powerUpAmountMax)
                {
                    _powerUpSpawnPeriod++;
                    if (_powerUpSpawnPeriod >= _powerUpSpawnPeriodMax)
                    {
                        //every powerup has a 1 / 5 chance to spawn
                        int randPow = Rnd.Next(0, 1250);
                        randPow = randPow - randPow % 250;
                        randPow = randPow / 250;

                        Bonus.Powerups pow = (Bonus.Powerups) randPow;

                        Point rPoint;
                        do { rPoint = new Point(Rnd.Next(0, widht), Rnd.Next(0, height)); }
                        while (CheckIfTileIsUsed(rPoint));
                        _bonuses.Add(new Bonus(rPoint,pow));
                        _powerUpSpawnPeriod = 0;
                    }
                }

                if (_obstacles.Count < _obstacleAmountMax)
                {
                    _obstacleSpawnPeriod++;
                    if (_obstacleSpawnPeriod >= _obstacleSpawnPeriodMax)
                    {
                        Point rPoint;
                        do { rPoint = new Point(Rnd.Next(0, widht), Rnd.Next(0, height)); }
                        while (CheckIfTileIsUsed(rPoint));
                        _obstacles.Add(new Obstacle(rPoint));
                        _obstacleSpawnPeriod = 0;
                    }
                }

                _bulletMovePeriod++;
                if (_bulletMovePeriod >= _bulletMovePeriodMax)
                {
                    foreach (var bullet in _bullets)
                    {
                        bullet.Update();
                    }
                }
                #endregion

                
            }
        }

        private void DrawingModel(Graphics gfx)
        {
            brd.gfx = gfx;
            if (!_gameOver)
            {
                #region Draw Entities
                snakeFood.Draw(brd);
                foreach (var b in _bonuses)
                {
                    b.Draw(brd);
                }

                foreach (var o in _obstacles)
                {
                    o.Draw(brd);
                }

                foreach (var b in _bullets)
                {
                    b.Draw(brd);
                }
                snakeSnek.Draw(brd);
                #endregion
            }

            else
            {
                brd.DrawGameOver();
            }
            if (chk_toggleGrid.Checked) brd.DrawGrid();
            brd.DrawBorders();

            #region Information GroupBox Visuals
            updLabelSpeed();
            updLabelLength();
            updLabelObstacle();
            lbl_info_doubleFood.ForeColor = doubleMaFood ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_invincible.ForeColor = invincible ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_slow.ForeColor = slow ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_speedy.ForeColor = speedy ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_bullets.ForeColor = canShootBullets ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            #endregion
        }


        private bool CheckIfTileIsUsed(Point loc)
        {
            foreach (var b in _bonuses)
            {
                if(!b.IsStarted())
                { if (b.loc == loc) return true;}
            }

            foreach (var o in _obstacles)
            {
                if (o.Loc == loc) return true;
            }

            if (snakeFood.Loc == loc) return true;

            if (snakeSnek.IsInsideSnake(loc)) return true;

            return false;
        }

       
    }
}
