using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2.Condicionales
{
    public partial class FormForGene : Form
    {
        public FormForGene()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, b1 = 0, a1 = 0, b2 = 0;
            double x1 = 0, x2 = 0;

            txtValA.Text = a.ToString();
            txtValB.Text = b.ToString();
            txtValC.Text = c.ToString();

            b1 = (Math.Pow(b, 2) - (4 * a * c));
            b2 = -1 * b;
            a1 = 2 * a;
            x1 = (((b2 + Math.Sqrt(b1))) / a1);
            x2 = (((b2 - Math.Sqrt(b1))) / a1);

            if (b1 < 0)
            {
                txtRes1.Text = b2.ToString() + "+(" + b1.ToString() + "i)" + "/" + a1.ToString();
                txtRes2.Text = b2.ToString() + "-(" + b1.ToString() + "i)" + "/" + a1.ToString();
            }
            else
            {
                txtRes1.Text = x1.ToString();
                txtRes2.Text = x2.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
