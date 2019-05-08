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
            double fcm = 0;
            double lpm = 220;
            int eda = 0;
            txt1.Text = eda.ToString();

                fcm = lpm - eda;
            richRes.Text = "Su frecuencia máxima es: " + fcm;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
