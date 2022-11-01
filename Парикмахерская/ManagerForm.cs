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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "парикмахерскаяDataSet.Стрижки". При необходимости она может быть перемещена или удалена.
            this.стрижкиTableAdapter.Fill(this.парикмахерскаяDataSet.Стрижки);

        }
    }
}
