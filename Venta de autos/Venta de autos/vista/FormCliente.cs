using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Venta_de_autos
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        } 
        
        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //String ruta = "e:\\logs.txt";
            StreamWriter escr = new StreamWriter(@"C:\Users\sport\Desktop\Clientes.txt", true);
            try
            {
                escr.WriteLine("Id: " + txtId.Text);
                escr.WriteLine("Nombre: " + txtNombre.Text);
                escr.WriteLine("Apellidos: " + txtApellidos.Text);
                escr.WriteLine("Dirección: " + txtDireccion.Text);
                escr.WriteLine("Teléfono: " + txtTelefono.Text);
                escr.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escr.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\sport\Desktop\Clientes.txt");
            string line; 
            try
            {
                line = leer.ReadLine();
                while(line != null)
                {
                    richTextBoxClient.AppendText(line + "\n");
                    line = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\sport\Desktop\Clientes.txt");

        }
    }
}
