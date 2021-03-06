﻿using System;
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
        //MySqlConnection connection = new MySqlConnection();
        //String connectionString;
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
           
            if (txtMatricula.Text == "" && txtModelo.Text == "" && txtPrecio.Text == "" && comboMarca.Text == "" && comboColor.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar!!!");
            }
            else
            {
                try
                {
                    //escr.WriteLine(string.Format("{0};{1};{2};{3};{4}", txtMatricula.Text, txtModelo.Text, txtPrecio.Text, comboMarca.Text, comboColor.Text));
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

                Autos autos1 = new Autos();

                autos1.Matricula = txtMatricula.Text;
                autos1.Modelo = txtModelo.Text;
                autos1.Precio = txtPrecio.Text;
                autos1.Marca = comboMarca.Text;
                autos1.Color = comboColor.Text;

                textMatri.Text = autos1.Matricula.ToString();
                textMode.Text = autos1.Modelo.ToString();
                textPrec.Text = autos1.Precio.ToString();
                textMarca.Text = autos1.Marca.ToString();
                textColor.Text = autos1.Color.ToString();

            }
            
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
            richTextBoxAutos.Text = "";
            textMatri.Text = "";
            textMode.Text = "";
            textPrec.Text = "";
            textMarca.Text = "";
            textColor.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\sport\Desktop\Autos.txt"))
            {
                try
                {
                    File.Delete(@"C:\Users\sport\Desktop\Autos.txt");
                    MessageBox.Show("Se elimino el archivo exitosamente");
                }
                catch
                {
                    MessageBox.Show("Presione nuevamente para eliminar el archivo");
                }
            }
        }
    
    }
}
