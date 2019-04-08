using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_autos.modelo
{
    class Cliente
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private Int16 _telefono;

        //Metodos Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public Int16 Telefono { get; set; }
    }
}
