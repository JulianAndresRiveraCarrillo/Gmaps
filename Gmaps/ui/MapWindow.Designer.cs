
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
            this.puntosBt = new System.Windows.Forms.Button();
            this.poligonosBt = new System.Windows.Forms.Button();
            this.mostrarBt = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.tableBt = new System.Windows.Forms.Button();
            this.filtrarLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // longitudTxt
            // 
            this.longitudTxt.Location = new System.Drawing.Point(118, 418);
            this.longitudTxt.Name = "longitudTxt";
            this.longitudTxt.Size = new System.Drawing.Size(100, 20);
            this.longitudTxt.TabIndex = 1;
            // 
            // latitudTxt
            // 
            this.latitudTxt.Location = new System.Drawing.Point(12, 418);
            this.latitudTxt.Name = "latitudTxt";
            this.latitudTxt.Size = new System.Drawing.Size(100, 20);
            this.latitudTxt.TabIndex = 2;
            // 
            // latitudLb
            // 
            this.latitudLb.AutoSize = true;
            this.latitudLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudLb.Location = new System.Drawing.Point(27, 398);
            this.latitudLb.Name = "latitudLb";
            this.latitudLb.Size = new System.Drawing.Size(51, 18);
            this.latitudLb.TabIndex = 3;
            this.latitudLb.Text = "Latitud";
            // 
            // longitudLb
            // 
            this.longitudLb.AutoSize = true;
            this.longitudLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudLb.Location = new System.Drawing.Point(137, 398);
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
            this.gmap.Location = new System.Drawing.Point(12, 12);
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
            this.gmap.Size = new System.Drawing.Size(660, 383);
            this.gmap.TabIndex = 5;
            this.gmap.Zoom = 13D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // puntosBt
            // 
            this.puntosBt.Location = new System.Drawing.Point(516, 418);
            this.puntosBt.Name = "puntosBt";
            this.puntosBt.Size = new System.Drawing.Size(75, 23);
            this.puntosBt.TabIndex = 6;
            this.puntosBt.Text = "Marcadores";
            this.puntosBt.UseVisualStyleBackColor = true;
            this.puntosBt.Click += new System.EventHandler(this.puntosBt_Click);
            // 
            // poligonosBt
            // 
            this.poligonosBt.Location = new System.Drawing.Point(516, 444);
            this.poligonosBt.Name = "poligonosBt";
            this.poligonosBt.Size = new System.Drawing.Size(75, 23);
            this.poligonosBt.TabIndex = 7;
            this.poligonosBt.Text = "Poligonos";
            this.poligonosBt.UseVisualStyleBackColor = true;
            this.poligonosBt.Click += new System.EventHandler(this.poligonosBt_Click);
            // 
            // mostrarBt
            // 
            this.mostrarBt.Location = new System.Drawing.Point(398, 416);
            this.mostrarBt.Name = "mostrarBt";
            this.mostrarBt.Size = new System.Drawing.Size(75, 23);
            this.mostrarBt.TabIndex = 8;
            this.mostrarBt.Text = "Mostrar";
            this.mostrarBt.UseVisualStyleBackColor = true;
            this.mostrarBt.Click += new System.EventHandler(this.mostrarBt_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(271, 417);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 9;
            // 
            // tableBt
            // 
            this.tableBt.Location = new System.Drawing.Point(597, 428);
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
            this.filtrarLb.Location = new System.Drawing.Point(527, 398);
            this.filtrarLb.Name = "filtrarLb";
            this.filtrarLb.Size = new System.Drawing.Size(49, 18);
            this.filtrarLb.TabIndex = 11;
            this.filtrarLb.Text = "Filtros";
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 474);
            this.Controls.Add(this.filtrarLb);
            this.Controls.Add(this.tableBt);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.mostrarBt);
            this.Controls.Add(this.poligonosBt);
            this.Controls.Add(this.puntosBt);
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
        private System.Windows.Forms.Button puntosBt;
        private System.Windows.Forms.Button poligonosBt;
        private System.Windows.Forms.Button mostrarBt;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button tableBt;
        private System.Windows.Forms.Label filtrarLb;
    }
}

