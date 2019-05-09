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
    public partial class FormNumVoCo : Form
    {
        public FormNumVoCo()
        {
            InitializeComponent();
        }

        private void FormNumVoCo_Load(object sender, EventArgs e)
        {

        }
        class Frase
        {
            public static int[] Palabras(string frase)
            {
                int palabras = 1;
                int caracterestotales = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ' || frase[i] == '.')
                    {
                        palabras++;
                    }
                }
                int[] Palabras = new int[2];
                caracterestotales = frase.Length;
                Palabras[0] = palabras;
                Palabras[1] = caracterestotales;
                return Palabras;
            }
        }
        private void btnCal_Click(object sender, EventArgs e)
        {
            //string palabra = "";
            int cont1 = 0, cont2 = 2, conso = 0;

            //Console.WriteLine("Ingrese una frase");
            string frase = txtEscr.Text;
            int[] resultado = Frase.Palabras(frase);

            for (int i = 0; i <= frase.Length; i++)
            {
                cont1++;
            }
            for (int i = 0; i < frase.Length; i++)
            {
                if ((frase[i] == 'a') || (frase[i] == 'e') || (frase[i] == 'i') || (frase[i] == 'o') || (frase[i] == 'u'))
                {
                    cont2++;
                }
            }
            conso = cont1 - cont2;

            txtNumP.Text = resultado[0].ToString();
            txtCara.Text = resultado[1].ToString();
            txtVoc.Text = cont2.ToString();
            txtConso.Text = conso.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtCara.Text = "";
            txtConso.Text = "";
            txtEscr.Text = "";
            txtNumP.Text = "";
            txtVoc.Text = "";

        }
    }
}
