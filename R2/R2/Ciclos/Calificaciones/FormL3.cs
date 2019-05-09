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
    public partial class FormL3 : Form
    {
        public FormL3()
        {
            InitializeComponent();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            int ca; 
            string lista1;
            string numero, nombre, ape, insti, nomInst;
            StreamReader calific = new StreamReader("e:\\calificaciones.txt");

            Console.WriteLine("Ingresa el nombre de la institución");
            insti = txtEscri.Text;
            ca = insti.Length;

            if (ca > 3 && ca < 30)
            {
                switch (insti)
                {
                    case "CBTis 75":
                    case "cbtis 75":
                    case "CBtis 75":
                    case "CBTis75":
                    case "cbtis75":
                    case "CBtis75":
                    case "CBTIS":
                    case "cbtis":
                    case "CBTIS 75":
                    case "Cbtis 75":
                        nomInst = "CBTIS 75";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            insti = split[3];

                            if (split[3] == nomInst)
                            {
                                richResp.Text = (nombre + " " + ape + " " + insti);

                            }
                            else
                            {
                                richResp.Text = ("La opción no existe!!!");
                            }

                        }
                        break;
                    case "rebsamen":
                    case "Rebsamen":
                    case "Rébsamen":
                    case "REBSAMEN":
                        nomInst = "Rébsamen";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            insti = split[3];

                            if (split[3] == nomInst)
                            {
                                richResp.Text = (nombre + " " + ape + " " + insti);

                            }
                            else
                            {
                                richResp.Text = ("La opción no existe!!!");
                            }
                        }
                        break;
                    default:
                        richResp.Text = "La institución es inexistente";
                        break;
                }

            }
            else
            {
                richResp.Text = "Nombre incorrecto";
            }
            calific.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
