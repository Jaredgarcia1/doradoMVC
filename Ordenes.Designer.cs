namespace doradoMVC
{
    partial class Ordenes
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sistemaIVDataSet = new doradoMVC.SistemaIVDataSet();
            this.sistemaIVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Imprimir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.Imprimir);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 398);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.dataGridView1.DataSource = this.sistemaIVDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sistemaIVDataSet
            // 
            this.sistemaIVDataSet.DataSetName = "SistemaIVDataSet";
            this.sistemaIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaIVDataSetBindingSource
            // 
            this.sistemaIVDataSetBindingSource.DataSource = this.sistemaIVDataSet;
            this.sistemaIVDataSetBindingSource.Position = 0;
            this.sistemaIVDataSetBindingSource.CurrentChanged += new System.EventHandler(this.sistemaIVDataSetBindingSource_CurrentChanged);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Factura
            // 
            this.Factura.AutoSize = true;
            this.Factura.Location = new System.Drawing.Point(57, 25);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(43, 13);
            this.Factura.TabIndex = 1;
            this.Factura.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num.01010";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Imprimir
            // 
            this.Imprimir.BackColor = System.Drawing.Color.Red;
            this.Imprimir.Location = new System.Drawing.Point(545, 239);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(75, 23);
            this.Imprimir.TabIndex = 1;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Red;
            this.Guardar.Location = new System.Drawing.Point(545, 197);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 519);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sistemaIVDataSetBindingSource;
        private SistemaIVDataSet sistemaIVDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label Factura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button Guardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}