using System;
using System.Windows.Forms;
using System.IO;

namespace FormInicio.vista
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if  (this.TxtUsuario.Text == "Admin" && TxtPassword.Text == "123")
            {
                //.Show();
                //Hide();
            } else
            {
                MessageBox.Show("Error de autenticación!!!");
            }

            
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
