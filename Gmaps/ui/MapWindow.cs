using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Gmaps.ui;
using System.IO;

namespace Gmaps
{
    public partial class MapWindow : Form
    {
        private string _path = " ";

        private List<string> lista;
        private List<string> listaPais;

        private List<PointLatLng> puntos;
        private List<PointLatLng> poligonos;

        GMapOverlay markers = new GMapOverlay("Marcadores");
        GMapOverlay polygons = new GMapOverlay("Poligonos");

        public MapWindow(string p)
        {
            InitializeComponent();
            puntos = new List<PointLatLng>();
            poligonos = new List<PointLatLng>();
            _path = p;

            lista = new List<string>();
            readInfo();
        }


        private void readInfo()
        {

            var reader = new StreamReader(File.OpenRead(_path));
            int count = 0;
            while (!reader.EndOfStream && count < 200)
            {

                var line = reader.ReadLine();
                var arreglo = line.Split(',');

                lista.Add(arreglo[4]); //Se concatena el nombre del municipio con la cadena ", Colombia"
                count++;                              //Para más precisión pueden concatenar el departamento.  
            }

        }

        public List<string> getLista()
        {

            return lista;

        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;

            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(3.42158, -76.5205);

            gmap.Overlays.Add(markers);
            gmap.Overlays.Add(polygons);
        }

        private void setMarkers()   //Coloca los marcadores en la capa
        {
            foreach (PointLatLng p in puntos) //P es un punto creado con latitud y longitud
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker); //Aqui se agrega el marcador a la capa
            }

        }

        private void setPolygons() //Extrapolar la explicación de los marcadores aqui...
        {
            GMapPolygon polygon = new GMapPolygon(poligonos, "Polygon");

            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red)); //Lineas para modificar apariencia
            polygon.Stroke = new Pen(Color.Red, 1);                       //No necesarias  

            polygons.Polygons.Add(polygon);
        }


        private void municipios_Click(object sender, EventArgs e)   //Mostrar municipios de Colombia
        {

        }


        private void deletePoints_click(object sender, EventArgs e) //Limpia todas las capas
        {

        }

        private void Add_Click(object sender, EventArgs e) //Añade PointsLatLng a la lista especificada en el comboBox
        {



        }

        private void Show_click(object sender, EventArgs e) //Mostrar contenido de capas
        {


        }

        private void mostrarBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_path);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double lat = double.Parse(latitudTxt.Text); //Si te pc esta en español, usa comas con los decimales
            latitudTxt.Text = "";
            double lon = double.Parse(longitudTxt.Text);
            longitudTxt.Text = "";

            PointLatLng p = new PointLatLng(lat, lon);

            if (comboBox.Text == "Marcador")
                puntos.Add(p);
            else if (comboBox.Text == "Poligono")
                poligonos.Add(p);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (comboBox.Text == "Marcador")
            {
                setMarkers();
                puntos.Clear();
            }
            else if (comboBox.Text == "Poligono")
            {
                setPolygons();
                poligonos.Clear();
            }


        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            List<string> lista = this.lista; //Trae los nombres de los municipios desde el Model

            List<string> nuevaLista = new List<string>();

            if (comboBoxFiltro.SelectedItem!=null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine(lista[i] + " = " + comboBoxFiltro.SelectedItem.ToString()+"Es afuera");
                    string comilla = "\"";
                    if (lista[i].Equals(comilla+comboBoxFiltro.SelectedItem.ToString()+comilla))
                    {
                        Console.WriteLine(lista[i]+" = "+ comboBoxFiltro.SelectedItem.ToString());

                        nuevaLista.Add(lista[i]);

                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingresa un país para mostrar");
            }

            foreach (string f in nuevaLista)
            {
                GeoCoderStatusCode statusCode;
                PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);

                //Las anteriores dos lineas proveen las funcionalidades para hacer la georeferenciación inversa

                if (pointLatLng1 != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = f + "\n" + pointLatLng1.Value.Lat + "\n" + pointLatLng1.Value.Lng; // Esta linea es solo apariencia
                    markers.Markers.Add(marker00);

                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarMapa_Click(object sender, EventArgs e)
        {
            puntos.Clear();
            markers.Clear();
            polygons.Clear();
        }
    }
}
