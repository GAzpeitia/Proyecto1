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
    public partial class FormCambioDivisa : Form
    {
        public FormCambioDivisa()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double mex = 0, doll = 0, eur = 0;
            String m;
                m = txt1.Text;
                mex = Double.Parse(m);

                doll = (mex / 2) / 19.75;
                eur = (mex / 2 / 19.75) * 0.887;
            richRes.Text = "Usted ingreso " + mex + " pesos mexicanos";
            richRes.Text = "La cantidad de dolares es: " + doll;
            richRes.Text = "La cantidad de euros es: " + eur;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            richRes.Text = "";
        }
    }
}
