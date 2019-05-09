using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2
{
    public partial class FormCondicionales : Form
    {
        public FormCondicionales()
        {
            InitializeComponent();
        }

        private void FormCondicionales_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            Form form1 = new FormTiendaLlantera();
            form1.Show();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            Form form7 = new FormForGene();
            form7.Show();
        }

        private void btnVoCo_Click(object sender, EventArgs e)
        {
            Form form4 = new FormVoCo();
            form4.Show();
        }

        private void btnMayMin_Click(object sender, EventArgs e)
        {
            Form form4w = new FormMayuMinu();
            form4w.Show();
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            Form form4s = new FormNumeLetra();
            form4s.Show();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            Form m = new FormMeses();
            m.Show();
        }
    }
}
