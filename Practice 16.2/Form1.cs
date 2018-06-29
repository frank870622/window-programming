using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QueryProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingManagerBase bm;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Hospital.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM doctor", cn);
            daProduct.Fill(ds, "doctor");
            //https://msdn.microsoft.com/zh-tw/library/ay82azad(v=vs.110).aspx
            txtId.DataBindings.Add("Text", ds, "doctor.name");
            txtName.DataBindings.Add("Text", ds, "doctor.所屬系別編號");
            txtPrice.DataBindings.Add("Text", ds, "doctor.職稱");
            textBox1.DataBindings.Add("Text", ds, "doctor.薪水");
            textBox2.DataBindings.Add("Text", ds, "doctor.Did");

            bm = this.BindingContext[ds, "doctor"];
            ShowRecord();
        }

        void Edit(string sqlstr)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Hospital.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();
        }

        private void ShowRecord()
        {
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            ShowRecord();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (bm.Position > 0)
            {
                bm.Position -= 1;
            }
            ShowRecord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bm.Position < bm.Count - 1)
            {
                bm.Position += 1;
            }
            ShowRecord();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
            ShowRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit("INSERT INTO doctor(name,所屬系別編號,職稱,薪水,Did)VALUES(N'" +
                txtId.Text.Replace("'", "''") + "'," +
                txtName.Text + ",N'" +
                txtPrice.Text.Replace("'", "''") + "'," +
                textBox1.Text + "," +
                textBox2.Text + ")");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        void DataBindingsClear()
        {
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
        }
    }
}
