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
    public partial class FormLista2 : Form
    {
        public FormLista2()
        {
            InitializeComponent();
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            string nom1, l1;

                StreamReader outlup = new StreamReader("e:\\nombres.txt", Encoding.Default);
                StreamReader no = new StreamReader("e:\\nombres1.txt", Encoding.Default);

                        while ((nom1 = outlup.ReadLine()) != null)
                        {
                            l1 = nom1.ToUpper();
                richLista.Text = l1;
                        }
                        outlup.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
