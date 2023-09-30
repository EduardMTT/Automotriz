using System;
using System.Collections.Generic;
using System.Linq;
using ConexionBD;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Logica
{
    public class LogicaUsuarios
    {
        AccesoUsuarios MTT;
        public LogicaUsuarios() 
        {
            MTT= new AccesoUsuarios();
        }
        public List<Usuarios> ObtenerDatos()
        {
            return MTT.ObtenerUsuarios();
        }
        public string VerificarNivel(Usuarios ListaUsuarios)
        {
            return MTT.Permisos(ListaUsuarios);
        }
        public string ObtenerNombre(string Usuario)
        {
            return MTT.Informacion(Usuario);
        }
        public bool VerificarCredenciales(string Usuario, string Clave)
        {
            bool Resultado = false;
            int Cuenta = MTT.Comprobacion(Usuario, Clave);
            if (Cuenta > 0) { Resultado = true; }
            return Resultado;
        }
    }
}
