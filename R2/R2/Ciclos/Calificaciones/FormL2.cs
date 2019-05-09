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
    public partial class FormL2 : Form
    {
        public FormL2()
        {
            InitializeComponent();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            int ca;
            string lista1, ca1;
            string numero, nombre, ape, nomCar;
            StreamReader calific = new StreamReader("e:\\calificaciones.txt");

            Console.WriteLine("\nEscribe una carrera:");
            ca1 = txtEscri.Text;
            ca = ca1.Length;
            if (ca > 3 && ca < 30)
            {
                switch (ca1)
                {
                    case "Programación":
                    case "Programacion":
                    case "programación":
                    case "programacion":
                    case "PROGRAMACION":
                        nomCar = "Programación";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            ca1 = split[4];
                            if (split[4] == nomCar)
                            {
                                richResp.Text = nombre + " " + ape + " " + ca1;
                            }
                            else
                            {
                                richResp.Text = "La opción no existe!!!";
                            }
                        }
                        break;
                    case "SOPORTE TECNICO":
                    case "Soporte Técnico":
                    case "soporte técnico":
                    case "Soporte técnico":
                    case "soporte Técnico":
                    case "Soporte Tecnico":
                    case "soporte tecnico":
                    case "Soporte tecnico":
                    case "soporte Tecnico":
                        nomCar = "Soporte Tecnico";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            ca1 = split[4];
                            if (split[4] == nomCar)
                            {
                                richResp.Text = nombre + " " + ape + " " + ca1;

                            }
                            else
                            {
                                richResp.Text = "La opción no existe!!!";
                            }
                        }
                        break;
                    case "Electricidad":
                    case "electricidad":
                    case "ELECTRICIDAD":
                        nomCar = "Electricidad";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            ca1 = split[4];
                            if (split[4] == nomCar)
                            {
                                richResp.Text = nombre + " " + ape + " " + ca1;

                            }
                            else
                            {
                                richResp.Text = "La opción no existe!!!";
                            }
                        }
                        break;
                    case "MECANICA":
                    case "Mecánica":
                    case "mecánica":
                    case "Mecanica":
                    case "mecanica":
                        nomCar = "Mecánica";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            ca1 = split[4];
                            if (split[4] == nomCar)
                            {
                                richResp.Text = nombre + " " + ape + " " + ca1;

                            }
                            else
                            {
                                richResp.Text = "La opción no existe!!!";
                            }
                        }
                        break;
                    case "contabilidad":
                    case "CONTABILIDAD":
                    case "Contabilidad":
                        nomCar = "Contabilidad";
                        while ((lista1 = calific.ReadLine()) != null)
                        {
                            string[] split = lista1.Split(new Char[] { ';' });
                            numero = split[0];
                            nombre = split[1];
                            ape = split[2];
                            ca1 = split[4];
                            if (split[4] == nomCar)
                            {
                                richResp.Text = nombre + " " + ape + " " + ca1;

                            }
                            else
                            {
                                richResp.Text = "La opción no existe!!!";
                            }
                        }
                        break;
                    default:
                        richResp.Text = "La carrera que elegiste no existe";
                        break;
                }
            }
            else
            {
                richResp.Text = "Error!!!";
            }


            calific.Close();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
