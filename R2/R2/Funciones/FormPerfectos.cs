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
    public partial class FormPerfectos : Form
    {
        public FormPerfectos()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int num = 0;
            txtNum.Text = num.ToString(); 

            if (num > 0)
            {
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum = sum + i;
                    }

                }


                if (sum == num)
                {
                    richPerfec.Text = "\nEl numero " + num + " es perfecto ya que es igual a la suma de sus divisores propios positivos.";
                }
                else
                {
                    richPerfec.Text = "\nEl numero " + num + " no es perfecto ya que no es igual a la suma de sus divisores propios positivos.";
                }
            }
            else
            {
                richPerfec.Text = "No se aceptan números negativos";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
