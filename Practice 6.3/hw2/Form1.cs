using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class Form1 : Form
    {
        List<Person> person = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginPasswordBox.PasswordChar = '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginNameBox.Text == "0000" && loginPasswordBox.Text == "0000") {
                loginNameBox.Text = "";
                loginPasswordBox.Text = "";

                loginName.Visible = false;
                loginNameBox.Visible = false;
                loginPassward.Visible = false;
                loginPasswordBox.Visible = false;
                loginButton.Visible = false;

                added.Visible = true;
                inquire.Visible = true;
                delete.Visible = true;
                logout.Visible = true;

                checkLabel.Visible = false;
            }
            else
            {
                checkLabel.Text = "帳號或密碼錯誤";
                checkLabel.Visible = true;
            }
        }

        private void added_Click(object sender, EventArgs e)
        {
            ID.Visible = true;
            gender.Visible = true;
            phone.Visible = true;
            location.Visible = true;

            IDBox.Visible = true;
            genderBox.Visible = true;
            phoneBox.Visible = true;
            locationBox.Visible = true;

            search.Visible = false;
            checkdelete.Visible = false;
            check.Visible = true;

            IDLabel.Visible = false;
            checkLabel.Visible = false;

            IDBox.Text = "";
            genderBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
        }

        private void inquire_Click(object sender, EventArgs e)
        {
            ID.Visible = true;
            gender.Visible = false;
            phone.Visible = false;
            location.Visible = false;

            IDBox.Visible = true;
            genderBox.Visible = false;
            phoneBox.Visible = false;
            locationBox.Visible = false;

            search.Visible = true;
            checkdelete.Visible = false;
            check.Visible = false;

            IDLabel.Visible = false;
            checkLabel.Visible = false;

            IDBox.Text = "";
            genderBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
        }

        private void checkdelete_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < person.Count(); ++i)
            {
                if(person[i].personID == IDBox.Text)
                {
                    person.RemoveAt(i);
                }
            }

            ID.Visible = true;
            gender.Visible = false;
            phone.Visible = false;
            location.Visible = false;

            IDBox.Visible = true;
            genderBox.Visible = false;
            phoneBox.Visible = false;
            locationBox.Visible = false;

            search.Visible = false;
            checkdelete.Visible = true;
            check.Visible = false;

            IDLabel.Visible = true;
            checkLabel.Visible = false;

            IDLabel.Text = "刪除成功!!";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginName.Visible = true;
            loginNameBox.Visible = true;
            loginPassward.Visible = true;
            loginPasswordBox.Visible = true;
            loginButton.Visible = true;


            added.Visible = false;
            inquire.Visible = false;
            delete.Visible = false;
            logout.Visible = false;

            ID.Visible = false;
            gender.Visible = false;
            phone.Visible = false;
            location.Visible = false;

            IDBox.Visible = false;
            genderBox.Visible = false;
            phoneBox.Visible = false;
            locationBox.Visible = false;

            search.Visible = false;
            checkdelete.Visible = false;
            check.Visible = false;

            IDLabel.Visible = false;
            checkLabel.Visible = false;

            IDBox.Text = "";
            genderBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {

            ID.Visible = true;
            gender.Visible = false;
            phone.Visible = false;
            location.Visible = false;

            IDBox.Visible = true;
            genderBox.Visible = false;
            phoneBox.Visible = false;
            locationBox.Visible = false;

            search.Visible = false;
            checkdelete.Visible = true;
            check.Visible = false;

            IDLabel.Visible = false;
            checkLabel.Visible = false;

            IDBox.Text = "";
            genderBox.Text = "";
            phoneBox.Text = "";
            locationBox.Text = "";
        }

        private void check_Click(object sender, EventArgs e)
        {
            if(IDBox.Text != "" && genderBox.Text != "" && phoneBox.Text != "" && locationBox.Text != "")
            {


                person.Add(new Person(IDBox.Text, genderBox.Text, phoneBox.Text, locationBox.Text));

                IDBox.Text = "";
                genderBox.Text = "";
                phoneBox.Text = "";
                locationBox.Text = "";

                checkLabel.Text = "資料已存入\n\r目前已有" + person.Count() + "筆資料!!";

                checkLabel.Visible = true;


            }
            else
            {
                checkLabel.Text = "各欄位不可為空，請重新輸入";
                checkLabel.Visible = true;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(IDBox.Text == "")
            {
                IDLabel.Text = "欄位不能為空";

                ID.Visible = true;
                gender.Visible = false;
                phone.Visible = false;
                location.Visible = false;

                IDBox.Visible = true;
                genderBox.Visible = false;
                phoneBox.Visible = false;
                locationBox.Visible = false;

                search.Visible = true;
                checkdelete.Visible = false;
                check.Visible = false;

                IDLabel.Visible = true;
                checkLabel.Visible = false;

            }
            else
            {
                int i;
                for (i = 0; i < person.Count(); ++i)
                {
                    if (person[i].personID == IDBox.Text)
                    {
                        break;
                    }
                }

                if (i == person.Count())
                {
                    IDLabel.Text = "無此筆資料";

                    ID.Visible = true;
                    gender.Visible = false;
                    phone.Visible = false;
                    location.Visible = false;

                    IDBox.Visible = true;
                    genderBox.Visible = false;
                    phoneBox.Visible = false;
                    locationBox.Visible = false;

                    search.Visible = true;
                    checkdelete.Visible = false;
                    check.Visible = false;

                    IDLabel.Visible = true;
                    checkLabel.Visible = false;

                }
                else
                {
                    ID.Visible = true;
                    gender.Visible = true;
                    phone.Visible = true;
                    location.Visible = true;

                    IDBox.Visible = true;
                    genderBox.Visible = true;
                    phoneBox.Visible = true;
                    locationBox.Visible = true;

                    search.Visible = true;
                    checkdelete.Visible = false;
                    check.Visible = false;

                    IDLabel.Visible = false;
                    checkLabel.Visible = false;

                    IDBox.Text = person[i].personID;
                    genderBox.Text = person[i].personGender;
                    phoneBox.Text = person[i].personPhone;
                    locationBox.Text = person[i].personLcation;
                }
            }
        }
    }
}
