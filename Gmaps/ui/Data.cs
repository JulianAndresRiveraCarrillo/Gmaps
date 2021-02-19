using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmaps.ui
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("se cargara la informacion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se generara un grafico");
        }

        public void Data_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            this.ShowDialog();
        }
    }
}
