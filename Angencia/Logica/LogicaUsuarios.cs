using System;
using System.Collections.Generic;
using System.Linq;
using ConexionBD;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica
{
    public class LogicaUsuarios
    {
        AccesoUsuarios MTT;
        public LogicaUsuarios() 
        {
            MTT= new AccesoUsuarios();
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
