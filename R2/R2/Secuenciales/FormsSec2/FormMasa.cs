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
    public partial class FormMasa : Form
    {
        public FormMasa()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double imc, altu, masa;
            String nom;

            masa = double.Parse(txtRes2.Text);
            altu = double.Parse(txtRes3.Text);
            nom = txtRes1.Text;

                imc = masa / altu;
            richRes.Text = "\nEl IMC es de: " + imc;
            richRes.Text = "\nLa masa es de: " + masa + "kg";
            richRes.Text = "\nLa altura es de: " + altu + "m";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtRes1.Text = "";
            txtRes2.Text = "";
            txtRes3.Text = "";
            richRes.Text = "";
        }
    }
}
