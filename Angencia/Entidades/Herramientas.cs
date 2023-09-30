using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramientas
    {
        private string _Nombre;
        private double _Medida;
        private string _Marca;
        private string _Descripcion;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double Medida { get => _Medida; set => _Medida = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
