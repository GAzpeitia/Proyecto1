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
    public partial class FormForGene : Form
    {
        public FormForGene()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double a, b, c, b1, a1, b2;
            double x1, x2;

            a = double.Parse(txtValA.Text);
            b = double.Parse(txtValB.Text);
            c = double.Parse(txtValC.Text);

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
                x1 = double.Parse(txtRes1.Text);
                x2 = double.Parse(txtRes2.Text);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormForGene_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRes1.Text = "";
            txtRes2.Text = "";
            txtValA.Text = "";
            txtValB.Text = "";
            txtValC.Text = "";
        }
    }
}
