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
    public partial class Films : Form
    {
        public Films()
        {
            InitializeComponent();
        }

        private void фильмыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Films_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.медиатекаDataSet.Фильмы);

        }

        private void стоимость_фильмаLabel_Click(object sender, EventArgs e)
        {

        }

        private void стоимость_фильмаTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.фильмыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FilmsTable filmsTable = new FilmsTable();
            filmsTable.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FilmsByGenre filmsByGenre = new FilmsByGenre();
            filmsByGenre.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FilmsByYear filmsByYear = new FilmsByYear();
            filmsByYear.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FilmsByAuthor filmsByAuthor = new FilmsByAuthor();
            filmsByAuthor.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FilmsByActor filmsByActor = new FilmsByActor();
            filmsByActor.Show();
        }
    }
}
