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
    public partial class FormListAlu : Form
    {
        public FormListAlu()
        {
            InitializeComponent();
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListAlu_Load(object sender, EventArgs e)
        {

        }

        private void btnLista1_Click(object sender, EventArgs e)
        {
            Form form78 = new FormLista1();
            form78.Show();
        }

        private void btnLista2_Click(object sender, EventArgs e)
        {
            Form form13 = new FormLia2();
            form13.Show();
        }
    }
}
