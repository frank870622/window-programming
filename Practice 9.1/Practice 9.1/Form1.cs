using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_9._1
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

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = int.Parse(textBox1.Text.ToString());
            progressBar.Step = 1;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
            label2.Text = "" + (progressBar.Maximum - progressBar.Value) + " seconds";
            if (progressBar.Value == progressBar.Maximum) {
                ((Timer)sender).Stop();
                label2.Text = "Time`s up!";
            }
        }
    }
}
