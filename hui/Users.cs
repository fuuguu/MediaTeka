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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.медиатекаDataSet.Пользователи);

        }

        private void код_пользователяLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_тарифаLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.MoveNext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.MovePrevious();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.AddNew();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.пользователиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
