using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angencia
{
    public partial class FrmAdministrador : Form
    {
        LogicaUsuarios Analisis;
        public FrmAdministrador()
        {
            InitializeComponent();
            Analisis = new LogicaUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void LlenarHerramientas()
        {
            DgUsuarios.DataSource = Analisis.ObtenerDatos();
        }
        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            LlenarHerramientas();
        }
    }
}
