using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using SD = System.Data;

namespace СалонКрасоты
{
    public partial class AccountantForm : Form
    {

        List<string[]> atmsData;

        public AccountantForm()
        {
            InitializeComponent();
        }

        private void AccountantForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet1.Филиалы". При необходимости она может быть перемещена или удалена.
            this.филиалыTableAdapter.Fill(this.парикмахерскаяDataSet1.Филиалы);

        }

        public SqlConnection mycon;
        public SqlCommand mycom;
        public string connect = @" Data Source= MARGARITA; Initial catalog=Парикмахерская; Integrated Security=True";
        public SD.DataSet ds;

        

        private void button1_Click(object sender, EventArgs e)   //zapros
        {
            string script = "SELECT [Код филиала], sum(стоимость) as Выручка from Работа group by [код филиала]";
            mycon = new SqlConnection(connect);
            mycon.Open();
            
            SqlDataAdapter ms_data = new SqlDataAdapter(script, connect);

            SD.DataTable table = new SD.DataTable();    //переменная таблица
            ms_data.Fill(table);
            dgv.DataSource = table;

            mycon.Close();

        }

        private void button2_Click(object sender, EventArgs e)   //exp
        {
            string pdfBank = "Операции";
           
            DateTime now = DateTime.Now;
            string fileName = $"report__{now.ToString("MM_dd__hh_mm_ss")}";
            string[] pdfTablesNames = { "Отчёт по операциям" };
            string[][] pdfTablesColumns = { new string[] { "Код работы","Код услуги", "Код клиента", "Дата", "Код филиала", "Стоимость" } };
            List<string[]>[] pdfData = {
                    new List<string[]> { new string[] { $"{now.ToString("yyyy-MM-dd")}" } },
                    new List<string[]> { new string[] { $"Салон красоты: {pdfBank}" } },
                    atmsData,
            };
            СалонКрасоты.utils.pdfWriter(fileName, pdfTablesNames, pdfData, pdfTablesColumns);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string script = "Select * from Работа where Дата like '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ";
            mycon = new SqlConnection(connect);
            mycon.Open();
            atmsData = db.Select(script);
            СалонКрасоты.utils.UpdateTable(dgv, atmsData, new string[] { "Код работы","Код услуги", "Код клиента", "Дата", "Код филиала", "Стоимость" });
            mycon.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string scvR = "Операции";
            DateTime now = DateTime.Now;
            string fileName = $"report__{now.ToString("MM_dd__hh_mm_ss")}";
            СалонКрасоты.utils.csvWriter(fileName, atmsData, new string[] { "Код услуги", "Код клиента", "Дата", "Код филиала", "Стоимость" });
            MessageBox.Show(
                    $"Отчет {fileName} сохранен!",
                    "Подтверждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}

