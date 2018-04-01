using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace hw2
{
    class Boss1 : Enemy
    {
        public Boss1()
        {
            this.Location = new Point(200, -250);
            this.Image = Properties.Resources._90_1509161430410;
            this.Size = new Size(361, 215);
            this.Name = "Enemy";
            this.Visible = true;
            attackTime = 25;
            hp = 500;
            moveMode = 0;
        }
        public override void move()
        {
            --attackTime;
            if(this.Top <= 50)
            {
                this.Top += 1;
            }
            if(moveMode == 0)
            {
                this.Left += 1;
            }
            else
            {
                this.Left -= 1;
            }

            if(this.Left <= 10)
            {
                moveMode = 0;
            }
            else if(this.Left >= 165)
            {
                moveMode = 1;
            }

        }
        public override bool attack()
        {
            if(attackTime <= 0)
            {
                attackTime = 100;
                return true;
            }
            return false;
        }
        public override void hurt()
        {
            hp--;
        }
        public override bool ifDead()
        {
            if (hp <= 0)
                return true;
            return false;
        }
        public override int getEnemyCode()
        {
            return enemyCode;
        }

        public int attackTime;
        public int hp;
        private int moveMode;
        private const int enemyCode = 3;
    }
}
