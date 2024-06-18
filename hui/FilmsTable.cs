using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hui
{
    public partial class FilmsTable : Form
    {
        public FilmsTable()
        {
            InitializeComponent();
        }

        private void фильмыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void FilmsTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.медиатекаDataSet.Фильмы);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn column = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    {
                        column = dataGridViewTextBoxColumn2;
                        break;
                    }
                case 1:
                    {
                        column = dataGridViewTextBoxColumn3;
                        break;
                    }
                case 2:
                    {
                        column = dataGridViewTextBoxColumn4;
                        break;
                    }
                case 3:
                    {
                        column = dataGridViewTextBoxColumn5;
                        break;
                    }
                case 4:
                    {
                        column = dataGridViewTextBoxColumn6;
                        break;
                    }
                case 5:
                    {
                        column = dataGridViewTextBoxColumn7;
                        break;
                    }
                case 6:
                    {
                        column = dataGridViewTextBoxColumn8;
                        break;
                    }
                case 7:
                    {
                        column = dataGridViewTextBoxColumn9;
                        break;
                    }

            }
            if (radioButton1.Checked)
                фильмыDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
            else
                фильмыDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
                фильмыBindingSource.Filter = "Название='" + comboBox1.Text + "'";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < фильмыDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < фильмыDataGridView.RowCount - 1; j++)
                {
                    фильмыDataGridView[i, j].Style.BackColor = Color.White;
                    фильмыDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < фильмыDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < фильмыDataGridView.RowCount - 1; j++)
                {
                    if (фильмыDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        фильмыDataGridView[i, j].Style.BackColor = Color.Blue;
                        фильмыDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
