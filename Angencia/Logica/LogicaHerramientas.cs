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
        public void ActualizarHerramienta(Herramientas herramienta)
        {
            MTT.ActualizarHerramienta(herramienta);
        }
        public void GuardarHerramienta(Herramientas herramienta)
        {
            MTT.GuardarHerramienta(herramienta);
        }
        public void EliminarHerramienta(string Codigo)
        {
            MTT.EliminarHerramienta(Codigo);
        }
        public List<Herramientas> ObtenerDatos()
        {
            return MTT.ObtenerHerramientas();
        }
    }
}
