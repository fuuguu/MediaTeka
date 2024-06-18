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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Films films = new Films();
            films.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tariffs tariffs = new Tariffs();
            tariffs.Show();
        }
    }
}
