using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_8._1
{
    public partial class Form1 : Form
    {
        int[] randomlist = new int[6];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lotteryBox.Items.Clear();
            for (int i = 1; i < 49; ++i)
            {
                lotteryBox.Items.Add(i);
            }

            Random random = new Random();
            for (int i = 0; i < 6; ++i)
            {
                int temp = random.Next() % 49 + 1;
                while (randomlist.Contains(temp))
                {
                    temp = random.Next() % 49 + 1;
                }
                randomlist[i] = temp;

            }
            Array.Sort(randomlist);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lotteryBox.Items.Count; ++i)
            {
                lotteryBox.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correctNumber = 0;
            if (lotteryBox.CheckedItems.Count != 6)
                MessageBox.Show("please select six numbers");
            else
            {
                for (int i = 0; i < 6; ++i)
                {
                    if (lotteryBox.CheckedItems.Contains(randomlist[i]))
                        ++correctNumber;
                }

                lotteryLabel.Text = "the current lotto numbers are as follows:\r\n" + randomlist[0] + ", " + randomlist[1] + ", " + randomlist[2] + ", " + randomlist[3] + ", " + randomlist[4] + ", " + randomlist[5] + "\r\n";
                if (correctNumber == 6)
                    lotteryLabel.Text += "congratutation on winning your prize...";
                else
                    lotteryLabel.Text += "Tough Luck Please keep it up!";
            }

            
        }
    }
}
