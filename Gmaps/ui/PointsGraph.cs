using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gmaps.model;

namespace Gmaps.ui
{
    public partial class PointsGraph : Form
    {
        private GraphManager gm = new GraphManager();

        public PointsGraph(string path)
        {
            InitializeComponent();
            gm.GenerateGraph(path);
            Points_Load();

            this.WindowState = FormWindowState.Maximized;
        }

        private void Points_Load()
        {
            List<City> infoList = gm.Info;
            pointsChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < infoList.Count; i++)
            {
                pointsChart.Series["Poblacion"].Points.AddXY(infoList[i].Name, infoList[i].Population);
            }
        }
    }
}
