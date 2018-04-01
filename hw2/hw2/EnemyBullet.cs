using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hw2
{
    class EnemyBullet : Bullet
    {
        public EnemyBullet(int x, int y,int code)
        {
            this.Location = new Point(x, y);
            this.Image = Properties.Resources.Laser2;
            this.Size = new Size(10, 50);
            this.Visible = true;
            this.Name = "EnemyBullet";
            bulletCode = code;
        }

        public override void moveUp()
        {
            this.Top += 3;
            if(bulletCode == 1)
            {
                this.Left -= 3;
            }
            else if(bulletCode == 2)
            {
                this.Left += 3;
            }
        }

        private int bulletCode;
    }
}
