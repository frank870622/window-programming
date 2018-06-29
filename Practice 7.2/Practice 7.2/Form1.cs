using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<TabPage> pages = new List<TabPage>();
        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pages.Add(pageLogin);
            pages.Add(pageEnglish);
            pages.Add(pageChinese);
            //pageLogin.Parent = pageControl;
            //pageEnglish.Parent = pageControl;
            //pageChinese.Parent = pageControl;

            pageControl.TabPages.Remove(pageChinese);
            pageControl.TabPages.Remove(pageEnglish);

            passwardBox.PasswordChar = '*';　
        }
        private void pageLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(nameBox.Text == "0" && passwardBox.Text == "0")
            {
                pageControl.TabPages.Remove(pageLogin);
                pageControl.TabPages.Add(pages[1]);
                pageControl.TabPages.Add(pages[2]);
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
