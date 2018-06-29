using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_11._2
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            form2 = new Form2(this);
            InitializeComponent();
            form2.Show();
            printPreviewDialog1.Document = printDocument1;
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
        }

        private void sendA_Click(object sender, EventArgs e)
        {
            if (textA.Text.Length != 0)
            {
                this.addText(textA.Text, 1);
                form2.addText(textA.Text, 2);
                textA.Text = "";
            }
        }
        public void addText(string inputline, int i)
        {
            if (i == 1)
            {
                showA.Text += "我說: " + inputline + Environment.NewLine;
            }
            else if (i == 2)
            {
                showA.Text += "他說: " + inputline + Environment.NewLine;
            }

        }

        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                showA.Font = fontDialog1.Font;
                //設btnDesign前景色和字型對話方塊設定的色彩相同
                showA.ForeColor = fontDialog1.Color;
            }
        }

        private void printformA_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void printshowA_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printA_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void exitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
