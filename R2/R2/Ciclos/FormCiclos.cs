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
    public partial class FormCiclos : Form
    {
        public FormCiclos()
        {
            InitializeComponent();
        }

        private void FormCiclos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new FormSaludar();
            form1.Show();
        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            Form form3 = new FormNombres();
            form3.Show();
        }

        private void btnCali_Click(object sender, EventArgs e)
        {
            Form formC = new FormCali();
            formC.Show();
        }
    }
}
