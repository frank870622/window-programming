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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 inputform)
        {
            InitializeComponent();
            form1 = inputform;
            printPreviewDialog2.Document = printDocument2;
            pageSetupDialog2.Document = printDocument2;
            printDialog2.Document = printDocument2;
        }

        public void addText(string inputline, int i)
        {
            if (i == 1)
            {
                showB.Text +="我說: " + inputline + Environment.NewLine;
            }
            else if (i == 2)
            {
                showB.Text +="他說: " + inputline + Environment.NewLine;
            }

        }

        private void sendB_Click(object sender, EventArgs e)
        {
            if (textB.Text.Length != 0)
            {
                this.addText(textB.Text, 1);
                form1.addText(textB.Text, 2);
                textB.Text = "";
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog2.ShowDialog() == DialogResult.OK)
            {
                showB.Font = fontDialog2.Font;
                //設btnDesign前景色和字型對話方塊設定的色彩相同
                showB.ForeColor = fontDialog2.Color;
            }
        }

        private void printformB_Click(object sender, EventArgs e)
        {
            pageSetupDialog2.ShowDialog();
            printDocument2.DefaultPageSettings = pageSetupDialog2.PageSettings;
        }

        private void printshowB_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.ShowDialog();
        }

        private void printB_Click(object sender, EventArgs e)
        {
            if (printDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
