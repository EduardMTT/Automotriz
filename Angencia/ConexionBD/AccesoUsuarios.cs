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
        public void GuardarUsuario(Usuarios usuario)
        {
            string Consulta = string.Format("INSERT INTO Usuarios VALUES(NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');",
                usuario.Nombre, usuario.ApellidoP, usuario.ApellidoM, usuario.FechadeNacimiento, usuario.Usuario, usuario.Clave, usuario.RFC, usuario.PCA, usuario.PE, usuario.PL, usuario.Admin);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void EliminarUsuario(int ID)
        {
            string Consulta = string.Format("DELETE FROM Usuarios WHERE ID={0};", ID);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void ActualizarUsuario(Usuarios usuario)
        {
            string Consulta = string.Format("UPDATE Usuarios SET ID='{0}', Nombre='{1}', ApellidoP='{2}', ApellidoM='{3}', FechaNacimiento='{4}', Usuario='{5}'," +
                "Clave='{6}', RFC='{7}', PCA='{8}', PE='{9}', PL='{10}', Admin='{11}' WHERE ID='{12}'", usuario.ID, usuario.Nombre, usuario.ApellidoP, usuario.ApellidoM, usuario.FechadeNacimiento, usuario.Usuario,
                usuario.Clave, usuario.RFC, usuario.PCA, usuario.PE, usuario.PL, usuario.Admin);
            Conectar.EjecutarConsulta(Consulta);
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
                    ID = int.Parse(Fila["ID"].ToString()),
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
        public List<Usuarios> ObtenerUsuario(string Nombre)
        {
            var ListaUsuarios = new List<Usuarios>();
            var TABLA = new DataTable();
            var Consulta = string.Format(string.Format("SELECT ID, Nombre, Usuario, PCA, PE, PL FROM usuarios WHERE Nombre='{0}'", Nombre));
            TABLA = Conectar.ObtenerDatos(Consulta);
            foreach (DataRow Fila in TABLA.Rows)
            {
                var Usuario = new Usuarios()
                {
                    ID = int.Parse(Fila["ID"].ToString()),
                    Nombre = Fila["Nombre"].ToString(),
                    Usuario = Fila["Usuario"].ToString(),
                    PCA = Fila["PCA"].ToString(),
                    PE = Fila["PE"].ToString(),
                    PL = Fila["PL"].ToString()
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
