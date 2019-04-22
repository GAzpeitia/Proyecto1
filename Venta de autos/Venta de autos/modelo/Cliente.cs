using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_autos
{
    class Cliente
    {
        private string _id;
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private string _telefono;

        //Metodos Getter´s y Setter´s
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
