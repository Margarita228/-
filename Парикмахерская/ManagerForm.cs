using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СалонКрасоты
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void стрижкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стрижкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.парикмахерскаяDataSet);

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet11.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter1.Fill(this.парикмахерскаяDataSet11.Работа);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Стрижки". При необходимости она может быть перемещена или удалена.
            //this.услугиTableAdapter.Fill(this.парикмахерскаяDataSet.Услуги);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT [Код филиала], sum(стоимость) as Выручка from Работа group by [код филиала]", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dataSet1);
            MyConnection.Close();
            da.Dispose();
            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                string commText = "SELECT [Код филиала], sum(стоимость) as Выручка from Работа group by [код филиала]";
                SqlCommand comm = new SqlCommand(commText, conn);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                dataGridView1.DataSource = table;
            }
            MessageBox.Show("Успешно!");
        }
    }
}
