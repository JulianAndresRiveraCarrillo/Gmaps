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
    public partial class PieGraph : Form
    {
        GraphManager gm = new GraphManager();

        public PieGraph(string path)
        {
            InitializeComponent();
            gm.GenerateGraph(path);
            PieGraph_Load();
        }

        private void PieGraph_Load()
        {
            List<City> infoList = gm.Info;
            pieChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < infoList.Count; i++)
            {
                pieChart.Series["Poblacion"].Points.AddXY(infoList[i].Name, infoList[i].Population);
            }
        }
    }
}
