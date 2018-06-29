using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int round = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Click_Event;
            button2.Click += Click_Event;
            button3.Click += Click_Event;
            button4.Click += Click_Event;
            button5.Click += Click_Event;
            button6.Click += Click_Event;
            button7.Click += Click_Event;
            button8.Click += Click_Event;
            button9.Click += Click_Event;
        }

        private void Click_Event(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;
            if (btnClick.Enabled == true)
            {
                if (round == 0)
                {
                    btnClick.Text = "O";
                    btnClick.Enabled = false;
                    round++;
                    label1.Text = "X的回合";
                }
                else
                {
                    btnClick.Text = "X";
                    btnClick.Enabled = false;
                    round--;
                    label1.Text = "O的回合";
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O WIN");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X WIN");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Duce");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
               
        }

        private void restart_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            round = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            label1.Text = "O的回合";
        }
    }
}
