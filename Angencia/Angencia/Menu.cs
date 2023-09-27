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
        public Menu()
        {
            InitializeComponent();
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
        }
        private void BtnTaller_Click(object sender, EventArgs e)
        {
            PanelShow.Visible=true;
            CrearFromulario(1);
        }

        private void Verificar_Tick(object sender, EventArgs e)
        {
            if (PanelShow.Controls.Count == 0)
            {
                PanelShow.Visible = false;
            }
        }
    }
}
