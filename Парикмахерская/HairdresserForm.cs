using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СалонКрасоты
{
    public partial class HairdresserForm : Form
    {
        public HairdresserForm()
        {
            InitializeComponent();
            additemscombobox();
        }
        private void additemscombobox()
        {
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);

            string checkLogCommand = "select [Код услуги], Название from [Услуги]";
            SqlCommand checkLogComman = new SqlCommand(checkLogCommand, MyConnection);

            string checkLogCommand1 = "select [Код Клиента], Фио from [Клиенты]";
            SqlCommand checkLogComman1 = new SqlCommand(checkLogCommand1, MyConnection);

            string checkLogCommand2 = "select [Код Филиала], Филиал from [Филиалы]";
            SqlCommand checkLogComman2 = new SqlCommand(checkLogCommand2, MyConnection);

            MyConnection.Open();
            SqlDataReader read =checkLogComman.ExecuteReader();
            
            
            while (read.Read())
            {
                comboBox1.Items.Add(read[1]);
            }
            read.Close();
            SqlDataReader read2 = checkLogComman1.ExecuteReader();
            while (read2.Read())
            {
                comboBox2.Items.Add(read2[1]);
            }
            read2.Close();
            SqlDataReader read3 = checkLogComman2.ExecuteReader();
            while (read3.Read())
            {
                comboBox3.Items.Add(read3[1]);
            }
            read3.Close();

            MyConnection.Close();
        }

        private void работаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.парикмахерскаяDataSet);

        }

        private void HairdresserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet11.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter3.Fill(this.парикмахерскаяDataSet11.Работа);
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);

            //высчитывается скидка после 5 посещения
            string checkLogCommand = @"declare @is float set @is = 1.0
            if ((select count([Код услуги]) from Работа where [Код клиента] = (select top(1) [Код клиента] from Клиенты where [ФИО] =@s2)) > 5)
            begin
                update Клиенты set Категория = 'Постоянный' where [ФИО] = @s2
                set @is = 0.97;
            end

            insert into Работа([Код услуги], [Код клиента], [Код филиала], стоимость, Дата) values(         
            (select top(1) [Код услуги] from Услуги where [Название] =@s1),
            (select top(1) [Код клиента] from Клиенты where [ФИО] =@s2),
            (select top(1) [Код филиала] from Филиалы where [Филиал] =@s3),
            (select top(1) ([Стоимость]*@is) from Услуги where [Название] =@s1),
            @data)";

            SqlCommand checkLogComman = new SqlCommand(checkLogCommand, MyConnection);

            checkLogComman.Parameters.Add(new SqlParameter("@s1", comboBox1.Text));
            checkLogComman.Parameters.Add(new SqlParameter("@s2", comboBox2.Text));
            checkLogComman.Parameters.Add(new SqlParameter("@s3", comboBox3.Text));
            checkLogComman.Parameters.Add(new SqlParameter("@data", DateTime.Today));

            MyConnection.Open();
            checkLogComman.ExecuteNonQuery();
            MyConnection.Close();

            this.работаTableAdapter.Update(this.парикмахерскаяDataSet.Работа);
            
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                MyConnection.Close();
            }

            string query = @"select Стоимость from Работа where [Код работы] = (select max([Код работы]) from Работа)";
            SqlCommand queryy = new SqlCommand(query, MyConnection);
            MyConnection.Open();
            queryy.ExecuteNonQuery();
            SqlDataReader reader = queryy.ExecuteReader();
            string res = string.Empty;
            while (reader.Read())
            {
                res += reader["Стоимость"];
            }
            MessageBox.Show("Данные добавлены! Стоимость услуги: " + res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            парикмахерскаяDataSet.Работа.Clear();
            работаTableAdapter3.Fill(парикмахерскаяDataSet11.Работа);
            работаDataGridView1.DataSource = парикмахерскаяDataSet11.Работа;
            this.работаTableAdapter3.Update(this.парикмахерскаяDataSet11.Работа);
            MessageBox.Show("Данные изменены!");
        }
    }
}
