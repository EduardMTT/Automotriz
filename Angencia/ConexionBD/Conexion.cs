using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ConexionBD
{
    public class Conexion
    {
        public MySqlConnection Enlace;
        public Conexion(string servidor, string usuario, string database, uint puerto)
        {
            MySqlConnectionStringBuilder CadenaConexion = new MySqlConnectionStringBuilder();
            CadenaConexion.Server = servidor;
            CadenaConexion.UserID = usuario;
            CadenaConexion.Database = database;
            CadenaConexion.Port = puerto;

            Enlace = new MySqlConnection(CadenaConexion.ToString());
        }
        public void EjecutarConsulta(string Consulta)
        {
            try
            {
                Enlace.Open();
                using (MySqlCommand Comando = new MySqlCommand(Consulta, Enlace))
                {
                    Comando.ExecuteNonQuery();
                    Console.WriteLine("Consulta ejecutada correctamente");
                }
                Enlace.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al ejecutar la consulta: ", ex.Message);
            }
        }
        public DataTable ObtenerDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                Enlace.Open();
                using (MySqlCommand comando = new MySqlCommand(consulta, Enlace))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                        Console.WriteLine("consulta ejecutada correctamente");
                    }
                }
                Enlace.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al ejecutar la consulta: ", ex.Message);
            }
            return tabla;
        }
    }
}
