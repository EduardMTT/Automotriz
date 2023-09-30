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
    public partial class FrmRefacciones : Form
    {
        LogicaRefacciones Analisis;
        public FrmRefacciones()
        {
            InitializeComponent();
            Analisis = new LogicaRefacciones();
        }

        private void GrupoDatos_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LlenarRefacciones()
        {
            DgRefacciones.DataSource = Analisis.ObtenerDatos();
        }
        private void FrmRefacciones_Load(object sender, EventArgs e)
        {
            LlenarRefacciones();
        }
    }
}
