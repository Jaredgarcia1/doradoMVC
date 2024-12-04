namespace doradoMVC
{
    partial class Inventario
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
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaIVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaIVDataSet = new doradoMVC.SistemaIVDataSet();
            this.IdProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reporteTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.ReporteTableAdapter();
            this.pedidoTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.PedidoTableAdapter();
            this.pedidoTableAdapter2 = new doradoMVC.SistemaIVDataSetTableAdapters.PedidoTableAdapter();
            this.inventarioTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.InventarioTableAdapter();
            this.detalleVentaTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.DetalleVentaTableAdapter();
            this.contieneTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.ContieneTableAdapter();
            this.contieneTableAdapter2 = new doradoMVC.SistemaIVDataSetTableAdapters.ContieneTableAdapter();
            this.auditoriaTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.AuditoriaTableAdapter();
            this.sistemaIVDataSet1 = new doradoMVC.SistemaIVDataSet();
            this.reporteTableAdapter2 = new doradoMVC.SistemaIVDataSetTableAdapters.ReporteTableAdapter();
            this.ventaTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.VentaTableAdapter();
            this.vistaReportesTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.VistaReportesTableAdapter();
            this.vistaVentasTableAdapter1 = new doradoMVC.SistemaIVDataSetTableAdapters.VistaVentasTableAdapter();
            this.vistaReportesTableAdapter2 = new doradoMVC.SistemaIVDataSetTableAdapters.VistaReportesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(40, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 282);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Ingredientes,
            this.ExistenciaProducto});
            this.dataGridView1.DataSource = this.sistemaIVDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "IDProducto";
            this.Producto.Name = "Producto";
            // 
            // Ingredientes
            // 
            this.Ingredientes.HeaderText = "undProduct";
            this.Ingredientes.Name = "Ingredientes";
            // 
            // ExistenciaProducto
            // 
            this.ExistenciaProducto.HeaderText = "ExistenciaProducto";
            this.ExistenciaProducto.Name = "ExistenciaProducto";
            // 
            // sistemaIVDataSetBindingSource
            // 
            this.sistemaIVDataSetBindingSource.DataSource = this.sistemaIVDataSet;
            this.sistemaIVDataSetBindingSource.Position = 0;
            // 
            // sistemaIVDataSet
            // 
            this.sistemaIVDataSet.DataSetName = "SistemaIVDataSet";
            this.sistemaIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSize = true;
            this.IdProducto.Location = new System.Drawing.Point(13, 13);
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Size = new System.Drawing.Size(59, 13);
            this.IdProducto.TabIndex = 1;
            this.IdProducto.Text = "IdProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ActualizarUndsProdu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // reporteTableAdapter1
            // 
            this.reporteTableAdapter1.ClearBeforeFill = true;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // pedidoTableAdapter2
            // 
            this.pedidoTableAdapter2.ClearBeforeFill = true;
            // 
            // inventarioTableAdapter1
            // 
            this.inventarioTableAdapter1.ClearBeforeFill = true;
            // 
            // detalleVentaTableAdapter1
            // 
            this.detalleVentaTableAdapter1.ClearBeforeFill = true;
            // 
            // contieneTableAdapter1
            // 
            this.contieneTableAdapter1.ClearBeforeFill = true;
            // 
            // contieneTableAdapter2
            // 
            this.contieneTableAdapter2.ClearBeforeFill = true;
            // 
            // auditoriaTableAdapter1
            // 
            this.auditoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // sistemaIVDataSet1
            // 
            this.sistemaIVDataSet1.DataSetName = "SistemaIVDataSet";
            this.sistemaIVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTableAdapter2
            // 
            this.reporteTableAdapter2.ClearBeforeFill = true;
            // 
            // ventaTableAdapter1
            // 
            this.ventaTableAdapter1.ClearBeforeFill = true;
            // 
            // vistaReportesTableAdapter1
            // 
            this.vistaReportesTableAdapter1.ClearBeforeFill = true;
            // 
            // vistaVentasTableAdapter1
            // 
            this.vistaVentasTableAdapter1.ClearBeforeFill = true;
            // 
            // vistaReportesTableAdapter2
            // 
            this.vistaReportesTableAdapter2.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdProducto);
            this.Controls.Add(this.panel1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaIVDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sistemaIVDataSetBindingSource;
        private SistemaIVDataSet sistemaIVDataSet;
        private System.Windows.Forms.Label IdProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private SistemaIVDataSetTableAdapters.ReporteTableAdapter reporteTableAdapter1;
        private SistemaIVDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter1;
        private SistemaIVDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter2;
        private SistemaIVDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter1;
        private SistemaIVDataSetTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter1;
        private SistemaIVDataSetTableAdapters.ContieneTableAdapter contieneTableAdapter1;
        private SistemaIVDataSetTableAdapters.ContieneTableAdapter contieneTableAdapter2;
        private SistemaIVDataSetTableAdapters.AuditoriaTableAdapter auditoriaTableAdapter1;
        private SistemaIVDataSet sistemaIVDataSet1;
        private SistemaIVDataSetTableAdapters.ReporteTableAdapter reporteTableAdapter2;
        private SistemaIVDataSetTableAdapters.VentaTableAdapter ventaTableAdapter1;
        private SistemaIVDataSetTableAdapters.VistaReportesTableAdapter vistaReportesTableAdapter1;
        private SistemaIVDataSetTableAdapters.VistaVentasTableAdapter vistaVentasTableAdapter1;
        private SistemaIVDataSetTableAdapters.VistaReportesTableAdapter vistaReportesTableAdapter2;
    }
}