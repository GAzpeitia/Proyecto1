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
    public partial class FormDiv : Form
    {
        public FormDiv()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int Resto1;
            int Resultado1;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            if ((num1 > 0) && (num2 > 0))
            {

                Resultado1 = num1 / num2;
                Resto1 = num1 % num2; // % es divisible.
                rich1.Text = "El Divisor es: " + num1 + "\nEntre el Dividendo: " + num2 + "\nEl cociente es: {2}" + Resultado1 + "\nEl resto es: " + Resto1;
            }
            else
            {
                rich1.Text = "Solo números enteros y positivos";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            rich1.Text = "";
        }
    }
}
