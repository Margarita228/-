using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СалонКрасоты
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            additemscombobox();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void additemscombobox()
        {
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);

            string checkLogCommand = "select [Код роли],Роль from [Роли]";
            SqlCommand checkLogComman = new SqlCommand(checkLogCommand, MyConnection);


            MyConnection.Open();
            SqlDataReader read = checkLogComman.ExecuteReader();


            while (read.Read())
            {
                comboBox1.Items.Add(read[0]);
            }
            read.Close();
            MyConnection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //сделать чтобы в комбо были роли текстом, записывалось цифрами

            var login = textBox1.Text;
            var role = comboBox1.Text;
            var password = md5.HashPassword(textBox2.Text);
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            MyConnection.Open();
            SqlCommand command = new SqlCommand($"Insert into Пользователи(Логин, [Код роли], ХэшПароль) values('{login}','{role}','{password}')",MyConnection);
           
            if (command.ExecuteNonQuery () == 1)
            {
               MessageBox.Show("Аккаунт успешно создан!", "Успешно!");
               Form1 form = new Form1();
               form.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан! Ошибка!");
            }
            MyConnection.Close();
        }
    }
}
