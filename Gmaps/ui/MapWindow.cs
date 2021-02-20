using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Gmaps.ui;

namespace Gmaps
{
    public partial class MapWindow : Form
    {
        private List<PointLatLng> puntos;
        private List<PointLatLng> poligonos;

        GMapOverlay points = new GMapOverlay("Puntos");
        GMapOverlay polygons = new GMapOverlay("Poligonos");

        public MapWindow()
        {
            InitializeComponent();
            puntos = new List<PointLatLng>();
            poligonos = new List<PointLatLng>();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;

            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(3.42158, -76.5205);

            gmap.Overlays.Add(points);
            gmap.Overlays.Add(polygons);
        }

        private void mostrarBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se mostrara un punto");
        }

        private void puntosBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo se muestra los puntos");
        }

        private void poligonosBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("solo se muestran los poligonos");
        }

        private void tableBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataWindow dw = new DataWindow();
            dw.Show();
        }
    }
}
