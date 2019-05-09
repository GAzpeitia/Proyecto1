using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace R2
{
    public partial class FormMayuMinu : Form
    {
        public FormMayuMinu()
        {
            InitializeComponent();
        }

        private void FormMayuMinu_Load(object sender, EventArgs e)
        {

        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            String name = "";

            name = txtEscr.Text;

            txtMay.Text = name.ToUpper();
            txtMin.Text = name.ToLower();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
