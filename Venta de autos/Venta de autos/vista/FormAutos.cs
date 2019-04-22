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
    public partial class formAutos : Form
    {
        //mi conexion
        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        public formAutos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\sport\Desktop\Autos.txt");
            string line;
            try
            {
                line = leer.ReadLine();
                while (line != null)
                {
                    richTextBoxAutos.AppendText(line + "\n");
                    line = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        

        private void formAutos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter escr = new StreamWriter(@"C:\Users\sport\Desktop\Autos.txt", true);
            try
            {
                escr.WriteLine("Matrícula: " + txtMatricula.Text);
                escr.WriteLine("Modelo: " + txtModelo.Text);
                escr.WriteLine("Precio: " + txtPrecio.Text);
                escr.WriteLine("Marca: " + comboMarca.Text);
                escr.WriteLine("Color: " + comboColor.Text);
                escr.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escr.Close();
            /*if (txtMatricula.Text == "" && txtModelo.Text == "")
            {
                MessageBox.Show("No has escrito la matrícula ni el modelo"); 
            }
            else
            {
                try
                {
                    IDbCommand comando = connection.CreateCommand();
                    connection.Open();
                    connectionString = "insert into usuario (matricula,modelo,precio,marca,color)values(' + textBox1.Text + ','" + txtMatricula.Text + "','" + txtModelo.Text + "','" + txtPrecio.Text + "','" + comboMarca.Text + "','1','" + comboColor.Text + "',)";
                    //connectionion.ConnectionString = connectionString;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro Exitoso");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("insercion fallida");
                }
                listClient.Items.Add("     " + txtMatricula.Text + "                    " + txtModelo.Text + "                           " + txtPrecio.Text + "                       " + comboMarca.Text + "                            " + comboColor.Text);
            }*/
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
            comboMarca.Text = "";
            comboColor.Text = "";
        }
    }
}
