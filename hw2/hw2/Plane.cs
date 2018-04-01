using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hw2
{
    class Plane : Enemy
    {
        public Plane(int x, int y)
        {
            this.Location = new Point(x, y);
            this.Image = Properties.Resources.ship_1;
            this.Size = new Size(50, 50);
            this.Name = "Enemy";
            this.Visible = true;
            attackTime = 25;
            hp = 5;
        }

        public override void move()
        {
            this.Top += 1;
            attackTime--;
            this.BringToFront();
        }

        public override void hurt()
        {
            --hp;
        }

        public override bool attack()
        {
            if (attackTime <= 0)
            {
                attackTime = 125;
                return true;
            }
            return false;
        }

        public override bool ifDead()
        {
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }
        public override int getEnemyCode()
        {
            return enemyCode;
        }

        public int attackTime;
        public int hp;
        private const int enemyCode = 2;
    }
}
