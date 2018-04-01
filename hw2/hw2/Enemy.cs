using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace hw2
{
    abstract class Enemy : PictureBox
    {
        public abstract void move();
        public abstract bool attack();
        public abstract void hurt();
        public abstract bool ifDead();
        public abstract int getEnemyCode();


       
    }
}
