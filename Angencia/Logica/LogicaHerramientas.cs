using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using ConexionBD;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaHerramientas
    {
        AccesoHerramientas MTT;
        public LogicaHerramientas()
        {
            MTT = new AccesoHerramientas();
        }
        public List<Herramientas> ObtenerDatos()
        {
            return MTT.ObtenerHerramientas();
        }
    }
}
