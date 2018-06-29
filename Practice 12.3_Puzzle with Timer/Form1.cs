﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sec = 0.0;
        private void Form1_Load(object sender, EventArgs e)
        {
            btn11.ImageIndex = 0; btn12.ImageIndex = 1; btn13.ImageIndex = 2;
            btn21.ImageIndex = 3; btn22.ImageIndex = 4; btn23.ImageIndex = 5;
            btn31.ImageIndex = 8; btn32.ImageIndex = 6; btn33.ImageIndex = 7;

            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;

            btn11.Click  += end_Case;
            btn12.Click += end_Case;
            btn13.Click += end_Case;
            btn21.Click += end_Case;
            btn22.Click += end_Case;
            btn23.Click += end_Case;
            btn31.Click += end_Case;
            btn32.Click += end_Case;
            btn33.Click += end_Case;

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn12.ImageIndex == 8)  //若右邊btn12按鈕的ImageIndex=8
            {
                btn12.ImageIndex = btn11.ImageIndex; btn11.ImageIndex = 8;
            }
            else if (btn21.ImageIndex == 8)  //若下面btn21按鈕的ImageIndex=8
            {
                btn21.ImageIndex = btn11.ImageIndex; btn11.ImageIndex = 8;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn11.ImageIndex == 8)  //若左邊btn11按鈕的ImageIndex=8
            {
                btn11.ImageIndex = btn12.ImageIndex; btn12.ImageIndex = 8;
            }
            else if (btn13.ImageIndex == 8)  //若右邊btn13按鈕的ImageIndex=8
            {
                btn13.ImageIndex = btn12.ImageIndex; btn12.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)  //若下面btn22按鈕的ImageIndex=8
            {
                btn22.ImageIndex = btn12.ImageIndex; btn12.ImageIndex = 8;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (btn12.ImageIndex == 8)  //若左邊btn12按鈕的ImageIndex=8
            {
                btn12.ImageIndex = btn13.ImageIndex; btn13.ImageIndex = 8;
            }
            else if (btn23.ImageIndex == 8) //若下面btn23按鈕的ImageIndex=8
            {
                btn23.ImageIndex = btn13.ImageIndex; btn13.ImageIndex = 8;
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (btn11.ImageIndex == 8) //若上面btn11按鈕的ImageIndex=8
            {
                btn11.ImageIndex = btn21.ImageIndex; btn21.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)  //若右邊btn13按鈕的ImageIndex=8
            {
                btn22.ImageIndex = btn21.ImageIndex; btn21.ImageIndex = 8;
            }
            else if (btn31.ImageIndex == 8) //若下面btn31按鈕的ImageIndex=8
            {
                btn31.ImageIndex = btn21.ImageIndex; btn21.ImageIndex = 8;
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (btn12.ImageIndex == 8) //若上面btn11按鈕的ImageIndex=8
            {
                btn12.ImageIndex = btn22.ImageIndex; btn22.ImageIndex = 8;
            }
            else if (btn21.ImageIndex == 8)  //若左邊btn21按鈕的ImageIndex=8
            {
                btn21.ImageIndex = btn22.ImageIndex; btn22.ImageIndex = 8;
            }
            else if (btn23.ImageIndex == 8)  //若右邊btn23按鈕的ImageIndex=8
            {
                btn23.ImageIndex = btn22.ImageIndex; btn22.ImageIndex = 8;
            }
            else if (btn32.ImageIndex == 8) //若下面btn32按鈕的ImageIndex=8
            {
                btn32.ImageIndex = btn22.ImageIndex; btn22.ImageIndex = 8;
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (btn13.ImageIndex == 8) //若上面btn13按鈕的ImageIndex=8
            {
                btn13.ImageIndex = btn23.ImageIndex; btn23.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)  //若左邊btn22按鈕的ImageIndex=8
            {
                btn22.ImageIndex = btn23.ImageIndex; btn23.ImageIndex = 8;
            }
            else if (btn33.ImageIndex == 8) //若下面btn33按鈕的ImageIndex=8
            {
                btn33.ImageIndex = btn23.ImageIndex; btn23.ImageIndex = 8;
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (btn21.ImageIndex == 8) //若上面btn31按鈕的ImageIndex=8
            {
                btn21.ImageIndex = btn31.ImageIndex; btn31.ImageIndex = 8;
            }
            else if (btn32.ImageIndex == 8)  //若右邊btn32按鈕的ImageIndex=8
            {
                btn32.ImageIndex = btn31.ImageIndex; btn31.ImageIndex = 8;
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (btn22.ImageIndex == 8) //若上面btn22按鈕的ImageIndex=8
            {
                btn22.ImageIndex = btn32.ImageIndex; btn32.ImageIndex = 8;
            }
            else if (btn31.ImageIndex == 8)  //若左邊btn31按鈕的ImageIndex=8
            {
                btn31.ImageIndex = btn32.ImageIndex; btn32.ImageIndex = 8;
            }
            else if (btn33.ImageIndex == 8)  //若右邊btn33按鈕的ImageIndex=8
            {
                btn33.ImageIndex = btn32.ImageIndex; btn32.ImageIndex = 8;
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (btn23.ImageIndex == 8) //若上面btn23按鈕的ImageIndex=8
            {
                btn23.ImageIndex = btn33.ImageIndex; btn33.ImageIndex = 8;
            }
            else if (btn32.ImageIndex == 8)  //若左邊btn32按鈕的ImageIndex=8
            {
                btn32.ImageIndex = btn33.ImageIndex; btn33.ImageIndex = 8;
            }
        }

        private void end_Case(object sender, EventArgs e)
        {
            if (btn11.ImageIndex == 0 && btn12.ImageIndex == 1 && btn13.ImageIndex == 2 &&
                btn21.ImageIndex == 3 && btn22.ImageIndex == 4 && btn23.ImageIndex == 5 &&
                btn31.ImageIndex == 6 && btn32.ImageIndex == 7 && btn33.ImageIndex == 8)
            {
                startButton.Enabled = false;
                clock.Enabled = false;
                startButton.Text = "遊戲結束";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Text = "遊戲中";
            clock.Enabled = true;

            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = (sec += 0.1).ToString("0.0");
        }
    }
}
