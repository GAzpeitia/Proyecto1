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
            double imc = 0, altu = 0, masa = 0;
            String nom = "";
            txtRes1.Text = nom;
            txtRes2.Text = masa.ToString();
            txtRes3.Text = altu.ToString();

                imc = masa / altu;
            richRes.Text = "\nEl IMC es de: " + imc;
            richRes.Text = "\nLa masa es de: " + masa + "kg";
            richRes.Text = "\nLa altura es de: " + altu + "m";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
