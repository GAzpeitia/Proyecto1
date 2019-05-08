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
    public partial class FormRaices : Form
    {
        public FormRaices()
        {
            InitializeComponent();
        }

        private void FormRaices_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;
            txtRaiz.Text = a.ToString();
            txtB.Text = b.ToString();
            txtC.Text = c.ToString();

                x1 = ((-1 * b) + Math.Sqrt((Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
                x2 = ((-1 * b) - Math.Sqrt((Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
            richRes.Text = "x1 es igual: " + x1;
            richRes.Text = "x2 es igual: " + x2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
