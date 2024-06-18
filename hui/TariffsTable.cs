using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hui
{
    public partial class TariffsTable : Form
    {
        public TariffsTable()
        {
            InitializeComponent();
        }

        private void тарифыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void TariffsTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Тарифы". При необходимости она может быть перемещена или удалена.
            this.тарифыTableAdapter.Fill(this.медиатекаDataSet.Тарифы);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void тарифыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
