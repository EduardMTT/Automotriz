﻿using Logica;
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
        public FrmTaller()
        {
            InitializeComponent();
            Analisis = new LogicaHerramientas();
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }
        private void LlenarHerramientas()
        {
            DgHerramientas.DataSource = Analisis.ObtenerDatos();
        }
        private void FrmTaller_Load(object sender, EventArgs e)
        {
            LlenarHerramientas();
        }
    }
}
