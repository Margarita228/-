using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СалонКрасоты
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.парикмахерскаяDataSet);

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet10.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter2.Fill(this.парикмахерскаяDataSet10.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter1.Fill(this.парикмахерскаяDataSet3.Клиенты);

        }

        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                CleanAllTextBoxesIn(this);
                MessageBox.Show("Успешно!");
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");

            }

            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand($"INSERT INTO [Клиенты] (ФИО, Пол, [Номер телефона]) values (N'{textBox1.Text}', N'{textBox2.Text}',N'{textBox3.Text}')",
                MyConnection);
            MyConnection.Open();
           command.ExecuteNonQuery();

            MessageBox.Show("Клиент успешно добавлен в базу данных!");

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                MyConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HairdresserForm form = new HairdresserForm();
            form.Show();
            this.Hide();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            HairdresserForm form = new HairdresserForm();
            form.Show();
            this.Hide();
        }

        private void клиентыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
