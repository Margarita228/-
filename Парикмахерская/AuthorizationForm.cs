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


namespace СалонКрасоты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Result { get; set; }
        public string Result2 { get; set; }
        public string Result3 { get; set; }

        public void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            var loginUser = textBox1.Text;
            var passUser = md5.HashPassword(textBox2.Text);


            string checkLogCommand = $" select COUNT (*) from Пользователи where [логин] = '{loginUser}' and Хэшпароль = '{passUser}'";
            SqlCommand checkLogComman = new SqlCommand(checkLogCommand, MyConnection);
            string checkPassCommand = $"SELECT COUNT (*) FROM [Пользователи] WHERE [логин] = '{loginUser}' and Хэшпароль = '{passUser}'";
            SqlCommand checkPassComman = new SqlCommand(checkPassCommand, MyConnection);
            string QueryRoleSQL = $" SELECT [Роли].[Роль] FROM [Пользователи] inner join [Роли] on [Роли].[Код роли] = [Пользователи].[Код роли] WHERE [логин] = '{loginUser}' and Хэшпароль = '{passUser}'";
            SqlCommand checkRoleComman = new SqlCommand(QueryRoleSQL, MyConnection);


            MyConnection.Open();


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                MyConnection.Close();
            }

            Result = checkLogComman.ExecuteScalar().ToString();

            if (Result != "1")
            {
                MessageBox.Show("Неверные данные!");
                MyConnection.Close();
            }

            Result2 = checkPassComman.ExecuteScalar().ToString();

            if (Result2 != "1")
            {
                MessageBox.Show("Вы ввели неверный пароль");
                
            }

            Result3 = checkRoleComman.ExecuteScalar().ToString();



            if (Result == "1")
            {
                if (Result2 == "1")
                {
                    switch (Result3)
                    {
                        case "admin":
                            AdminForm form2 = new AdminForm();
                            form2.Show();
                            this.Hide();
                            break;
                        case "hairdresser":
                            AccountantForm form3 = new AccountantForm();
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

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }
    }
}
