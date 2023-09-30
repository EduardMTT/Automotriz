using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace ConexionBD
{
    public class AccesoHerramientas
    {
        Conexion Conectar;
        public AccesoHerramientas()
        {
            Conectar = new Conexion("localhost", "root", "agenciaautos", 3306);
        }
        public List<Herramientas> ObtenerHerramientas()
        {
            var ListaHerramientas = new List<Herramientas>();
            var TABLA = new DataTable();
            var Consulta = string.Format("SELECT * FROM Herramientas");
            TABLA = Conectar.ObtenerDatos(Consulta);
            foreach (DataRow Fila in TABLA.Rows) 
            {
                var Herramienta = new Herramientas()
                {
                    Nombre = Fila["Nombre"].ToString(),
                    Medida = double.Parse(Fila["Medida"].ToString()),
                    Marca = Fila["Marca"].ToString(),
                    Descripcion = Fila["Descripcion"].ToString()
                };
                ListaHerramientas.Add(Herramienta);
            }
            return ListaHerramientas;
        }
    }
}
