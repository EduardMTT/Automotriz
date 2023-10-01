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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Angencia
{
    public partial class FrmAdministrador : Form
    {
        LogicaUsuarios Analisis;
        string Bandera = "G";
        string Username = "";
        Usuarios ListaU;
        public FrmAdministrador(string Usuario)
        {
            InitializeComponent();
            Analisis = new LogicaUsuarios();
            ListaU = new Usuarios();
            Username = Usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnBorrar.Enabled=false;
            BtnEditar.Enabled=false;
            DgUsuarios.DataSource = null;
            BtnGuardar.Text = "Guardar";
            VaciarCajas();
            GrupoDatos.Enabled = true;
            Bandera = "G";
            TxtID.Enabled = false;
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
            ComprobarPermisos();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = int.Parse(TxtID.Text);
                if (MessageBox.Show("Estas seguro de eliminar este usuario: " + TxtNombre.Text, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Analisis.EliminarUsuario(Codigo);
                    MessageBox.Show("Se elimino el usuario exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgUsuarios.DataSource = null;
                    LlenarUsuarios();
                    VaciarCajas();
                }
            
            }
            catch
            {
                MessageBox.Show("No has elegido un registro a eliminar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BtnAgregarUsuario.Enabled = true;
                BtnEditar.Enabled = true;
            }
            else
            {
                Mensaje = Mensaje + "'Editar' 'Crear'";
                BtnAgregarUsuario.Enabled = false;
                BtnEditar.Enabled = false;
            }
            if (PE.Equals("SI"))
            {
                BtnBorrar.Enabled = true;
            }
            else { Mensaje = Mensaje + " 'Borrar' "; BtnBorrar.Enabled = false; }
            if (PL.Equals("SI"))
            {
                LlenarUsuarios();
            }
            else { Mensaje = Mensaje + " 'Leer' "; }
            if (Mensaje.Equals(""))
            {
                //No pasa nada xD
            }
            else { MessageBox.Show("Estos permisos se te revocaron por el nivel de usuario que te asignaron: " + Mensaje, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text.Equals(""))
            {
                MessageBox.Show("No hay un registro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BtnBorrar.Enabled = false;
                BtnAgregarUsuario.Enabled = false;
                BtnGuardar.Text = "Actualizar";
                GrupoDatos.Enabled = true;
                Bandera = "A";
            }
        }
        private void LlenarUsuarios()
        {
            DgUsuarios.DataSource = Analisis.ObtenerDatos();
        }
        public void LlenarEntidad()
        {
            ListaU.Nombre = TxtNombre.Text;
            ListaU.ApellidoP = TxtApP.Text;
            ListaU.ApellidoM = TxtApM.Text;
            ListaU.FechadeNacimiento = TxtF.Text;
            ListaU.Usuario = TxtUsuario.Text;
            ListaU.Clave = TxtPass.Text;
            ListaU.RFC = TxtRFC.Text;
            if (CBCrearyEditar.Checked)
            {
                ListaU.PCA = "SI";
            }
            else { ListaU.PCA = "NO"; }
            if (CBEliminar.Checked)
            {
                ListaU.PE = "SI";
            }
            else { ListaU.PE = "NO"; }
            if (CBLeer.Checked)
            {
                ListaU.PL = "SI";
            }
            else { ListaU.PL = "NO"; }
            if (CBAdmin.Checked)
            {
                ListaU.Admin = "SI";
            }
            else { ListaU.Admin = "NO"; }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LlenarEntidad();
            if (Bandera.Equals("G"))
            {
                
                if (Bandera.Equals("G"))
                {
                    Analisis.GuardarUsuario(ListaU);
                    MessageBox.Show("Se guardo el usuario exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (Bandera.Equals("A"))
            {

                ListaU.ID = int.Parse(TxtID.Text);
                Analisis.ActualizarUsuario(ListaU);
                MessageBox.Show("Se actualizo el usuario exitosamente!", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BtnBorrar.Enabled = true;
            BtnEditar.Enabled = true;
            DgUsuarios.DataSource = null;
            LlenarUsuarios();
            GrupoDatos.Enabled = false;
            VaciarCajas();
        }
        public void VaciarCajas()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtApP.Text = "";
            TxtApM.Text = "";
            TxtF.Text = "";
            TxtUsuario.Text = "";
            TxtPass.Text = "";
            TxtRFC.Text = "";
            CBCrearyEditar .Checked = false;
            CBEliminar.Checked = false;
            CBLeer.Checked = false;
            CBAdmin.Checked= false;
        }

        private void DgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = DgUsuarios.CurrentRow.Cells["ID"].Value.ToString();
            TxtNombre.Text = DgUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtApP.Text = DgUsuarios.CurrentRow.Cells["ApellidoP"].Value.ToString();
            TxtApM.Text = DgUsuarios.CurrentRow.Cells["ApellidoM"].Value.ToString();
            TxtF.Text = DgUsuarios.CurrentRow.Cells["FechadeNacimiento"].Value.ToString();
            TxtUsuario.Text = DgUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            TxtPass.Text = DgUsuarios.CurrentRow.Cells["Clave"].Value.ToString();
            TxtRFC.Text = DgUsuarios.CurrentRow.Cells["RFC"].Value.ToString();
            if (DgUsuarios.CurrentRow.Cells["PCA"].Value.ToString().Equals("SI"))
            {
                CBCrearyEditar.Checked = true;
            }
            else { CBCrearyEditar.Checked = false; }
            if (DgUsuarios.CurrentRow.Cells["PE"].Value.ToString().Equals("SI"))
            {
                CBEliminar.Checked = true;
            }
            else { CBEliminar.Checked = false; }
            if (DgUsuarios.CurrentRow.Cells["PL"].Value.ToString().Equals("SI"))
            {
                CBLeer.Checked = true;
            }
            else { CBLeer.Checked = false;}
            if (DgUsuarios.CurrentRow.Cells["Admin"].Value.ToString().Equals("SI"))
            {
                CBAdmin.Checked = true;
            }
            else { CBAdmin.Checked = false;}
        }
    }
}
