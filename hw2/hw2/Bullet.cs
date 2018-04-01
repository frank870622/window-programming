using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    abstract class Bullet : PictureBox
    {
        public Bullet()
        {
        }

        public abstract void moveUp();
        

    }
}
