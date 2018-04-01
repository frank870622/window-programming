using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hw2
{
    class Octopus : Enemy
    {
        public Octopus(int x, int y)
        {
            this.Location = new Point(x, y);
            this.Image = Properties.Resources.Invader;
            this.Size = new Size(50, 50);
            this.Name = "Enemy";
            this.Visible = true; 
            
            attackTime = 999;
            hp = 3;
            moveMode = 0;
        }

        public override void move()
        {
            this.BringToFront();
            this.Top += 3;
            if (moveMode == 0)
            {
                this.Left += 3;
            }
            else
            {
                this.Left -= 3;
            }
            if (this.Left < 20)
                moveMode = 0;
            else if (this.Left > 535)
                moveMode = 1;
        }
        public override bool attack()
        {
            return false;
        }
        
        public override void hurt()
        {
            --hp;
        }
        public override bool ifDead()
        {
            if(hp <= 0)
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
        private int moveMode;
        private const int enemyCode = 1; 
    }
}
