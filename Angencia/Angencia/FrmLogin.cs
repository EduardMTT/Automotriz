using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Entidades;
using Logica;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angencia
{
    public partial class FrmLogin : Form
    {
        LogicaUsuarios Analisis;
        public FrmLogin()
        {
            InitializeComponent();
            Analisis = new LogicaUsuarios();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            bool Sesion = Analisis.VerificarCredenciales(TxtUsuario.Text, TxtClave.Text);
            if (Sesion == true)
            {
                string Usuario = TxtUsuario.Text;
                Menu Abrir = new Menu(Usuario);
                Usuarios Datos = new Usuarios();
                Datos.Usuario = TxtUsuario.Text;
                Datos.Admin = Analisis.VerificarNivel(Datos);
                MessageBox.Show("BIENVENIDO", "Sesion Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Abrir.Show();
            }
            else { MessageBox.Show("Contraseña o Usuario incorrectos!", "Fallo la Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
