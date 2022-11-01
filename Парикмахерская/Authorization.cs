using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Парикмахерская
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);


            SqlParameter pLog = new SqlParameter("@login", textBox1.Text);
            SqlParameter pPass = new SqlParameter("@password", textBox2.Text);
            SqlParameter pLog2 = new SqlParameter("@login", textBox1.Text);
            SqlParameter pPass2 = new SqlParameter("@password", textBox2.Text);
            SqlParameter pLog3 = new SqlParameter("@login", textBox1.Text);


            string checkLogCommand = " select COUNT (*) from Пользователи where [логин] = @login";

            string checkPassCommand = " SELECT COUNT (*) FROM [Пользователи] WHERE [логин] = @login and [ХэшПароль] = HASHBYTES('SHA1', @password)";

            string QueryRoleSQL = " SELECT [Роль] FROM [Пользователи] WHERE [логин] = @login and [ХэшПароль] = HASHBYTES('SHA1', @password)";


            SqlCommand checkLogComman = new SqlCommand(checkLogCommand, MyConnection);
            SqlCommand checkPassComman = new SqlCommand(checkPassCommand, MyConnection);
            SqlCommand checkRoleComman = new SqlCommand(QueryRoleSQL, MyConnection);


            checkLogComman.Parameters.Add(pLog);
            checkPassComman.Parameters.Add(pLog2);
            checkPassComman.Parameters.Add(pPass);
            checkRoleComman.Parameters.Add(pLog3);
            checkRoleComman.Parameters.Add(pPass2);

            MyConnection.Open();
            string result;
            string result2;
            string result3;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                MyConnection.Close();
            }

            result = checkLogComman.ExecuteScalar().ToString();

            if (result != "1")
            {
                MessageBox.Show("Неверные данные!");
                MyConnection.Close();
            }

            result2 = checkPassComman.ExecuteScalar().ToString();

            if (result2 != "1")
            {
                MessageBox.Show("Вы ввели неверный пароль");
                MyConnection.Close();
            }

            result3 = checkRoleComman.ExecuteScalar().ToString();



            if (result == "1")
            {
                if (result2 == "1")
                {
                    switch (result3)
                    {
                        case "admin":
                            AdminForm form2 = new AdminForm();
                            form2.Show();
                            this.Hide();
                            break;
                        case "hairdresser":
                            HairdresserForm form3 = new HairdresserForm();
                            form3.Show();
                            this.Hide();
                            break ;
                        case "manager":
                            ManagerForm form4 = new ManagerForm();
                            form4.Show();
                            this.Hide();
                            break;
                        case "administrator":
                            AdministratorForm form5 = new AdministratorForm();
                            form5.Show();
                            this.Hide ();
                            break ;
                    }
           
                }
            }
           
        }
    }
}
