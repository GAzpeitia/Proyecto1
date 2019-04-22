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
            richTextBoxClient.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter escr = new StreamWriter(@"C:\Users\sport\Desktop\Clientes.txt", true);
            try
            {
                escr.WriteLine(string.Format("{0};{1};{2};{3};{4}", txtId.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text));
                /*escr.WriteLine("Id: " + txtId.Text);
                escr.WriteLine("Nombre: " + txtNombre.Text);
                escr.WriteLine("Apellidos: " + txtApellidos.Text);
                escr.WriteLine("Dirección: " + txtDireccion.Text);
                escr.WriteLine("Teléfono: " + txtTelefono.Text);
                escr.WriteLine("\n");*/
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escr.Close();

            Cliente cliente1 = new Cliente();

            cliente1.Id = txtId.Text;
            cliente1.Nombre = txtNombre.Text;
            cliente1.Apellidos = txtApellidos.Text;
            cliente1.Direccion = txtDireccion.Text;
            cliente1.Telefono = txtTelefono.Text;

            textId.Text = cliente1.Id.ToString();
            textNombre.Text = cliente1.Nombre.ToString();
            textApe.Text = cliente1.Apellidos.ToString();
            textDir.Text = cliente1.Direccion.ToString();
            textTele.Text = cliente1.Telefono.ToString();
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
            
        }
    }
}
