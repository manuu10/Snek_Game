﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Snek_Game
{
    public partial class Form1
    {
        public void InitMyShit()
        {
            brd = new Board(widht, height, pbGameCanvas.Width, pbGameCanvas.Height);
            snakeSnek = new Snek(startLocation);
            snakeFood = new Food(new Point(Rnd.Next(0, widht), Rnd.Next(0, height)));
            _bonuses = new List<Bonus>();
            _obstacles = new List<Obstacle>();
            _bullets = new List<Bullet>();

            joysticks = mJoy.GetSticks();
            manuProgress = new ManuProgressBar[]
            {
                new ManuProgressBar(new Rectangle(lbl_info_invincible.Left,lbl_info_invincible.Bottom + 3,70,10),Bonus.durationsMax[(int)Bonus.PowerUps.Invincible]),
                new ManuProgressBar(new Rectangle(lbl_info_doubleFood.Left,lbl_info_doubleFood.Bottom + 3,70,10),Bonus.durationsMax[(int)Bonus.PowerUps.DoubleFood]),
                new ManuProgressBar(new Rectangle(lbl_info_slow.Left,lbl_info_slow.Bottom + 3,70,10),Bonus.durationsMax[(int)Bonus.PowerUps.Slow]),
                new ManuProgressBar(new Rectangle(lbl_info_speedy.Left,lbl_info_speedy.Bottom + 3,70,10),Bonus.durationsMax[(int)Bonus.PowerUps.Speedy]),
                new ManuProgressBar(new Rectangle(lbl_info_bullets.Left,lbl_info_bullets.Bottom + 3,70,10),Bonus.durationsMax[(int)Bonus.PowerUps.Bullets])
            };

            _currentscore = 0;

            UpdLabelSpeed();
            UpdLabelLength();
            tmr_Game.Interval = 1;
            tmr_Draw.Interval = 1;
            tmr_grpboxpaint.Interval = 10;
            tmr_grpboxpaint.Start();
            tmr_Draw.Start();
        }


        private void UpdateModel()
        {
            HandleJoystickInput();
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
                    if (doubleMaFood) snakeSnek.AddSegment();
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
                        if (_bonuses[i].GetPowerUpType() == (int)Bonus.PowerUps.Slow) useSlowOrSpeed = true;
                        if (_bonuses[i].GetPowerUpType() == (int)Bonus.PowerUps.Speedy) useSlowOrSpeed = false;
                    }

                    // apply shit for while Bonus is active
                    if (_bonuses[i].IsStarted())
                    {
                        switch (_bonuses[i].GetPowerUpType())
                        {
                            case (int)Bonus.PowerUps.Invincible:
                                {
                                    snakeSnek.ApplyRainbowEffect();
                                    invincible = true;
                                    break;
                                }
                            case (int)Bonus.PowerUps.DoubleFood:
                                {
                                    doubleMaFood = true;
                                    break;
                                }
                            case (int)Bonus.PowerUps.Slow:
                                {
                                    if (useSlowOrSpeed)
                                    {
                                        if (!slow && !speedy)
                                        {
                                            _oldsnakeMovePeriodMax = _snakeMovePeriodMax;
                                        }
                                        _snakeMovePeriodMax = _snakeMovePeriodMaxMax - 1;
                                        slow = true;
                                        speedy = false;
                                    }

                                    break;
                                }
                            case (int)Bonus.PowerUps.Speedy:
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
                            case (int)Bonus.PowerUps.Bullets:
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
                        switch (_bonuses[i].GetPowerUpType())
                        {
                            case (int)Bonus.PowerUps.Invincible:
                                {
                                    snakeSnek.ApplyStandardColors();
                                    invincible = false;
                                    break;
                                }
                            case (int)Bonus.PowerUps.DoubleFood:
                                {
                                    doubleMaFood = false;
                                    break;
                                }
                            case (int)Bonus.PowerUps.Slow:
                                {
                                    slow = false;
                                    _snakeMovePeriodMax = _oldsnakeMovePeriodMax;
                                    break;
                                }
                            case (int)Bonus.PowerUps.Speedy:
                                {
                                    speedy = false;
                                    _snakeMovePeriodMax = _oldsnakeMovePeriodMax;
                                    break;
                                }
                            case (int)Bonus.PowerUps.Bullets:
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

                        Bonus.PowerUps pow = (Bonus.PowerUps)randPow;

                        Point rPoint;
                        do { rPoint = new Point(Rnd.Next(0, widht), Rnd.Next(0, height)); }
                        while (CheckIfTileIsUsed(rPoint));
                        _bonuses.Add(new Bonus(rPoint, pow));
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
            else
            {
                btn_stop.PerformClick();
                var gw = new GameOverForm(_currentscore)
                {
                    Parent = ParentForm,
                    StartPosition = FormStartPosition.CenterParent
                };
                gw.ShowDialog();
                btn_reset.PerformClick();
            }
        }

        private void DrawingModel(Graphics gfx)
        {
            brd.gfx = gfx;
            if (!_gameOver)
            {
                #region Draw Entities
                if (!glowing)
                {
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
                }
                else
                {
                    snakeFood.DrawGlowing(brd,Color.LightGreen);
                    foreach (var b in _bonuses)
                    {
                        b.DrawGlowing(brd);
                    }

                    foreach (var o in _obstacles)
                    {
                        o.DrawGlowing(brd);
                    }

                    foreach (var b in _bullets)
                    {
                        b.DrawGlowing(brd);
                    }
                    snakeSnek.DrawGlowing(brd,Color.White);
                }
                #endregion
            }

            else
            {
                brd.DrawGameOver();
            }
            if (chk_toggleGrid.Checked) brd.DrawGrid();
            brd.DrawBorders();

            #region Information GroupBox Visuals
            UpdLabelSpeed();
            UpdLabelLength();
            UpdLabelObstacle();
            lbl_info_doubleFood.ForeColor = doubleMaFood ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_invincible.ForeColor = invincible ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_slow.ForeColor = slow ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_speedy.ForeColor = speedy ? Color.MediumSeaGreen : grpBox_info.ForeColor;
            lbl_info_bullets.ForeColor = canShootBullets ? Color.MediumSeaGreen : grpBox_info.ForeColor;


            
            #endregion
        }

        private void GroupBoxPainting(Graphics gfx)
        {
            for (int i = 0; i < manuProgress.Length; i++)
            {
                if (_bonuses.Count != 0)
                {
                    var erg = _bonuses.FindAll(x =>
                             x.GetPowerUpType() == i &&
                             x.IsStarted() &&
                            !x.CanBeDeleted()
                        ).OrderBy(x => x.duration).FirstOrDefault();

                    if (erg != null)
                    {
                        manuProgress[i].Draw(gfx, erg.duration);
                    }
                }
            }
        }


        private bool CheckIfTileIsUsed(Point loc)
        {
            foreach (var b in _bonuses)
            {
                if (!b.IsStarted())
                { if (b.loc == loc) return true; }
            }

            foreach (var o in _obstacles)
            {
                if (o.Loc == loc) return true;
            }

            if (snakeFood.Loc == loc) return true;

            if (snakeSnek.IsInsideSnake(loc)) return true;

            return false;
        }

        private void HandleJoystickInput()
        {
            for (int i = 0; i < joysticks.Length; i++)
            {
                mJoy.stickHandle(joysticks[i], i);
                if (!_gameOver)
                {
                    if (mJoy.buttons[0])
                    {
                        snakeSnek.SetDirection(new Size(0, 1));
                    }

                    if (mJoy.buttons[1])
                    {
                        snakeSnek.SetDirection(new Size(1, 0));
                    }

                    if (mJoy.buttons[2])
                    {
                        snakeSnek.SetDirection(new Size(-1, 0));
                    }

                    if (mJoy.buttons[3])
                    {
                        snakeSnek.SetDirection(new Size(0, -1));
                    }

                    if (mJoy.buttons[4])
                    {
                        snakeSnek.AddSegment();
                    }

                    if (mJoy.buttons[5] && canShootBullets)
                    {
                        _bullets.Add(new Bullet(snakeSnek.GetHeadLocation(), snakeSnek.GetSnakeDirection()));
                    }
                }

                if (mJoy.buttons[6])
                {
                    btn_Help.PerformClick();
                }
                if (mJoy.buttons[7])
                {
                    btn_reset.PerformClick();
                    btn_start.PerformClick();
                }
            }
        }
    }
}
