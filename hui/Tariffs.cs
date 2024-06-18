using MaterialSkin.Controls;
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
    public partial class Tariffs : Form
    {
        public Tariffs()
        {
            InitializeComponent();
        }

        private void тарифыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Tariffs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Тарифы". При необходимости она может быть перемещена или удалена.
            this.тарифыTableAdapter.Fill(this.медиатекаDataSet.Тарифы);

        }

        private void стоимость_тарифа_в_месяцLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            тарифыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тарифыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тарифыBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            тарифыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TariffsTable tariffsTable = new TariffsTable();
            tariffsTable.Show();
        }
    }
}
