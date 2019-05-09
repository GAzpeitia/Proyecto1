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
    public partial class FormFrecuenciaCardiaca : Form
    {
        public FormFrecuenciaCardiaca()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double fcm;
            double lpm = 220;
            int eda;
            eda = int.Parse(txt1.Text);

                fcm = lpm - eda;
            richRes.Text = "Su frecuencia máxima es: " + fcm;
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
