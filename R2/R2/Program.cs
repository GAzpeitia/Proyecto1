using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2
{
    static class Program
    {
        public static FormArreglos FormMenuA = null;
        public static FormFunciones formMenuF = null;
        public static FormCiclos formMenuC = null;
        public static FormCondicionales formMenuCo = null;
        public static FormSecuanciales formMenuS = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMenuA = new FormArreglos();
            formMenuF = new FormFunciones();
            formMenuC = new FormCiclos();
            formMenuCo = new FormCondicionales();
            formMenuS = new FormSecuanciales();
            Application.Run(new FormInicio());
        }
    }
}
