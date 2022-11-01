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
    public partial class HairdresserForm : Form
    {
        public HairdresserForm()
        {
            InitializeComponent();
        }

        private void работаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.парикмахерскаяDataSet);

        }

        private void HairdresserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.парикмахерскаяDataSet.Работа);

        }
    }
}
