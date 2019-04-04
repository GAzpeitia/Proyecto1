using System;
using System.Windows.Forms;
using System.IO;

namespace Venta_de_autos
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
                Form FormMenu = new formMenu();
                FormMenu.Hide();
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
            this.Close();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            //this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
