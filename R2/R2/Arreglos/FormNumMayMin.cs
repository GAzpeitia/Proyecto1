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
    public partial class FormNumMayMin : Form
    {
        public FormNumMayMin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int[] array = new int[10];
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                var v = random.Next(1, 50);
                listNum.Items.Add("Conteo [" + i + "] = " + v);
                array[i] = v;
            }
            txtNumMay.Text = array.Max().ToString();
            txtNumMin.Text = array.Min().ToString();
        
        }

        private void FormNumMayMin_Load(object sender, EventArgs e)
        {

        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtNumMay.Text = "";
            txtNumMin.Text = "";
            listNum.Text = "";
        }
    }
}
