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
    public partial class FormHipotenusa : Form
    {
        public FormHipotenusa()
        {
            InitializeComponent();
        }

        private void FormHipotenusa_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double c, a, b;
            a = double.Parse(txtRes1.Text);
            b = double.Parse(txtRes2.Text);

                c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            richRes.Text = "\nLa hipotenusa es: " + c;
            richRes.Text = "\nEl cateto opuesto vale: " + a;
            richRes.Text = "\nEl cateto adyasente vale: " + b;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtRes1.Text = "";
            txtRes2.Text = "";
            richRes.Text = "";
        }
    }
}
