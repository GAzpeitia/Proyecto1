using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormInicio.vista;

namespace Venta_de_autos
{
    static class Program
    {
        public static MenuPrincipal.FormMenuPrincipal = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicioSesion());
        }
    }
}
