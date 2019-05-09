using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace R2
{
    public partial class FormCali : Form
    {
        public FormCali()
        {
            InitializeComponent();
        }

        private void FormCali_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSecuencia_Click(object sender, EventArgs e)
        {
            Form f = new FormL1();
            f.Show();
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            Form f = new FormL2();
            f.Show();
        }

        private void btnApe_Click(object sender, EventArgs e)
        {
            Form f = new FormL3();
            f.Show();
        }

        private void btnSepNom_Click(object sender, EventArgs e)
        {
            Form f = new FormL4();
            f.Show();
        }
    }
}
