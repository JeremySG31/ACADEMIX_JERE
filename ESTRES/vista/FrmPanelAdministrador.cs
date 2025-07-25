﻿using Academix.vista;
using ESTRES.vista;
using System;
using System.Windows.Forms;

namespace ESTRES
{
    public partial class FrmPanelAdministrador : Form
    {
        public FrmPanelAdministrador()
        {
            InitializeComponent();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApoderado frmApoderado = new FrmApoderado();
            frmApoderado.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesor frmProfesor = new FrmProfesor();
            frmProfesor.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmEstudiante = new FrmEstudiante();
            frmEstudiante.Show();
        }





        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula frmMatricula = new FrmMatricula();
            frmMatricula.Show();
        }

        private void turnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTurno frmTurno = new FrmTurno();
            frmTurno.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso();
            frmCurso.Show();
        }

        private void seccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSeccion frmSeccion = new FrmSeccion();
            frmSeccion.Show();
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrado frmGrado = new FrmGrado();
            frmGrado.Show();
        }

        private void añosLectivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAniosLectivos frmAniosLectivos = new FrmAniosLectivos();
            frmAniosLectivos.Show();
        }

        private void historialAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarHistorialA frmConsultarHistorialA = new FrmConsultarHistorialA();
            frmConsultarHistorialA.Show();
        }


        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            frmRoles.Show();
        }

        private void cursosMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursosMatriculados frmCursosMatriculados = new FrmCursosMatriculados();
            frmCursosMatriculados.Show();
        }

        private void asociarApoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVincularApoderado frmVincularApoderado = new FrmVincularApoderado();
            frmVincularApoderado.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            FrmLogin login = new FrmLogin();
            this.Close();
        }
    }

}
