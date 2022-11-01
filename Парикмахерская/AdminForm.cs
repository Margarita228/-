using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Парикмахерская
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet2.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.парикмахерскаяDataSet2.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Филиалы". При необходимости она может быть перемещена или удалена.
            this.филиалыTableAdapter.Fill(this.парикмахерскаяDataSet.Филиалы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.парикмахерскаяDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.парикмахерскаяDataSet.Работа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Стрижки". При необходимости она может быть перемещена или удалена.
            this.стрижкиTableAdapter.Fill(this.парикмахерскаяDataSet.Стрижки);

        }

        private void стрижкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стрижкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.парикмахерскаяDataSet);

        }
    }
}
