
namespace Gmaps
{
    partial class Form1
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.Latitudtxt = new System.Windows.Forms.TextBox();
            this.Latitudlb = new System.Windows.Forms.Label();
            this.Longitudlb = new System.Windows.Forms.Label();
            this.Longitudtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(799, 373);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 13D;
            // 
            // Latitudtxt
            // 
            this.Latitudtxt.Location = new System.Drawing.Point(12, 379);
            this.Latitudtxt.Name = "Latitudtxt";
            this.Latitudtxt.Size = new System.Drawing.Size(100, 20);
            this.Latitudtxt.TabIndex = 1;
            // 
            // Latitudlb
            // 
            this.Latitudlb.AutoSize = true;
            this.Latitudlb.Location = new System.Drawing.Point(38, 402);
            this.Latitudlb.Name = "Latitudlb";
            this.Latitudlb.Size = new System.Drawing.Size(39, 13);
            this.Latitudlb.TabIndex = 2;
            this.Latitudlb.Text = "Latitud";
            // 
            // Longitudlb
            // 
            this.Longitudlb.AutoSize = true;
            this.Longitudlb.Location = new System.Drawing.Point(38, 441);
            this.Longitudlb.Name = "Longitudlb";
            this.Longitudlb.Size = new System.Drawing.Size(48, 13);
            this.Longitudlb.TabIndex = 3;
            this.Longitudlb.Text = "Longitud";
            // 
            // Longitudtxt
            // 
            this.Longitudtxt.Location = new System.Drawing.Point(12, 418);
            this.Longitudtxt.Name = "Longitudtxt";
            this.Longitudtxt.Size = new System.Drawing.Size(100, 20);
            this.Longitudtxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.Longitudtxt);
            this.Controls.Add(this.Longitudlb);
            this.Controls.Add(this.Latitudlb);
            this.Controls.Add(this.Latitudtxt);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox Latitudtxt;
        private System.Windows.Forms.Label Latitudlb;
        private System.Windows.Forms.Label Longitudlb;
        private System.Windows.Forms.TextBox Longitudtxt;
    }
}

