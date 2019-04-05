using System;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

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
                FormMenu.Show();
                MySqlConnection conectar = new MySqlConnection("server=localhost;database=empresa_venta_auto;user id=root;password=;");
                MessageBox.Show("Estas conectado");
                //conectar.Open();
                // return conectar;
                TxtUsuario.Text = "";
                TxtPassword.Text = "";
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
            Close();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
