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
    public partial class FormTiendaLlantera : Form
    {
        public FormTiendaLlantera()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int llan, monto;

            llan = int.Parse(txtPrecio.Text);

                if (llan <= 50 && llan > 0)
                {

                    if (llan > 5)
                    {
                        monto = llan * 700;
                    }
                    else
                    {
                        monto = llan * 800;
                    }
                txtCant.Text = monto.ToString();
                }
                else
                {
                    //file.WriteLine("El dato " + llan + " es erroneo");
                txtMen.Text = "No puede elegir más de 50 llantas o menos de 0.";
                }
            //file.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCant.Text = "";
            txtMen.Text = "";
            txtPrecio.Text = "";
        }
    }
}
