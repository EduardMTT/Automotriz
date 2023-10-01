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
        public void GuardarHerramienta(Herramientas herramientas)
        {
            string Consulta = string.Format("INSERT INTO herramientas VALUES('{0}','{1}',{2},'{3}','{4}');",herramientas.Codigo, herramientas.Nombre,herramientas.Medida,
            herramientas.Marca,herramientas.Descripcion);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void EliminarHerramienta(string Codigo)
        {
            string Consulta = string.Format("DELETE FROM herramientas WHERE Codigo='{0}';",Codigo);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void ActualizarHerramienta(Herramientas herramientas)
        {
            string Consulta = string.Format("UPDATE herramientas SET Codigo='{0}', Nombre='{1}', Medida={2}, Marca='{3}', Descripcion='{4}' WHERE Codigo='{5}';", herramientas.Codigo,
                herramientas.Nombre, herramientas.Medida, herramientas.Marca, herramientas.Descripcion, herramientas.Codigo);
            Conectar.EjecutarConsulta(Consulta);
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
                    Codigo = Fila["Codigo"].ToString(),
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
