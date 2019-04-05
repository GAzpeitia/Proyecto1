using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_autos;

namespace Venta_de_autos
{
    static class Program
    {
        public static formMenu FormMenu = null;
        public static formAutos FormAutos = null;
        public static formCliente FormCliente = null;
        public static FormInicioSesion FormIni = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMenu = new formMenu();
            FormAutos = new formAutos();
            FormCliente = new formCliente();
            FormIni = new FormInicioSesion();
            Application.Run(new FormInicioSesion());
        }
    }
}
