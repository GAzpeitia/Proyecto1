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
    public partial class FormFunciones : Form
    {
        public FormFunciones()
        {
            InitializeComponent();
        }

        private void FormFunciones_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Form form12 = new FormDiv();
            form12.Show();
        }

        private void btnPerf_Click(object sender, EventArgs e)
        {
            Form form13 = new FormPerfectos();
            form13.Show();
        }

        private void btnAmi_Click(object sender, EventArgs e)
        {
            Form formQw = new FormAmigo();
            formQw.Show();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            Form form122 = new FormCom();
            form122.Show();
        }
    }
}
