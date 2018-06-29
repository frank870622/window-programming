using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string process = "Plus";
        int pictureNumber = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile(@"..\..\Resources\p1.png");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           process = "Minus";
        }

        private void buttonPlus_CheckedChanged(object sender, EventArgs e)
        {
            process = "Plus";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (process.Equals("Plus"))
            {
                pictureNumber++;
                if (pictureNumber > 6) pictureNumber = 1;
                pictureBox.Image = Image.FromFile(@"..\..\Resources\p" + pictureNumber + ".png");
            }
            else
            {
                pictureNumber--;
                if (pictureNumber < 1) pictureNumber = 6;
                pictureBox.Image = Image.FromFile(@"..\..\Resources\p" + pictureNumber + ".png");
            }
        }
    }
}
