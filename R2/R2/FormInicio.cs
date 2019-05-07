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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (comboElegir.Text == "Arreglos")
            {
                Form FormMenuA = new FormArreglos();
                FormMenuA.Show();
            }
            if (comboElegir.Text == "Funciones")
            {
                Form FormMenuF = new FormFunciones();
                FormMenuF.Show();
            }
            if (comboElegir.Text == "Ciclos")
            {
                Form FormMenuC = new FormCiclos();
                FormMenuC.Show();
            }
            if (comboElegir.Text == "Condicionales")
            {
                Form FormMenuCo = new FormCondicionales();
                FormMenuCo.Show();
            }
            if (comboElegir.Text == "Secuenciales")
            {
                Form FormMenuS = new FormSecuanciales();
                FormMenuS.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
