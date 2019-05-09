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
    public partial class FormHospital : Form
    {
        public FormHospital()
        {
            InitializeComponent();
        }

        private void FormHospital_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double can;
            double gine, trau, ped;
            can = double.Parse(txtCant.Text);

                gine = (40 * can) / 100;
                trau = (30 * can) / 100;
                ped = (30 * can) / 100;
            richRes.Text = "Cantidad anual dividida entre los departamentos:";
            richRes.Text = "\nGinecología: " + gine + " pesos";
            richRes.Text = "\nTraumatología: " + trau + " pesos";
            richRes.Text = "\nPediatría: " + ped + " pesos";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtCant.Text = "";
            richRes.Text = "";
        }
    }
}
