using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                label1.Location = new Point(label1.Location.X - 10, label1.Location.Y);
            else if (e.KeyCode == Keys.Right)
                label1.Location = new Point(label1.Location.X + 10, label1.Location.Y);
            else if (e.KeyCode == Keys.Up)
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 10);
            else if (e.KeyCode == Keys.Down)
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 10);

            label1.Text = "按了" + e.KeyData + "鍵，鍵碼：" + e.KeyValue; 
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "按了左鍵於X：" + e.X + "Y：" + e.Y;
        }
    }
}
