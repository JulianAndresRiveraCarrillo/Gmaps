using Gmaps.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Ok2.Visible = false;
            filtrar.Enabled = false;
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

            filtrar.Enabled = true;
        }

        private void mapBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapWindow mw = new MapWindow(_path);
            mw.Show();
        }

        private void graficoBt_Click(object sender, EventArgs e)
        {
            if(graficoBox.Text == "Grafico de Barras")
            {
                BarGraphic bg = new BarGraphic(_path);
                bg.Show();
            }
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            if (filtroBox.SelectedItem.Equals("Categorico"))
            {
                categoriaBox.Visible = true;
                Ok.Visible = true;
                Ok2.Visible = false;
                cadenaBox.Visible = false;
                Rango1.Visible = false;
                Rango2.Visible = false;
                minBox.Visible = false;
                maxBox.Visible = false;
            }
            if (filtroBox.SelectedItem.Equals("Numerico"))
            {
                categoriaBox.Visible = false;
                Ok.Visible = true;
                Ok2.Visible = false;
                cadenaBox.Visible = false;
                Rango1.Visible = true;
                Rango2.Visible = true;
                minBox.Visible = true;
                maxBox.Visible = true;
            }
            if (filtroBox.SelectedItem.Equals("Cadena"))
            {
                categoriaBox.Visible = false;
                Ok.Visible = true;
                cadenaBox.Visible = true;
                Rango1.Visible = false;
                Rango2.Visible = false;
                minBox.Visible = false;
                maxBox.Visible = false;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (categoriaBox.Visible == true)
            {
                dataManager.filterByType(_path, categoriaBox.Text);
            }
            else if (Rango1.Visible == true)
            {
                dataManager.filterByRank(_path, long.Parse(minBox.Text), long.Parse(maxBox.Text));

            }
        }

        private void cadenaBox_TextChanged(object sender, EventArgs e)
        {
            cadenaBox.AutoCompleteCustomSource = cargarDatos();
        }

        private AutoCompleteStringCollection cargarDatos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            datos.Add("Afghanistan");
            datos.Add("Albania");
            datos.Add("Algeria");
            datos.Add("American Samoa");
            datos.Add("Andorra");
            datos.Add("Angola");
            datos.Add("Antigua And Barbuda");
            datos.Add("Argentina");
            datos.Add("Armenia");
            datos.Add("Aruba");
            datos.Add("Australia");
            datos.Add("Austria");
            datos.Add("Azerbaijan");
            datos.Add("Bahamas, The");
            datos.Add("Bahrain");
            datos.Add("Bangladesh");
            datos.Add("Barbados");
            datos.Add("Belarus");
            datos.Add("Belgium");
            datos.Add("Belize");
            datos.Add("Benin");
            datos.Add("Bermuda");
            datos.Add("Bhutan");
            datos.Add("Bolivia");
            datos.Add("Bosnia And Herzegovina");
            datos.Add("Botswana");
            datos.Add("Brazil");
            datos.Add("Brunei");
            datos.Add("Bulgaria");
            datos.Add("Burkina Faso");
            datos.Add("Burma");
            datos.Add("Burundi");
            datos.Add("Cabo Verde");
            datos.Add("Cambodia");
            datos.Add("Cameroon");
            datos.Add("Canada");
            datos.Add("Cayman Islands");
            datos.Add("Central African Republic");
            datos.Add("Chad");
            datos.Add("Chile");
            datos.Add("China");
            datos.Add("Colombia");
            datos.Add("Comoros");
            datos.Add("Congo (Brazzaville)");
            datos.Add("Congo (Kinshasa)");
            datos.Add("Cook Islands");
            datos.Add("Costa Rica");
            datos.Add("Croatia");
            datos.Add("Cuba");
            datos.Add("Curaçao");
            datos.Add("Cyprus");
            datos.Add("Czechia");
            datos.Add("Côte D’Ivoire");
            datos.Add("Denmark");
            datos.Add("Djibouti");
            datos.Add("Dominica");
            datos.Add("Dominican Republic");
            datos.Add("Ecuador");
            datos.Add("Egypt");
            datos.Add("El Salvador");
            datos.Add("Equatorial Guinea");
            datos.Add("Eritrea");
            datos.Add("Estonia");
            datos.Add("Ethiopia");
            datos.Add("Falkland Islands (Islas Malvinas)");
            datos.Add("Faroe Islands");
            datos.Add("Fiji");
            datos.Add("Finland");
            datos.Add("France");
            datos.Add("French Guiana");
            datos.Add("French Polynesia");
            datos.Add("Gabon");
            datos.Add("Gambia, The");
            datos.Add("Georgia");
            datos.Add("Germany");
            datos.Add("Ghana");
            datos.Add("Gibraltar");
            datos.Add("Greece");
            datos.Add("Greenland");
            datos.Add("Grenada");
            datos.Add("Guadeloupe");
            datos.Add("Guam");
            datos.Add("Guatemala");
            datos.Add("Guinea");
            datos.Add("Guinea-Bissau");
            datos.Add("Guyana");
            datos.Add("Haiti");
            datos.Add("Honduras");
            datos.Add("Hong Kong");
            datos.Add("Hungary");
            datos.Add("Iceland");
            datos.Add("India");
            datos.Add("Indonesia");
            datos.Add("Iran");
            datos.Add("Iraq");
            datos.Add("Ireland");
            datos.Add("Isle Of Man");
            datos.Add("Israel");
            datos.Add("Italy");
            datos.Add("Jamaica");
            datos.Add("Japan");
            datos.Add("Jersey");
            datos.Add("Jordan");
            datos.Add("Kazakhstan");
            datos.Add("Kenya");
            datos.Add("Kiribati");
            datos.Add("Korea, North");
            datos.Add("Korea, South");
            datos.Add("Kosovo");
            datos.Add("Kuwait");
            datos.Add("Kyrgyzstan");
            datos.Add("Laos");
            datos.Add("Latvia");
            datos.Add("Lebanon");
            datos.Add("Lesotho");
            datos.Add("Liberia");
            datos.Add("Libya");
            datos.Add("Liechtenstein");
            datos.Add("Lithuania");
            datos.Add("Luxembourg");
            datos.Add("Macau");
            datos.Add("Macedonia");
            datos.Add("Madagascar");
            datos.Add("Malawi");
            datos.Add("Malaysia");
            datos.Add("Maldives");
            datos.Add("Mali");
            datos.Add("Malta");
            datos.Add("Marshall Islands");
            datos.Add("Martinique");
            datos.Add("Mauritania");
            datos.Add("Mauritius");
            datos.Add("Mayotte");
            datos.Add("Mexico");
            datos.Add("Micronesia, Federated States Of");
            datos.Add("Moldova");
            datos.Add("Monaco");
            datos.Add("Mongolia");
            datos.Add("Montenegro");
            datos.Add("Morocco");
            datos.Add("Mozambique");
            datos.Add("Namibia");
            datos.Add("Nepal");
            datos.Add("Netherlands");
            datos.Add("New Caledonia");
            datos.Add("New Zealand");
            datos.Add("Nicaragua");
            datos.Add("Niger");
            datos.Add("Nigeria");
            datos.Add("Northern Mariana Islands");
            datos.Add("Norway");
            datos.Add("Oman");
            datos.Add("Pakistan");
            datos.Add("Palau");
            datos.Add("Panama");
            datos.Add("Papua New Guinea");
            datos.Add("Paraguay");
            datos.Add("Peru");
            datos.Add("Philippines");
            datos.Add("Poland");
            datos.Add("Portugal");
            datos.Add("Puerto Rico");
            datos.Add("Qatar");
            datos.Add("Reunion");
            datos.Add("Romania");
            datos.Add("Russia");
            datos.Add("Rwanda");
            datos.Add("Saint Helena, Ascension, And Tristan Da Cunha");
            datos.Add("Saint Kitts And Nevis");
            datos.Add("Saint Lucia");
            datos.Add("Saint Vincent And The Grenadines");
            datos.Add("Samoa");
            datos.Add("San Marino");
            datos.Add("Sao Tome And Principe");
            datos.Add("Saudi Arabia");
            datos.Add("Senegal");
            datos.Add("Serbia");
            datos.Add("Seychelles");
            datos.Add("Sierra Leone");
            datos.Add("Singapore");
            datos.Add("Slovakia");
            datos.Add("Slovenia");
            datos.Add("Solomon Islands");
            datos.Add("Somalia");
            datos.Add("South Africa");
            datos.Add("South Georgia And South Sandwich Islands");
            datos.Add("South Sudan");
            datos.Add("Spain");
            datos.Add("Sri Lanka");
            datos.Add("Sudan");
            datos.Add("Suriname");
            datos.Add("Swaziland");
            datos.Add("Sweden");
            datos.Add("Switzerland");
            datos.Add("Syria");
            datos.Add("Taiwan");
            datos.Add("Tajikistan");
            datos.Add("Tanzania");
            datos.Add("Thailand");
            datos.Add("Timor-Leste");
            datos.Add("Togo");
            datos.Add("Tonga");
            datos.Add("Trinidad And Tobago");
            datos.Add("Tunisia");
            datos.Add("Turkey");
            datos.Add("Turkmenistan");
            datos.Add("Turks And Caicos Islands");
            datos.Add("Tuvalu");
            datos.Add("Uganda");
            datos.Add("Ukraine");
            datos.Add("United Arab Emirates");
            datos.Add("United Kingdom");
            datos.Add("United States");
            datos.Add("Uruguay");
            datos.Add("Uzbekistan");
            datos.Add("Vanuatu");
            datos.Add("Vatican City");
            datos.Add("Venezuela");
            datos.Add("Vietnam");
            datos.Add("Wallis And Futuna");
            datos.Add("West Bank");
            datos.Add("Yemen");
            datos.Add("Zambia");
            datos.Add("Zimbabwe");
            return datos;
        }

        private void Ok2_Click(object sender, EventArgs e)
        {
            dataManager.filterByWord(_path, cadenaBox.Text);
        }
    }
}
