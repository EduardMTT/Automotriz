using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Refacciones
    {
        private string _Nombre;
        private string _Marca;
        private string _Descripcion;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
