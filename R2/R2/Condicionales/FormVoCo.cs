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
    public partial class FormVoCo : Form
    {
        public FormVoCo()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            String name = "";

                name = txtNom.Text;

                String letra = name.Substring(0, 1);


                if (name.Length > 3 && name.Length < 30)
                {

                    switch (letra)
                    {
                        case "a":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                            break;
                        case "A":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                            break;
                        case "e":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "E":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "i":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "I":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "o":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "O":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "u":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        case "U":
                        txtRes.Text = "La letra " + letra + " es una vocal.";
                        break;
                        default:
                        txtRes.Text = "La letra " + letra + " es una consonante.";
                            break;
                    }//Fin switch
                }//Fin If
                else
                {
                    txtAviso.Text = "¡Ingrese un nombre menor a 30 carácteres y mayor de 3 carácteres!";
                }//Fin If else
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVoCo_Load(object sender, EventArgs e)
        {

        }
    }
}
