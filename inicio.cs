using System;
using System.Drawing;
using System.Windows.Forms;

namespace doradoMVC
{
    public partial class inicio : Form
    {
        producButton btnActive;
        internal Action<object, EventArgs> formclosing;

        public inicio()
        {
            InitializeComponent();
        }
        // activamos el boton que se hace click para cambio de color
        void activar_focus(producButton btnfocus)
        {
            btnfocus.MainColor = Color.FromArgb(75, 158, 253);// cambia de color boton activo 

            if (btnfocus != btnActive)
            {
                btnActive.MainColor = Color.FromArgb(32, 43, 76);


            }
            btnActive = btnfocus;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            activar_focus(btnProducto);
            Producto fr = new Producto();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            activar_focus(btnInicio);
        }

        private void activar_focus(Button btnProducto)
        {
            throw new NotImplementedException();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            activar_focus(btnOrdenes);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            activar_focus(btnInventario);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            activar_focus(btnReporte);
        }
    }
}
