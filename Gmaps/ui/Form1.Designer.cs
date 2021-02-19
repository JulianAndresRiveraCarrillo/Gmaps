
namespace Gmaps
{
    partial class Mapa
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.longitudTxt = new System.Windows.Forms.TextBox();
            this.latitudTxt = new System.Windows.Forms.TextBox();
            this.latitudLb = new System.Windows.Forms.Label();
            this.longitudLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gmap
            // 
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
            this.gmap.Size = new System.Drawing.Size(660, 374);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 13D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // longitudTxt
            // 
            this.longitudTxt.Location = new System.Drawing.Point(150, 418);
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
            this.latitudLb.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudLb.Location = new System.Drawing.Point(27, 398);
            this.latitudLb.Name = "latitudLb";
            this.latitudLb.Size = new System.Drawing.Size(62, 17);
            this.latitudLb.TabIndex = 3;
            this.latitudLb.Text = "Latitud";
            // 
            // longitudLb
            // 
            this.longitudLb.AutoSize = true;
            this.longitudLb.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudLb.Location = new System.Drawing.Point(163, 398);
            this.longitudLb.Name = "longitudLb";
            this.longitudLb.Size = new System.Drawing.Size(73, 17);
            this.longitudLb.TabIndex = 4;
            this.longitudLb.Text = "Longitud";
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.longitudLb);
            this.Controls.Add(this.latitudLb);
            this.Controls.Add(this.latitudTxt);
            this.Controls.Add(this.longitudTxt);
            this.Controls.Add(this.gmap);
            this.Name = "Mapa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.TextBox longitudTxt;
        private System.Windows.Forms.TextBox latitudTxt;
        private System.Windows.Forms.Label latitudLb;
        private System.Windows.Forms.Label longitudLb;
    }
}

