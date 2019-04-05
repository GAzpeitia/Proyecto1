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

namespace Venta_de_autos
{
    public partial class formAutos : Form
    {
        public formAutos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
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
            if (txtMatricula.Text == "" && txtModelo.Text == "")
            {
                MessageBox.Show("No has escrito la matrícula ni el modelo"); 
            }
            else
            {
                //MySqlConnection conectar = new MySqlConnection("INSERT INTO tab_coche VALUES('" & txtMatricula.Text & "','" & txtModelo.Text & "','" & txtPrecio.Text & "','" & comboMarca.Text & "','" & comboColor.Text & "'," & (0) & ")");
            }
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
