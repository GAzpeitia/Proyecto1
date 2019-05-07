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
    public partial class FormNombres : Form
    {
        public FormNombres()
        {
            InitializeComponent();
        }

        private void FormNombres_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

        }

        private void btnSecuencia_Click(object sender, EventArgs e)
        {
            Form formLol = new FormList1();
            formLol.Show();
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            Form formLo = new FormLista2();
            formLo.Show();
        }

        private void btnApe_Click(object sender, EventArgs e)
        {
            Form formL = new FormLista3();
            formL.Show();
        }

        private void btnSepNom_Click(object sender, EventArgs e)
        {
            Form form12 = new FormLista4();
            form12.Show();
        }
    }
}
