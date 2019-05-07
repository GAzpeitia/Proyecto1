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
    public partial class FormArreglos : Form
    {
        public FormArreglos()
        {
            InitializeComponent();
        }

        private void FormArreglos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formNumAle = new FormNumAle();
            formNumAle.Show();
            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //p.StartInfo.FileName = @"C:\Users\sport\Downloads\Trabajos de la unidad II\Arreglos\Arreglos";
            //p.Start();
            //p.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formNum = new FormNumMayMin();
            formNum.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form2 = new FormNumVoCo();
            form2.Show();
        }
    }
}
