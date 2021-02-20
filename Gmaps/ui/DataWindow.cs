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
    public partial class DataWindow : Form
    {
        public DataWindow()
        {
            InitializeComponent();
            categoriaBox.Visible = false;
            cadenaBox.Visible = false;
            Rango1.Visible = false;
            Rango2.Visible = false;
            minBox.Visible = false;
            maxBox.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("se cargara la informacion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se generara un grafico");
        }

        private void cargarBt_Click(object sender, EventArgs e)
        {

        }

        private void mapBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapWindow mw = new MapWindow();
            mw.Show();
        }
    }
}
