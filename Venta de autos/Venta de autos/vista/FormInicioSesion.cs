using System;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Diagnostics;

namespace Venta_de_autos
{
    public partial class FormInicioSesion : Form
    {
        //mi conexion
        //MySqlConnection connection = new MySqlConnection();
        //String connectionString;
        public FormInicioSesion()
        {
            InitializeComponent();

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.TxtUsuario.Text == "Admin" && TxtPassword.Text == "123")
            {
                Form FormMenu = new formMenu();
                FormMenu.Show();
                /*try
                {
                    connectionString = "server=localhost;database=empresa_venta_auto;user id=root;password=;";
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    MessageBox.Show("Conexion Exitosa");
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error de Conexion, :( ");
                }*/
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
