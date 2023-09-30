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
    public partial class Menu : Form
    {
        public string User = "";
        LogicaUsuarios JalarInformacion;
        public Menu(string Usuario)
        {
            InitializeComponent();
            User= Usuario;
            JalarInformacion = new LogicaUsuarios();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin MTT = new FrmLogin();
            MTT.Show();
        }
        public void CrearFromulario(int Opcion)
        {
            if (Opcion == 1)
            {
                // Crear una instancia del formulario hijo
                FrmTaller Abrir = new FrmTaller();
                // Establecer el formulario hijo como el hijo del contenedor
                Abrir.TopLevel = false;
                Abrir.Dock = DockStyle.Fill; // Esto hace que el formulario hijo ocupe todo el espacio del contenedor
                // Agregar el formulario hijo al contenedor
                PanelShow.Controls.Add(Abrir);
                Abrir.Show();
            }
            if (Opcion == 2)
            {
                FrmRefacciones Abrir = new FrmRefacciones();
                Abrir.TopLevel = false;
                Abrir.Dock = DockStyle.Fill;
                PanelShow.Controls.Add(Abrir);
                Abrir.Show();
            }
        }
        private void BtnTaller_Click(object sender, EventArgs e)
        {
            if (PanelShow.Controls.Count == 0)
            {
                PanelShow.Visible = true;
                CrearFromulario(1);
            }
            else 
            {
                MessageBox.Show("Ya tienes un modulo abierto, finaliza esa tarea para iniciar otra","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void Verificar_Tick(object sender, EventArgs e)
        {
            if (PanelShow.Controls.Count == 0)
            {
                PanelShow.Visible = false;
            }
        }

        private void BtnHerramientas_Click(object sender, EventArgs e)
        {
            if (PanelShow.Controls.Count == 0)
            {
                PanelShow.Visible = true;
                CrearFromulario(2);
            }
            else
            {
                MessageBox.Show("Ya tienes un modulo abierto, finaliza esa tarea para iniciar otra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdministrador Abrir = new FrmAdministrador();
            Abrir.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UserName.Text = JalarInformacion.ObtenerNombre(User);
            Usuarios Datos= new Usuarios();
            Datos.Usuario = User;
            Datos.Admin = JalarInformacion.VerificarNivel(Datos);
            if (Datos.Admin == "SI")
            {
                BtnAdmin.Enabled = true;
            }
            else { BtnAdmin.Enabled = false; }
        }
    }
}
