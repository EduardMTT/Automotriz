using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angencia
{
    public partial class FrmRefacciones : Form
    {
        LogicaRefacciones Analisis;
        Refacciones ListaR;
        string Bandera = "G";
        public string Username = "";
        public FrmRefacciones(string Usuario)
        {
            InitializeComponent();
            ListaR = new Refacciones();
            Analisis = new LogicaRefacciones();
            Username = Usuario;
            Comprobacion.Text = Username;
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
            ComprobarPermisos();
        }
        public void VaciarCajas()
        {
            TxtCodigoBarras.Text = "";
            TxtNombre.Text = "";
            TxtMarca.Text = "";
            TxtDescripcion.Text = "";
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgRefacciones.DataSource = null;
            BtnGuardar.Text = "Guardar";
            VaciarCajas();
            GrupoDatos.Enabled = true;
            Bandera = "G";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ListaR.CodigoBarras = TxtCodigoBarras.Text;
            ListaR.Nombre = TxtNombre.Text;
            ListaR.Marca = TxtMarca.Text;
            ListaR.Descripcion = TxtDescripcion.Text;
            if (Bandera.Equals("G"))
            {
                Analisis.GuardarHerramienta(ListaR);
                MessageBox.Show("Se guardo la refaccion exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Bandera.Equals("A"))
            {
                Analisis.ActualizarHerramienta(ListaR);
                MessageBox.Show("Se actualizo la refaccion exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DgRefacciones.DataSource = null;
            LlenarRefacciones();
            GrupoDatos.Enabled = false;
            VaciarCajas();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            string Codigo = TxtCodigoBarras.Text;

            if (Codigo.Equals(""))
            {
                MessageBox.Show("No hay un registro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estas seguro de eliminar la herramienta: " + TxtNombre.Text, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Analisis.EliminarRefaccion(Codigo);
                    MessageBox.Show("Se elimino la herramienta exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgRefacciones.DataSource = null;
                    LlenarRefacciones();
                    VaciarCajas();
                }

            }
        }

        private void DgRefacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigoBarras.Text = DgRefacciones.CurrentRow.Cells["CodigoBarras"].Value.ToString();
            TxtNombre.Text = DgRefacciones.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtMarca.Text = DgRefacciones.CurrentRow.Cells["Marca"].Value.ToString();
            TxtDescripcion.Text = DgRefacciones.CurrentRow.Cells["Descripcion"].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoBarras.Text.Equals(""))
            {
                MessageBox.Show("No hay un registro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BtnGuardar.Text = "Actualizar";
                GrupoDatos.Enabled = true;
                Bandera = "A";
            }
        }
        public void ComprobarPermisos()
        {
            string Mensaje = "";
            List<Usuarios> Permisos = Analisis.OperacionesPermitidas(Username);
            Usuarios usuario = Permisos[0];
            string PCA = usuario.PCA.ToString();
            string PE = usuario.PE.ToString();
            string PL = usuario.PL.ToString();
            if (PCA.Equals("SI"))
            {
                BtnAgregar.Enabled = true;
                BtnEditar.Enabled = true;
            }
            else
            {
                Mensaje = Mensaje + "'Editar' 'Crear'";
                BtnAgregar.Enabled = false;
                BtnEditar.Enabled = false;
            }
            if (PE.Equals("SI"))
            {
                BtnBorrar.Enabled = true;
            }
            else { Mensaje = Mensaje + " 'Borrar' "; BtnBorrar.Enabled = false; }
            if (PL.Equals("SI"))
            {
                LlenarRefacciones();
            }
            else { Mensaje = Mensaje + " 'Leer' "; }
            if (Mensaje.Equals(""))
            {
                //No pasa nada xD
            }
            else { MessageBox.Show("Estos permisos se te revocaron por el nivel de usuario que te asignaron: " + Mensaje, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
    }
}
