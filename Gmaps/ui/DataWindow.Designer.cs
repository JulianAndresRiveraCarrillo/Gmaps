
namespace Gmaps.ui
{
    partial class DataWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.filtroBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cargarBt = new System.Windows.Forms.Button();
            this.graficoBt = new System.Windows.Forms.Button();
            this.graficoBox = new System.Windows.Forms.ComboBox();
            this.categoriaBox = new System.Windows.Forms.ComboBox();
            this.cadenaBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.Rango2 = new System.Windows.Forms.Label();
            this.Rango1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mapBt = new System.Windows.Forms.Button();
            this.filtrar = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Ok2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // filtroBox
            // 
            this.filtroBox.FormattingEnabled = true;
            this.filtroBox.Items.AddRange(new object[] {
            resources.GetString("filtroBox.Items"),
            resources.GetString("filtroBox.Items1"),
            resources.GetString("filtroBox.Items2")});
            resources.ApplyResources(this.filtroBox, "filtroBox");
            this.filtroBox.Name = "filtroBox";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // cargarBt
            // 
            resources.ApplyResources(this.cargarBt, "cargarBt");
            this.cargarBt.Name = "cargarBt";
            this.cargarBt.UseVisualStyleBackColor = true;
            this.cargarBt.Click += new System.EventHandler(this.cargarBt_Click);
            // 
            // graficoBt
            // 
            resources.ApplyResources(this.graficoBt, "graficoBt");
            this.graficoBt.Name = "graficoBt";
            this.graficoBt.UseVisualStyleBackColor = true;
            this.graficoBt.Click += new System.EventHandler(this.graficoBt_Click);
            // 
            // graficoBox
            // 
            this.graficoBox.FormattingEnabled = true;
            this.graficoBox.Items.AddRange(new object[] {
            resources.GetString("graficoBox.Items"),
            resources.GetString("graficoBox.Items1"),
            resources.GetString("graficoBox.Items2")});
            resources.ApplyResources(this.graficoBox, "graficoBox");
            this.graficoBox.Name = "graficoBox";
            // 
            // categoriaBox
            // 
            this.categoriaBox.FormattingEnabled = true;
            this.categoriaBox.Items.AddRange(new object[] {
            resources.GetString("categoriaBox.Items"),
            resources.GetString("categoriaBox.Items1"),
            resources.GetString("categoriaBox.Items2")});
            resources.ApplyResources(this.categoriaBox, "categoriaBox");
            this.categoriaBox.Name = "categoriaBox";
            // 
            // cadenaBox
            // 
            this.cadenaBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cadenaBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.cadenaBox, "cadenaBox");
            this.cadenaBox.Name = "cadenaBox";
            this.cadenaBox.TextChanged += new System.EventHandler(this.cadenaBox_TextChanged);
            // 
            // minBox
            // 
            resources.ApplyResources(this.minBox, "minBox");
            this.minBox.Name = "minBox";
            // 
            // maxBox
            // 
            resources.ApplyResources(this.maxBox, "maxBox");
            this.maxBox.Name = "maxBox";
            // 
            // Rango2
            // 
            resources.ApplyResources(this.Rango2, "Rango2");
            this.Rango2.Name = "Rango2";
            // 
            // Rango1
            // 
            resources.ApplyResources(this.Rango1, "Rango1");
            this.Rango1.Name = "Rango1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // mapBt
            // 
            resources.ApplyResources(this.mapBt, "mapBt");
            this.mapBt.Name = "mapBt";
            this.mapBt.UseVisualStyleBackColor = true;
            this.mapBt.Click += new System.EventHandler(this.mapBt_Click);
            // 
            // filtrar
            // 
            resources.ApplyResources(this.filtrar, "filtrar");
            this.filtrar.Name = "filtrar";
            this.filtrar.UseVisualStyleBackColor = true;
            this.filtrar.Click += new System.EventHandler(this.filtrar_Click);
            // 
            // Ok
            // 
            resources.ApplyResources(this.Ok, "Ok");
            this.Ok.Name = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Ok2
            // 
            resources.ApplyResources(this.Ok2, "Ok2");
            this.Ok2.Name = "Ok2";
            this.Ok2.UseVisualStyleBackColor = true;
            this.Ok2.Click += new System.EventHandler(this.Ok2_Click);
            // 
            // DataWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ok2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.mapBt);
            this.Controls.Add(this.Rango1);
            this.Controls.Add(this.Rango2);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.cadenaBox);
            this.Controls.Add(this.categoriaBox);
            this.Controls.Add(this.graficoBox);
            this.Controls.Add(this.graficoBt);
            this.Controls.Add(this.cargarBt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtroBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DataWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filtroBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cargarBt;
        private System.Windows.Forms.Button graficoBt;
        private System.Windows.Forms.ComboBox graficoBox;
        private System.Windows.Forms.ComboBox categoriaBox;
        private System.Windows.Forms.TextBox cadenaBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label Rango2;
        private System.Windows.Forms.Label Rango1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button mapBt;
        private System.Windows.Forms.Button filtrar;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Ok2;
    }
}