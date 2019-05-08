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
    public partial class FormArticulo : Form
    {
        public FormArticulo()
        {
            InitializeComponent();
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            String nomArt = "";
            double pres = 0, gan = 0, tot = 0;
            txtRes1.Text = nomArt;
            txtRes2.Text = pres.ToString();

                gan = (pres * 30) / 100;
                tot = gan + pres;
            richRes.Text = "Incremento de(l) " + nomArt + " solicitado: $" + gan;
            richRes.Text = "Total a vender: $" + tot;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
