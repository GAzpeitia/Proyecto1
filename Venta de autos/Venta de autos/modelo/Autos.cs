using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_autos
{
    class Autos
    {
        public string _matricula;
        public string _modelo;
        public string _precio;
        public string _marca;
        public string _color;

        public Autos()
        {
            _matricula = " ";
        }
        //Métodos Getter´s y Setter´s
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Precio { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
    }
}
