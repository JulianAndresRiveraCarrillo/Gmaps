using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Gmaps
{
    public partial class Mapa : Form
    {
        private List<PointLatLng> puntos;
        private List<PointLatLng> poligonos;

        GMapOverlay points = new GMapOverlay("Puntos");
        GMapOverlay polygons = new GMapOverlay("Poligonos");

        public Mapa()
        {
            InitializeComponent();
            puntos = new List<PointLatLng>();
            poligonos = new List<PointLatLng>();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;

            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(4.570868, -74.297333);

            gmap.Overlays.Add(points);
            gmap.Overlays.Add(polygons);
        }
    }
}
