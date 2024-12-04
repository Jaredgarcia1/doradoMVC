using System;
using System.Windows.Forms;



namespace doradoMVC
{
    public partial class login : Form
    {
        Controladore.MainController oMainController = new Controladore.MainController();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oMainController.Getlist();
        }

        // esto es para cuando se cierra
        //se retorna al login

        private void frm_closing(object sender, EventArgs e)
        {

            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            inicio form = new inicio();

            form.ShowDialog();
            this.Hide();

            form.formclosing += frm_closing;
        }
    }
}
