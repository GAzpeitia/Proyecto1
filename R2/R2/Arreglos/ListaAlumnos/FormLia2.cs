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
    public partial class FormLia2 : Form
    {
        public FormLia2()
        {
            InitializeComponent();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            string lista1, ins;
            string numero, nombre;
            StreamReader calific = new StreamReader("e:\\calificaciones.txt");
            while ((lista1 = calific.ReadLine()) != null)
            {
                string[] split = lista1.Split(new Char[] { ';' });
                numero = split[0];
                nombre = split[1];
                ins = split[4];
                richResp.Text = numero + " El alumno es " + nombre + " y su carrera es " + ins;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
