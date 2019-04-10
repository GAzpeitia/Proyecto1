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
using MySql.Data;

namespace Venta_de_autos
{
    public partial class formMenu : Form
    {
        //mi conexion
        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        public formMenu()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormAutos = new formAutos();
            FormAutos.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Form FormClient = new formCliente();
            FormClient.Show();
        }
    }
}
