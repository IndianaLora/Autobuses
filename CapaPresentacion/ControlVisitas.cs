﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ControlVisitas : Form
    {
        N_Empleado n_Empleado = new N_Empleado();
        public ControlVisitas()
        {
            InitializeComponent();
        }

       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarVisitantes();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.ShowDialog();
        }

        private void ControlVisitas_Load(object sender, EventArgs e)
        {
            MostrarVisitantes();
            cboAula.DataSource = n_Empleado.MostrarComboBox();
            cboAula.DisplayMember = "aula";
            cboEdificio.DataSource = n_Empleado.MostrarComboBox();
            cboEdificio.DisplayMember = "edificio";

        }
        public void MostrarVisitantes()
        {
            dataGridView1.DataSource = n_Empleado.MostrarVisita();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {
            n_Empleado.insertarVisita(txtNombre.Text, txtApellido.Text, cboCarrera.Text, cboEdificio.Text, cboAula.Text);
            MessageBox.Show("Visita agregada");
            MostrarVisitantes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar" + ex);
            }
        }
    }
}
