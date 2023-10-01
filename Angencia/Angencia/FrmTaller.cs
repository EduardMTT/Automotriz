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
    public partial class FrmTaller : Form
    {
        LogicaHerramientas Analisis;
        Herramientas ListaH;
        string Bandera = "G";
        public string Username ="";
        public FrmTaller(string Usuario)
        {
            InitializeComponent();
            Analisis = new LogicaHerramientas();
            ListaH = new Herramientas();
            Username = Usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GrupoDatos_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = DgHerramientas.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtNombre.Text = DgHerramientas.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtMedida.Text = DgHerramientas.CurrentRow.Cells["Medida"].Value.ToString();
            TxtMarca.Text = DgHerramientas.CurrentRow.Cells["Marca"].Value.ToString();
            TxtDescripcion.Text = DgHerramientas.CurrentRow.Cells["Descripcion"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BtnBorrar.Enabled = false;
            BtnEditar.Enabled = false;
            DgHerramientas.DataSource = null;
            BtnGuardar.Text = "Guardar";
            VaciarCajas();
            GrupoDatos.Enabled = true;
            Bandera = "G";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string Codigo = TxtCodigo.Text;
            if (Codigo.Equals(""))
            {
                MessageBox.Show("No hay un registro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BtnBorrar.Enabled = false;
                BtnAgregar.Enabled = false;
                BtnGuardar.Text = "Actualizar";
                GrupoDatos.Enabled = true;
                Bandera = "A";
            }
           
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            string Codigo = TxtCodigo.Text;

            if (Codigo.Equals(""))
            {
                MessageBox.Show("No hay un registro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estas seguro de eliminar la herramienta: " + TxtNombre.Text, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Analisis.EliminarHerramienta(Codigo);
                    MessageBox.Show("Se elimino la herramienta exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgHerramientas.DataSource = null;
                    LlenarHerramientas();
                    VaciarCajas();
                }

            }
        }
        private void LlenarHerramientas()
        {
            DgHerramientas.DataSource = Analisis.ObtenerDatos();
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
                LlenarHerramientas();
            }
            else { Mensaje = Mensaje + " 'Leer' "; }
            if (Mensaje.Equals(""))
            {
                //No pasa nada xD
            }
            else { MessageBox.Show("Estos permisos se te revocaron por el nivel de usuario que te asignaron: " + Mensaje, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void FrmTaller_Load(object sender, EventArgs e)
        {
            ComprobarPermisos();
        }
        public void VaciarCajas()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtMedida.Text = "";
            TxtMarca.Text = "";
            TxtDescripcion.Text = "";
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaH.Codigo = TxtCodigo.Text;
                ListaH.Nombre = TxtNombre.Text;
                ListaH.Medida = double.Parse(TxtMedida.Text);
                ListaH.Marca = TxtMarca.Text;
                ListaH.Descripcion = TxtDescripcion.Text;
                if (Bandera.Equals("G"))
                {
                    Analisis.GuardarHerramienta(ListaH);
                    MessageBox.Show("Se guardo la herramienta exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnEditar.Enabled = true;
                }
                if (Bandera.Equals("A"))
                {
                    Analisis.ActualizarHerramienta(ListaH);
                    MessageBox.Show("Se actualizo la herramienta exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnAgregar.Enabled = true;
                }
                BtnBorrar.Enabled = true;
                DgHerramientas.DataSource = null;
                LlenarHerramientas();
                GrupoDatos.Enabled = false;
                VaciarCajas();
            }
            catch
            {
                MessageBox.Show("El dato en medida tiene un formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
