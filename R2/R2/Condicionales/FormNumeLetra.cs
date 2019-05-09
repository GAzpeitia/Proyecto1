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
    public partial class FormNumeLetra : Form
    {
        public FormNumeLetra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] unidades =
            {"cero", "uno", "dos" ,"tres" ,"cuatro" ,"cinco" ,
                "seis" ,"siete" ,"ocho" ,"nueve","diez"};
            string[] especiales =
            {"once", "doce","trece","catorce", "quince",
                "diezciseis", "diecisiete", "dieciocho", "diecinueve"};
            string[] decenas =
            {"veinte", "treinta","cuarenta","cincuenta",
                "sesenta", "setenta", "ochenta", "noventa"};

            Console.WriteLine("\nIngrese un numero entre 0-100000: ");
            int num;
            num = int.Parse(txtNum.Text);

            if (num >= 0 && num < 11)
                txtLetra.Text = '\n' + unidades[num];
            else if (num < 20)
                Console.WriteLine('\n' + especiales[num - 11]);
            else if (num < 100000)
            {
                int unid = num % 10;
                int dec = num / 10;
                if (unid == 0)
                    txtLetra.Text = '\n' + decenas[dec - 2];
                else
                    txtLetra.Text = '\n' + decenas[dec - 2] + " y " + unidades[unid];
            }
            else
                txtLetra.Text = "El numero debe ser menor a 100000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNumeLetra_Load(object sender, EventArgs e)
        {

        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtLetra.Text = "";
            txtNum.Text = "";
            
        }
    }
}
