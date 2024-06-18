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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void история_покупокBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.история_покупокBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.История_покупок". При необходимости она может быть перемещена или удалена.
            this.история_покупокTableAdapter.Fill(this.медиатекаDataSet.История_покупок);

        }

        private void код_покупкиLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_покупкиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            история_покупокBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            история_покупокBindingSource.MoveNext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            история_покупокBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            история_покупокBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            история_покупокBindingSource.AddNew();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            история_покупокBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.история_покупокBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
