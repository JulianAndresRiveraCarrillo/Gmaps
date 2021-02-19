
namespace Gmaps.ui
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.label1 = new System.Windows.Forms.Label();
            this.filtroBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cargarBt1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriaBox = new System.Windows.Forms.ComboBox();
            this.cadenaBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Rango2 = new System.Windows.Forms.Label();
            this.Rango1 = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.filtroBox, "filtroBox");
            this.filtroBox.Name = "filtroBox";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // cargarBt1
            // 
            resources.ApplyResources(this.cargarBt1, "cargarBt1");
            this.cargarBt1.Name = "cargarBt1";
            this.cargarBt1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // categoriaBox
            // 
            this.categoriaBox.FormattingEnabled = true;
            resources.ApplyResources(this.categoriaBox, "categoriaBox");
            this.categoriaBox.Name = "categoriaBox";
            // 
            // cadenaBox
            // 
            resources.ApplyResources(this.cadenaBox, "cadenaBox");
            this.cadenaBox.Name = "cadenaBox";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
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
            // Data
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Rango1);
            this.Controls.Add(this.Rango2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cadenaBox);
            this.Controls.Add(this.categoriaBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cargarBt1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtroBox);
            this.Controls.Add(this.label1);
            this.Name = "Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filtroBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cargarBt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox categoriaBox;
        private System.Windows.Forms.TextBox cadenaBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Rango2;
        private System.Windows.Forms.Label Rango1;
    }
}