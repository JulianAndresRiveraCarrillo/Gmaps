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

        public DataWindow()
        {
            InitializeComponent();
            
            categoriaBox.Visible = false;
            cadenaBox.Visible = false;
            Rango1.Visible = false;
            Rango2.Visible = false;
            minBox.Visible = false;
            maxBox.Visible = false;
            Ok.Visible = false;
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

        private void filtrar_Click(object sender, EventArgs e)
        {
            if (filtroBox.SelectedItem.Equals("Categorico"))
            {
                categoriaBox.Visible = true;
                Ok.Visible = true;
                cadenaBox.Visible = false;
                Rango1.Visible = false;
                Rango2.Visible = false;
                minBox.Visible = false;
                maxBox.Visible = false;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if(categoriaBox.Visible == true)
            {
                dataManager.filterByType(_path, categoriaBox.Text);
            }
        }
    }
}
