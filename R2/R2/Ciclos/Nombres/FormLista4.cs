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
    public partial class FormLista4 : Form
    {
        public FormLista4()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            string l2, nomb, mNom, mApe, ape;

            StreamReader outlup = new StreamReader("e:\\nombres.txt", Encoding.Default);
            StreamReader no = new StreamReader("e:\\nombres1.txt", Encoding.Default);

            while ((l2 = no.ReadLine()) != null)
            {
                string[] split = l2.Split(new Char[] { '*' });
                nomb = split[0];
                mNom = nomb.ToLower();
                ape = split[1];
                mApe = ape.ToUpper();

                richLista.Text = mApe + " " + mNom;
            }
        }
    }
}
