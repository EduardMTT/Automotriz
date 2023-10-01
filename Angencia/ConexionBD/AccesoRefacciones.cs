using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using ConexionBD;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Utilities.Collections;

namespace ConexionBD
{
    public class AccesoRefacciones
    {
        Conexion Conectar;
        public AccesoRefacciones()
        {
            Conectar = new Conexion("localhost", "root", "agenciaautos", 3306);
        }
        public void GuardarRefaccion(Refacciones refaccion)
        {
            string Consulta = string.Format("INSERT INTO Refacciones VALUES('{0}','{1}','{2}','{3}')",refaccion.CodigoBarras, refaccion.Nombre, refaccion.Marca, refaccion.Descripcion);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void EliminarRefaccion(string Codigo)
        {
            string Consulta = string.Format("DELETE FROM Refacciones WHERE CodigoBarras='{0}';", Codigo);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void ActualizarRefaccion(Refacciones refaccion)
        {
            string Consulta = string.Format("UPDATE Refacciones SET CodigoBarras='{0}', Nombre='{1}', Marca='{2}', Descripcion='{3}' WHERE CodigoBarras='{4}'",
                refaccion.CodigoBarras, refaccion.Nombre, refaccion.Marca, refaccion.Descripcion, refaccion.CodigoBarras);
            Conectar.EjecutarConsulta(Consulta);
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
                    CodigoBarras = Fila["CodigoBarras"].ToString(),
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
