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
    public partial class FormNumAle : Form
    {
        public FormNumAle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[10];
            int conta;
            double med;
            Random alea = new Random();

            for (int i = 0; i < 10; i++)
            {
                num[i] = alea.Next(0, 50);

                txtNum.Text = num[i].ToString();
            }
            conta = (num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6] + num[7] + num[8] + num[9]);
            med = (num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6] + num[7] + num[8] + num[9]) / 10;

            txtNumAle.Text = conta.ToString();
            txtMedArit.Text = med.ToString();
        }

        private void FormNumAle_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
