using Gmaps.model;
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

        DataManager dataManager = new DataManager();

        public DataWindow(string p)
        {
            InitializeComponent();
            categoriaBox.Visible = false;
            cadenaBox.Visible = false;
            Rango1.Visible = false;
            Rango2.Visible = false;
            minBox.Visible = false;
            maxBox.Visible = false;
            _path = p;
        }

        private void cargarBt_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            _path = openFileDialog.FileName;
            dataManager.createTable(_path);

            if(dataManager.Table != null)
            {
                dataGridView1.DataSource = dataManager.Table;
            }
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
