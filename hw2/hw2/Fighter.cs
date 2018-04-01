using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace hw2
{
    class Fighter : PictureBox
    {
        public Fighter(int x, int y)
        {
            this.Location = new Point(x, y);
            this.Size = new Size(50, 50);
            this.Image = Properties.Resources.New_Piskel;
            this.Name = "Fighter";
            this.Visible = true;
        }

        //move function
        public void moveUp()
        {
            this.Top -= 7;
            if (this.Top < 0)
            {
                this.Top = 0;
            }
        }
        public void moveDown()
        {
            this.Top += 7;
            if (this.Top > 715)
            {
                this.Top = 715;
            }
        }
        public void moveLeft()
        {
            this.Left -= 7;
            if (this.Left < 0)
            {
                this.Left = 0;
            }
        }
        public void moveRight()
        {
            this.Left += 7;
            if (this.Left > 535)
            {
                this.Left = 535;
            }
        }
    }
}
