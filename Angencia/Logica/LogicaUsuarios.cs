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
        public List<Usuarios> OperacionesPermitidas(string Nombre)
        {
            return MTT.ObtenerUsuario(Nombre);
        }
        public void GuardarUsuario(Usuarios ListaUsuario)
        {
            MTT.GuardarUsuario(ListaUsuario);
        }
        public void EliminarUsuario(int ID)
        {
            MTT.EliminarUsuario(ID);
        }
        public void ActualizarUsuario(Usuarios ListaUsuarios)
        {
            MTT.ActualizarUsuario(ListaUsuarios);
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
