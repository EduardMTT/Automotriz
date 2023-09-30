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
        public List<Usuarios> ObtenerUsuarios()
        {
            var ListaUsuarios = new List<Usuarios>();
            var TABLA = new DataTable();
            var Consulta = string.Format("SELECT * FROM Usuarios");
            TABLA = Conectar.ObtenerDatos(Consulta);
            foreach (DataRow Fila in TABLA.Rows)
            {
                var Usuario = new Usuarios()
                {
                    Nombre = Fila["Nombre"].ToString(),
                    ApellidoP = Fila["ApellidoP"].ToString(),
                    ApellidoM = Fila["ApellidoM"].ToString(),
                    FechadeNacimiento = Fila["FechaNacimiento"].ToString(),
                    Usuario = Fila["Usuario"].ToString(),
                    Clave = Fila["Clave"].ToString(),
                    RFC = Fila["RFC"].ToString(),
                    PCA = Fila["PCA"].ToString(),
                    PE = Fila["PE"].ToString(),
                    PL = Fila["PL"].ToString(),
                    Admin = Fila["Admin"].ToString()
                };
                ListaUsuarios.Add(Usuario);
            }
            return ListaUsuarios;
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
