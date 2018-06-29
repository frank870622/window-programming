using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_14._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.學生' 資料表。您可以視需要進行移動或移除。
            this.學生TableAdapter.Fill(this.database1DataSet.學生);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.系所' 資料表。您可以視需要進行移動或移除。
            this.系所TableAdapter.Fill(this.database1DataSet.系所);

        }
    }
}
