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
    public partial class FormL1 : Form
    {
        public FormL1()
        {
            InitializeComponent();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            string lista1, ca1, car2, ins;
            string cali1, cali2, cali3, cali4;
            string numero, nombre, ape, nomCar, insti, nomInst;
            StreamReader calific = new StreamReader("e:\\calificaciones.txt");

            while ((lista1 = calific.ReadLine()) != null)
            {
                string[] split = lista1.Split(new Char[] { ';' });
                numero = split[0];
                nombre = split[1];
                ape = split[2];
                ca1 = split[3];
                ins = split[4];
                cali1 = split[5];
                cali2 = split[6];
                cali3 = split[7];
                cali4 = split[8];
                richResp.Text = numero + " " + nombre + " " + ape;
            }
            calific.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
