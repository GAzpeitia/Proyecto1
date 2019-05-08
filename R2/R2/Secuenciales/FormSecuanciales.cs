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
    public partial class FormSecuanciales : Form
    {
        public FormSecuanciales()
        {
            InitializeComponent();
        }

        private void FormSecuanciales_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formDiv = new FormDiv();
            formDiv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formA = new FormValorAbsoluto();
            formA.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formF = new FormFrecuenciaCardiaca();
            formF.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formI = new FormIncrementoSalarial();
            formI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formR = new FormRaices();
            formR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formH = new FormHospital();
            formH.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formAr = new FormArticulo();
            formAr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formHipo = new FormHipotenusa();
            formHipo.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formIn = new FormMasa();
            formIn.Show();
        }
    }
}
