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
    public partial class FormCom : Form
    {
        public FormCom()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int m, n, com = 1, com1 = 1, com2 = 1;
            int res = 0;
            m = int.Parse(txtNum1.Text);
            n = int.Parse(txtNum2.Text);

            if (m < n)
            {
                rich1.Text = "El valor de m debe ser más grande que el valor en n";
            }

            for (int i = m; i > 0; i--)
            {
                if (m == 0 || m == 1)
                {
                    com = 1;
                    break;
                }
                com = i * com;
            }

            for (int i = n; i > 0; i--)
            {
                if (n == 0 || n == 1)
                {
                    com1 = 1;
                    break;
                }
                com1 = i * com1;
            }

            for (int i = m - n; i > 0; i--)
            {
                if (m - n == 0 || m - n == 1)
                {
                    com2 = 1;
                    break;
                }
                com2 = i * com2;
            }

            res = com / (com1 * com2);

            rich1.Text = "\nEl valor de m es: " + m + "\nEl valor de n es: " + n + "\nEl valor combinado es: " + res;
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
