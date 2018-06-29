using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Practice_13._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string directPath = "text.txt";
            FileInfo filein = new FileInfo(directPath);
            if (!Directory.Exists(filein.DirectoryName))
            {
                Directory.CreateDirectory(filein.DirectoryName);
            }
            StreamWriter sw = filein.CreateText();
            sw.Close();
            MessageBox.Show("建立成功");
            saveButton.Enabled = true;
            moveButton.Enabled = true;
            textbox.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string directPath = "text.txt";
            FileInfo filein = new FileInfo(directPath);
            if (!Directory.Exists(filein.DirectoryName))
            {
                Directory.CreateDirectory(filein.DirectoryName);
            }
            StreamWriter sw = filein.CreateText();
            sw.Write(textbox.Text);
            sw.Close();
            MessageBox.Show("存檔成功");
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            string directPath = "text.txt";
            FileInfo filein = new FileInfo(directPath);
            if (File.Exists(directPath))
            {
                filein.CopyTo(pathTextbox.Text, true);
                MessageBox.Show("搬移成功");
                filein.Delete();
            }
            else {
                MessageBox.Show("搬移失敗 檔案不存在");
            }
            
        }
    }
}
