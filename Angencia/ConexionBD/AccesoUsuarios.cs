using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    public class AccesoUsuarios
    {
        Conexion Conectar;
        public AccesoUsuarios() 
        {
            Conectar= new Conexion("localhost", "root", "agenciaautos", 3306);
        }
        public int Comprobacion(string Usuario, string Password)
        {
            Conectar.Enlace.Open();
            string Consulta = string.Format("SELECT COUNT(*) FROM Usuarios WHERE Usuario = '{0}' AND Clave = '{1}'", Usuario, Password);
            MySqlCommand Comando = new MySqlCommand(Consulta,Conectar.Enlace);
            int Cuenta = Convert.ToInt32(Comando.ExecuteScalar());
            Conectar.Enlace.Close();
            return Cuenta;   
        }
        public string Informacion(string Usuario)
        {
            string Resultado = "";
            Conectar.Enlace.Open();
            string Consulta = string.Format("SELECT Nombre FROM Usuarios WHERE Usuario = '{0}'",Usuario);
            MySqlCommand Comando = new MySqlCommand(Consulta, Conectar.Enlace);
            MySqlDataReader Lector = Comando.ExecuteReader();
            if (Lector.HasRows)
            {
                Lector.Read();
                Resultado = Lector["Nombre"].ToString();
            }
            Conectar.Enlace.Close();
            return Resultado;
        }
        public string Permisos(Usuarios ListaUsuario)
        {
            string Resultado="";
            Conectar.Enlace.Open();
            string Consulta = string.Format("SELECT Admin FROM Usuarios WHERE Usuario='{0}'",ListaUsuario.Usuario);
            MySqlCommand Comando = new MySqlCommand(Consulta, Conectar.Enlace);
            MySqlDataReader Lector = Comando.ExecuteReader();
            if (Lector.HasRows)
            {
                Lector.Read();
                Resultado= Lector["Admin"].ToString();
            }
            Conectar.Enlace.Close();
            return Resultado;
            
        }
    }
}
