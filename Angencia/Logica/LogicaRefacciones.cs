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
        AccesoUsuarios PERMISOS;
        public LogicaRefacciones()
        {
            MTT = new AccesoRefacciones();
            PERMISOS = new AccesoUsuarios();
        }
        public List<Usuarios> OperacionesPermitidas(string Nombre)
        {
            return PERMISOS.ObtenerUsuario(Nombre);
        }
        public void ActualizarHerramienta(Refacciones refaccion)
        {
            MTT.ActualizarRefaccion(refaccion);
        }
        public void GuardarHerramienta(Refacciones refaccion)
        {
            MTT.GuardarRefaccion(refaccion);
        }
        public void EliminarRefaccion(string Codigo)
        {
            MTT.EliminarRefaccion(Codigo);
        }
        public List<Refacciones> ObtenerDatos()
        {
            return MTT.ObtenerRefacciones();
        }
    }
}
