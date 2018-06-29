using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratice6._4
{
    public partial class Form1 : Form
    {
        double money;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double money;

            try
            {
                money = double.Parse(textBox1.Text);
                answerLabel.Text = "可兌換：" + money*33 + " 台幣";
            }
            catch
            {
                if(textBox1.Text != "")
                MessageBox.Show("請輸入數字", "錯誤",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                answerLabel.Text = "請輸入數字";
                textBox1.Clear();
            }


        }
    }
}
