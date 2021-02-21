using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Gmaps.model;
namespace Gmaps.ui
{
    public partial class BarGraphic : Form
    {
        GraphManager gm = new GraphManager();
        DataManager dataManager = new DataManager();

        public BarGraphic(string path)
        {
            InitializeComponent();
            gm.GenerateGraph(path);
            BarGraphic_Load();
        }

        private void BarGraphic_Load()
        {
            List<City> infoList = gm.Info;

           // DataTable t = dataManager.Table;

           // DataRowCollection row = t.Rows;

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.5;

            for (int i = 0; i < 1; i++)
            {
               //MessageBox.Show(row[i].ToString());
                chart1.Series["Population"].Points.AddXY(infoList[i].Name, infoList[i].Population);
            }

        }

        
    }
}
