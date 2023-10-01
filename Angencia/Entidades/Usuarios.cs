using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private int _ID;
        private string _Nombre;
        private string _ApellidoP;
        private string _ApellidoM;
        private string _FechadeNacimiento;
        private string _Usuario;
        private string _Clave;
        private string _RFC;
        private string _PCA;
        private string _PE;
        private string _PL;
        private string _Admin;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string ApellidoP { get => _ApellidoP; set => _ApellidoP = value; }
        public string ApellidoM { get => _ApellidoM; set => _ApellidoM = value; }
        public string FechadeNacimiento { get => _FechadeNacimiento; set => _FechadeNacimiento = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string RFC { get => _RFC; set => _RFC = value; }
        public string PCA { get => _PCA; set => _PCA = value; }
        public string PE { get => _PE; set => _PE = value; }
        public string PL { get => _PL; set => _PL = value; }
        public string Admin { get => _Admin; set => _Admin = value; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
