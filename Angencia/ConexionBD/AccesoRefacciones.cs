using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using ConexionBD;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConexionBD
{
    public class AccesoRefacciones
    {
        Conexion Conectar;
        public AccesoRefacciones()
        {
            Conectar = new Conexion("localhost", "root", "agenciaautos", 3306);
        }
        public List<Refacciones> ObtenerRefacciones()
        {
            var ListaRefacciones = new List<Refacciones>();
            var TABLA = new DataTable();
            var Consulta = string.Format("SELECT * FROM Refacciones");
            TABLA = Conectar.ObtenerDatos(Consulta);
            foreach (DataRow Fila in TABLA.Rows)
            {
                var Refaccion = new Refacciones()
                {
                    Nombre = Fila["Nombre"].ToString(),
                    Marca = Fila["Marca"].ToString(),
                    Descripcion = Fila["Descripcion"].ToString()
                };
                ListaRefacciones.Add(Refaccion);
            }
            return ListaRefacciones;
        }
    }
}
