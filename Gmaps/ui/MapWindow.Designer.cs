
namespace Gmaps
{
    partial class MapWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.longitudTxt = new System.Windows.Forms.TextBox();
            this.latitudTxt = new System.Windows.Forms.TextBox();
            this.latitudLb = new System.Windows.Forms.Label();
            this.longitudLb = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.tableBt = new System.Windows.Forms.Button();
            this.filtrarLb = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarMapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // longitudTxt
            // 
            this.longitudTxt.Location = new System.Drawing.Point(12, 417);
            this.longitudTxt.Name = "longitudTxt";
            this.longitudTxt.Size = new System.Drawing.Size(100, 20);
            this.longitudTxt.TabIndex = 1;
            // 
            // latitudTxt
            // 
            this.latitudTxt.Location = new System.Drawing.Point(12, 362);
            this.latitudTxt.Name = "latitudTxt";
            this.latitudTxt.Size = new System.Drawing.Size(100, 20);
            this.latitudTxt.TabIndex = 2;
            // 
            // latitudLb
            // 
            this.latitudLb.AutoSize = true;
            this.latitudLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudLb.Location = new System.Drawing.Point(27, 342);
            this.latitudLb.Name = "latitudLb";
            this.latitudLb.Size = new System.Drawing.Size(51, 18);
            this.latitudLb.TabIndex = 3;
            this.latitudLb.Text = "Latitud";
            // 
            // longitudLb
            // 
            this.longitudLb.AutoSize = true;
            this.longitudLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudLb.Location = new System.Drawing.Point(31, 397);
            this.longitudLb.Name = "longitudLb";
            this.longitudLb.Size = new System.Drawing.Size(64, 18);
            this.longitudLb.TabIndex = 4;
            this.longitudLb.Text = "Longitud";
            // 
            // gmap
            // 
            this.gmap.AutoSize = true;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 48);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(776, 280);
            this.gmap.TabIndex = 5;
            this.gmap.Zoom = 13D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Marcador",
            "Poligono"});
            this.comboBox.Location = new System.Drawing.Point(144, 416);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 9;
            // 
            // tableBt
            // 
            this.tableBt.Location = new System.Drawing.Point(713, 12);
            this.tableBt.Name = "tableBt";
            this.tableBt.Size = new System.Drawing.Size(75, 23);
            this.tableBt.TabIndex = 10;
            this.tableBt.Text = "Abrir Tabla";
            this.tableBt.UseVisualStyleBackColor = true;
            this.tableBt.Click += new System.EventHandler(this.tableBt_Click);
            // 
            // filtrarLb
            // 
            this.filtrarLb.AutoSize = true;
            this.filtrarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarLb.Location = new System.Drawing.Point(541, 343);
            this.filtrarLb.Name = "filtrarLb";
            this.filtrarLb.Size = new System.Drawing.Size(49, 18);
            this.filtrarLb.TabIndex = 11;
            this.filtrarLb.Text = "Filtros";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(271, 342);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 43);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(271, 416);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(684, 397);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(104, 48);
            this.btnMostrarTodos.TabIndex = 14;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Japon",
            "Indonesia",
            "India",
            "Philippines",
            "China",
            "Brazil",
            "Korea, South",
            "Mexico",
            "Egypt",
            "United States",
            "Russia",
            "Thailand",
            "Argentina",
            "Bangladesh",
            "Nigeria",
            "Turkey",
            "Pakistan",
            "Iran",
            "Vietnam",
            "Colombia"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(544, 398);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Escoje el país para conocer su ubicación.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpiarMapa
            // 
            this.btnLimpiarMapa.Location = new System.Drawing.Point(403, 382);
            this.btnLimpiarMapa.Name = "btnLimpiarMapa";
            this.btnLimpiarMapa.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiarMapa.TabIndex = 17;
            this.btnLimpiarMapa.Text = "Limpiar Mapa";
            this.btnLimpiarMapa.UseVisualStyleBackColor = true;
            this.btnLimpiarMapa.Click += new System.EventHandler(this.btnLimpiarMapa_Click);
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnLimpiarMapa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.filtrarLb);
            this.Controls.Add(this.tableBt);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.longitudLb);
            this.Controls.Add(this.latitudLb);
            this.Controls.Add(this.latitudTxt);
            this.Controls.Add(this.longitudTxt);
            this.Name = "MapWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox longitudTxt;
        private System.Windows.Forms.TextBox latitudTxt;
        private System.Windows.Forms.Label latitudLb;
        private System.Windows.Forms.Label longitudLb;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button tableBt;
        private System.Windows.Forms.Label filtrarLb;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarMapa;
    }
}

