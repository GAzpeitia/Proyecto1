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
    public partial class FormList1 : Form
    {
        public FormList1()
        {
            InitializeComponent();
        }

        private void FormList1_Load(object sender, EventArgs e)
        {

        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            string nom1;

            StreamWriter er = new StreamWriter("e:\\OpcionIncorrecta.txt", true);


                StreamReader outlup = new StreamReader("e:\\nombres.txt", Encoding.Default);
                StreamReader no = new StreamReader("e:\\nombres1.txt", Encoding.Default);


                        while ((nom1 = outlup.ReadLine()) != null)
                        {
                richLista.Text = nom1;
                            //Console.WriteLine(contador + " " + nom1);
                        }
                        outlup.Close();
            er.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
