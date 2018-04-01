using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
namespace hw2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int gameTime = 0;
        int score = 0;
        int enemynumber = 0;
        int killnumber = 0;
        System.Media.SoundPlayer backGroundMusic = new System.Media.SoundPlayer(Properties.Resources.Battle_Song);
        System.Media.SoundPlayer enemyDieMusic = new System.Media.SoundPlayer(Properties.Resources.explosion_12);
        System.Media.SoundPlayer shotMusic = new System.Media.SoundPlayer(Properties.Resources.LaserGun_7);
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            scoreLabel.Text = "Score : " + score;
            scoreLabel.BackColor = Color.Transparent;
            titleLabel.BackColor = Color.Transparent;
            backGroundMusic.PlayLooping();
        }

        //Game Start
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            startButton.Enabled = false;
            exitButton.Visible = false;
            exitButton.Enabled = false;
            titleLabel.Visible = false;
            this.Focus();
            bulletTimer.Start();
            gameTimer.Start();
            enemyTimer.Start();
            interactTimer.Start();
            this.Controls.Add(new Fighter(270, 650));
        }
        //Game over
        private void game_Over()
        {
            resetButton.Visible = true;
            resetButton.Enabled = true;
            exitButton.Visible = true;
            exitButton.Enabled = true;
            titleLabel.Visible = true;
            MessageBox.Show("Game over\r\n Your Score: " + score + "\r\n敵人數: " + enemynumber + "\r\n擊殺數: " + killnumber);

        }
        private void game_Win()
        {
            bulletTimer.Stop();
            gameTimer.Stop();
            enemyTimer.Stop();
            interactTimer.Stop();
            fighterDown.Stop();
            fighterLeft.Stop();
            fighterRight.Stop();
            fighterUp.Stop();
            shootTimer.Stop();

            resetButton.Visible = true;
            resetButton.Enabled = true;
            exitButton.Visible = true;
            exitButton.Enabled = true;
            titleLabel.Visible = true;
            MessageBox.Show("YOU WIN!!\r\n Your Score: " + score + "\r\n敵人數: " + enemynumber + "\r\n擊殺數: " + killnumber);
        }


        //reset
        private void resetButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            bulletTimer.Stop();
            gameTimer.Stop();
            enemyTimer.Stop();
            interactTimer.Stop();
            fighterDown.Stop();
            fighterLeft.Stop();
            fighterRight.Stop();
            fighterUp.Stop();
            shootTimer.Stop();
            gameTime = 0;

            this.Controls.Add(startButton);
            this.Controls.Add(exitButton);
            this.Controls.Add(resetButton);
            this.Controls.Add(titleLabel);
            this.Controls.Add(scoreLabel);

            score = 0;
            scoreLabel.Text = "Score : " + score;

            enemynumber = 0;
            killnumber = 0;


            startButton.Visible = true;
            startButton.Enabled = true;
            resetButton.Visible = false;
            resetButton.Enabled = false;
        }

        //Exit Game
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        // input of keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                fighterUp.Start();
            }
            else if (e.KeyCode == Keys.Down)
            {
                fighterDown.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                fighterLeft.Start();
            }
            else if (e.KeyCode == Keys.Right)
            {
                fighterRight.Start();
            }
            else if (e.KeyCode == Keys.Space)
            {
                shootTimer.Start();
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                fighterUp.Stop();
            }
            else if (e.KeyCode == Keys.Down)
            {
                fighterDown.Stop();
            }
            else if (e.KeyCode == Keys.Left)
            {
                fighterLeft.Stop();
            }
            else if (e.KeyCode == Keys.Right)
            {
                fighterRight.Stop();
            }
            else if (e.KeyCode == Keys.Space)
            {
                shootTimer.Stop();
            }
        }

        // the clock tick for player moving
        private void fighterRight_Tick(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("Fighter"))
            {
                Fighter temp = (Fighter)this.Controls.Find("Fighter", true)[0];
                temp.moveRight();
            }

        }
        private void fighterLeft_Tick(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("Fighter"))
            {
                Fighter temp = (Fighter)this.Controls.Find("Fighter", true)[0];
                temp.moveLeft();
            }

        }
        private void fighterUp_Tick(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("Fighter"))
            {
                Fighter temp = (Fighter)this.Controls.Find("Fighter", true)[0];
                temp.moveUp();
            }

        }
        private void fighterDown_Tick(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("Fighter"))
            {
                Fighter temp = (Fighter)this.Controls.Find("Fighter", true)[0];
                temp.moveDown();
            }
        }

        //Let bullet move
        private void bulletTimer_Tick(object sender, EventArgs e)
        {


            if (this.Controls.ContainsKey("PlayerBullet"))
            {
                for (int i = 0; i < this.Controls.Find("PlayerBullet", true).Length; ++i)
                {
                    ((Bullet)this.Controls.Find("PlayerBullet", true)[i]).moveUp();
                }
            }

            if (this.Controls.ContainsKey("EnemyBullet"))
            {
                for (int i = 0; i < this.Controls.Find("EnemyBullet", true).Length; ++i)
                {
                    ((Bullet)this.Controls.Find("EnemyBullet", true)[i]).moveUp();
                }
            }

        }

        //Player shoot Bullet
        private void shootTimer_Tick(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("Fighter"))
            {
                Fighter temp = (Fighter)this.Controls.Find("Fighter", true)[0];
                //shotMusic.Play();
                if (killnumber >= 50)
                {
                    this.Controls.Add(new PlayerBullet(temp.Location.X + 20, temp.Location.Y - 56, 0));
                    this.Controls.Add(new PlayerBullet(temp.Location.X + 20, temp.Location.Y - 56, 1));
                    this.Controls.Add(new PlayerBullet(temp.Location.X + 20, temp.Location.Y - 56, 2));
                }
                else
                    this.Controls.Add(new PlayerBullet(temp.Location.X + 20, temp.Location.Y - 56, 0));

            }
        }

        //Clock of game
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ++gameTime;
            if(gameTime == 3 || gameTime == 6 || gameTime == 9)
            {
                this.Controls.Add(new Octopus(530, -50));
                this.Controls.Add(new Octopus(480, -50));
                this.Controls.Add(new Octopus(430, -50));
                this.Controls.Add(new Octopus(380, -50));
                enemynumber += 4;
            }
            else if (gameTime == 12 || gameTime == 15 || gameTime == 18)
            {
                this.Controls.Add(new Octopus(0, -50));
                this.Controls.Add(new Octopus(50, -50));
                this.Controls.Add(new Octopus(100, -50));
                this.Controls.Add(new Octopus(150, -50));
                enemynumber += 4;
            }
            else if(gameTime == 20)
            {
                this.Controls.Add(new Plane(243, -50));
                enemynumber += 1;
            }
            else if(gameTime == 21)
            {
                this.Controls.Add(new Plane(293, -50));
                this.Controls.Add(new Plane(193, -50));
                enemynumber += 2;
            }
            else if (gameTime == 22)
            {
                this.Controls.Add(new Plane(343, -50));
                this.Controls.Add(new Plane(143, -50));
                enemynumber += 2;
            }
            else if(gameTime == 25)
            {
                this.Controls.Add(new Octopus(168, -50));
                this.Controls.Add(new Octopus(77, -50));
                enemynumber += 2;
            }
            else if (gameTime == 28)
            {
                this.Controls.Add(new Octopus(168, -50));
                this.Controls.Add(new Octopus(77, -50));
                enemynumber += 2;
            }
            else if (gameTime == 30)
            {
                this.Controls.Add(new Octopus(530, -50));
                this.Controls.Add(new Octopus(530, -100));
                this.Controls.Add(new Octopus(530, -150));
                this.Controls.Add(new Octopus(530, -200));
                enemynumber += 4;
            }
            else if (gameTime == 33)
            {
                this.Controls.Add(new Plane(0, -50));
                this.Controls.Add(new Plane(100, -50));
                this.Controls.Add(new Plane(200, -50));
                enemynumber += 3;
            }
            else if (gameTime == 35)
            {
                this.Controls.Add(new Octopus(530, -50));
                this.Controls.Add(new Octopus(530, -100));
                this.Controls.Add(new Octopus(530, -150));
                this.Controls.Add(new Octopus(530, -200));
                enemynumber += 4;
            }
            else if (gameTime == 37)
            {
                this.Controls.Add(new Plane(530, -50));
                this.Controls.Add(new Plane(430, -50));
                this.Controls.Add(new Plane(330, -50));
                enemynumber += 3;
            }
            else if (gameTime >= 40 && gameTime <= 50)
            {
                this.Controls.Add(new Octopus((gameTime - 40)*50, -50));
                this.Controls.Add(new Octopus((gameTime - 40) * 50, -100));
                this.Controls.Add(new Octopus((gameTime - 40) * 50, -150));
                enemynumber += 3;
            }
            else if(gameTime == 52)
            {
                this.Controls.Add(new Plane(243, -50));
                enemynumber += 1;
            }
            else if (gameTime == 53)
            {
                this.Controls.Add(new Plane(293, -50));
                this.Controls.Add(new Plane(193, -50));
                enemynumber += 2;
            }
            else if (gameTime == 54)
            {
                this.Controls.Add(new Plane(343, -50));
                this.Controls.Add(new Plane(143, -50));
                enemynumber += 2;
            }
            else if (gameTime == 55)
            {
                this.Controls.Add(new Plane(393, -50));
                this.Controls.Add(new Plane(93, -50));
                enemynumber += 2;
            }
            else if (gameTime == 56)
            {
                this.Controls.Add(new Plane(443, -50));
                this.Controls.Add(new Plane(43, -50));
                enemynumber += 2;
            }
            else if(gameTime > 56 && gameTime < 60)
            {
                this.Controls.Add(new Octopus(random.Next(535), -random.Next(50,201)));
                this.Controls.Add(new Octopus(random.Next(535), -random.Next(50, 201)));
                this.Controls.Add(new Octopus(random.Next(535), -random.Next(50, 201)));
                enemynumber += 3;
            }
            else if (gameTime == 60)
            {
                this.Controls.Add(new Boss1());
                ++enemynumber;
            }
                
        }

        // Enemy action
        private void enemyTimer_Tick(object sender, EventArgs e)
        {

            if (this.Controls.ContainsKey("Enemy"))
            {
                for (int i = 0; i < this.Controls.Find("Enemy", true).Length; ++i)
                {
                    ((Enemy)this.Controls.Find("Enemy", true)[i]).move();
                    if (((Enemy)this.Controls.Find("Enemy", true)[i]).attack())
                    {
                        if (((Enemy)this.Controls.Find("Enemy", true)[i]).getEnemyCode() == 2)
                            this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 20, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 50, 0));
                        else if (((Enemy)this.Controls.Find("Enemy", true)[i]).getEnemyCode() == 3)
                        {
                            if(random.Next(11) > 7)
                            {
                                this.Controls.Add(new Plane(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 170, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 50));
                                ++enemynumber;
                            }
                            else
                            {
                                this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 85, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 215, 0));
                                this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 265, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 215, 0));
                                this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 85, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 215, 1));
                                this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 265, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 215, 1));
                                this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 85, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 215, 2));
                                this.Controls.Add(new EnemyBullet(((Enemy)this.Controls.Find("Enemy", true)[i]).Left + 265, ((Enemy)this.Controls.Find("Enemy", true)[i]).Top + 215, 2));
                            }
                            
                            
                        }
                    }
                }
            }

        }

        //Interact of object
        private void interactTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Find("Enemy", true).Length; ++i)
            {
                for (int j = 0; j < this.Controls.Find("PlayerBullet", true).Length; ++j)
                {
                    if (((Enemy)this.Controls.Find("Enemy", true)[i]).Bounds.IntersectsWith(((Bullet)this.Controls.Find("PlayerBullet", true)[j]).Bounds))
                    {
                        this.Controls.Remove(this.Controls.Find("PlayerBullet", true)[j]);
                        ((Enemy)this.Controls.Find("Enemy", true)[i]).hurt();
                        score += 100;
                        scoreLabel.Text = "Score : " + score;
                    }
                    else if (((Bullet)this.Controls.Find("PlayerBullet", true)[j]).Top < -50)
                    {
                        this.Controls.Remove(this.Controls.Find("PlayerBullet", true)[j]);
                    }
                }
                if (this.Controls.ContainsKey("Fighter"))
                {
                    if ((((Enemy)this.Controls.Find("Enemy", true)[i]).Bounds.IntersectsWith(((Fighter)this.Controls.Find("Fighter", true)[0]).Bounds)))
                    {
                        this.Controls.Remove(this.Controls.Find("Fighter", true)[0]);
                        game_Over();
                    }
                }
                if (((Enemy)this.Controls.Find("Enemy", true)[i]).Top > 800)
                {
                    this.Controls.Remove(this.Controls.Find("Enemy", true)[i]);
                }
                else if (((Enemy)this.Controls.Find("Enemy", true)[i]).ifDead())
                {
                    //enemyDieMusic.Play();
                    if (((Enemy)this.Controls.Find("Enemy", true)[i]).getEnemyCode() == 3)
                    {
                        this.Controls.Remove(this.Controls.Find("Enemy", true)[i]);
                        ++killnumber;
                        game_Win();
                    }
                    else
                    {
                        this.Controls.Remove(this.Controls.Find("Enemy", true)[i]);
                        ++killnumber;
                    }

                }
            }

            for (int i = 0; i < this.Controls.Find("EnemyBullet", true).Length; ++i)
            {
                if (this.Controls.ContainsKey("Fighter"))
                {
                    if ((((Bullet)this.Controls.Find("EnemyBullet", true)[i]).Bounds.IntersectsWith(((Fighter)this.Controls.Find("Fighter", true)[0]).Bounds)))
                    {
                        //enemyDieMusic.Play();
                        this.Controls.Remove(this.Controls.Find("Fighter", true)[0]);
                        this.Controls.Remove(this.Controls.Find("EnemyBullet", true)[i]);
                        game_Over();
                    }
                }
                else if (((Bullet)this.Controls.Find("EnemyBullet", true)[i]).Top > 800)
                {
                    this.Controls.Remove(this.Controls.Find("EnemyBullet", true)[i]);
                }
            }
        }

    }
}
