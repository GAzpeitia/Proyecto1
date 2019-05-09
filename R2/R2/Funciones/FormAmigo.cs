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
    public partial class FormAmigo : Form
    {
        public FormAmigo()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int sum1 = 0, sum2 = 0;
            num1 = int.Parse(txtNum1.Text);
            //num1 = Convert.ToInt32(Console.ReadLine());

            num2 = int.Parse(txtNum2.Text);
            //num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 += i;
                }
            }
            for (int i = 1; i <= num2 / 2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 += i;
                }
            }


            if ((num1 > 0) && (num2 > 0))
            {
                if ((num1 == sum2) && (num2 == sum1) || (sum1 == sum2))
                {
                    rich1.Text = "los numeros " + num1 + " y " + num2 + " si son numeros amigos, la suma de los divisores propios de uno es igual al otro número";
                }
                else
                {
                    rich1.Text = "los numeros " + num1 + " y " + num2 + " no son numeros amigos, la suma de los divisores propios de uno no es igual al otro número";
                }
            }
            else
            {
                rich1.Text = "Los números deben ser positivos o no son amigos";
            }
        }

        private void FormAmigo_Load(object sender, EventArgs e)
        {

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
