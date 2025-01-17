﻿using System;
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
        private GraphManager gm = new GraphManager();

        public BarGraphic(string path)
        {
            InitializeComponent();
            gm.GenerateGraph(path);
            BarGraphic_Load();

            this.WindowState = FormWindowState.Maximized;
        }

        private void BarGraphic_Load()
        {
            List<City> infoList = gm.Info;
            barChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < infoList.Count; i++)
            {
                barChart.Series["Poblacion"].Points.AddXY(infoList[i].Name, infoList[i].Population);
            }
            
        }

       
    }
}
