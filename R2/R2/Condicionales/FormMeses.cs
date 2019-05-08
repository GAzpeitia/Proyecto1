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
    public partial class FormMeses : Form
    {
        public FormMeses()
        {
            InitializeComponent();
        }

        private void FormMeses_Load(object sender, EventArgs e)
        {

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            int option = 0;
            txtMes.Text = option.ToString();

            switch (option)
            {
                case 1:
                    richDad.Text = "Enero \nEs el primer mes del año en el calendario gregoriano y tiene 31 días.";
                    break;
                case 2:
                    richDad.Text = "Febrero \nEs el segundo mes del año en el calendario gregoriano. Tiene 28 días \ny 29 en los años bisiestos";
                    break;
                case 3:
                    richDad.Text = "Marzo \nEs el tercer mes del año en el calendario gregoriano y tiene 31 días.";
                    break;
                case 4:
                    richDad.Text = "Abril \nEs el cuarto mes del año en el calendario gregoriano y tiene 30 dias.";
                    break;
                case 5:
                    richDad.Text = "Mayo \nEs el quinto mes del año en el calendario gregoriano y tiene 31 dias.";
                    break;
                case 6:
                    richDad.Text = "Junio \nEs el sexto mes del año en el calendario gregoriano y tiene 30 dias.";
                    break;
                case 7:
                    richDad.Text = "Julio \nEs el séptimo mes del año en el calendario gregoriano y tiene 31 dias.";
                    break;
                case 8:
                    richDad.Text = "Agosto \nEs el octavo mes del año en el calendario gregoriano y tiene 31 dias.";
                    break;
                case 9:
                    richDad.Text = "Septiembre \nEs el noveno mes del año en el calendario gregoriano y tiene 30 dias.";
                    break;
                case 10:
                    richDad.Text = "Octubre \nEs el décimo mes del año en el calendario gregoriano y tiene 31 dias.";
                    break;
                case 11:
                    richDad.Text = "Noviembre \nEs el undécimo mes del año en el calendario gregoriano y tiene 30 dias.";
                    break;
                case 12:
                    richDad.Text = "Diciembre \nEs el duodécimo y último mes del año en el calendario gregoriano y tiene 31 dias.";
                    break;
                default:
                    richDad.Text = "¡Dato inválido!";
                    break;
            }//cierre de switch
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
