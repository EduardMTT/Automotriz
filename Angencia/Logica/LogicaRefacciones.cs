using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using ConexionBD;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaRefacciones
    {
        AccesoRefacciones MTT;
        public LogicaRefacciones()
        {
            MTT = new AccesoRefacciones();
        }
        public List<Refacciones> ObtenerDatos()
        {
            return MTT.ObtenerRefacciones();
        }
    }
}
