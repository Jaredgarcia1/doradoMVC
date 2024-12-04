namespace doradoMVC
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PANADERIA TRIGO DORADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(12, 86);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(145, 57);
            this.btnInicio.TabIndex = 9;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(12, 149);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(145, 57);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(12, 212);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(145, 57);
            this.btnOrdenes.TabIndex = 11;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(12, 275);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(145, 57);
            this.btnInventario.TabIndex = 12;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(12, 338);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(145, 57);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnReporte;
    }
}