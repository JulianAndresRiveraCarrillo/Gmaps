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
        private string _path = " ";

        public DataWindow(string p)
        {
            InitializeComponent();
            categoriaBox.Visible = false;
            cadenaBox.Visible = false;
            Rango1.Visible = false;
            Rango2.Visible = false;
            minBox.Visible = false;
            maxBox.Visible = false;
            _path = prop;
        }

        private void cargarBt_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            _path = openFileDialog.FileName;
            MessageBox.Show(_path);
        }

        private void mapBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapWindow mw = new MapWindow(_path);
            mw.Show();
        }

        private void graficoBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_path);
        }
    }
}
