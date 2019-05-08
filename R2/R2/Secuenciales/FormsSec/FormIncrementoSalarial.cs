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
            double salario = 0, salTot = 0, salP = 0;
            txtSal.Text = salario.ToString();

                salTot = salario * 0.25;
                salP = salTot + salario;
            richRes.Text = "El aumento sobre el sueldo es de: " + salTot;
            richRes.Text = "El salario total con el 25% es de: " + salP;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
