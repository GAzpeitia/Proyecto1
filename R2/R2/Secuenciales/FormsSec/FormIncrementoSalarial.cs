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
    public partial class FormIncrementoSalarial : Form
    {
        public FormIncrementoSalarial()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double salario, salTot, salP;
            salario = double.Parse(txtSal.Text);

                salTot = salario * 0.25;
                salP = salTot + salario;
            richRes.Text = "El aumento sobre el sueldo es de: " + salTot;
            richRes.Text = "El salario total con el 25% es de: " + salP;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtSal.Text = "";
            richRes.Text = "";
        }
    }
}
