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
    public partial class FormValorAbsoluto : Form
    {
        public FormValorAbsoluto()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double num;
            num = double.Parse(txt1.Text);
                num = Math.Abs(num);
            richRes.Text = "\nEl valor absoluto es: " + num;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            richRes.Text = "";
        }
    }
}
