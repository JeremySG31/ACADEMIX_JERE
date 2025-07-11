using Academix.controlador;
using ESTRES.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmCursosMatriculados : Form
    {
        public FrmCursosMatriculados()
        {
            InitializeComponent();
            this.Load += FrmCursosMatriculados_Load; 
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmCursosMatriculados_Load(object sender, EventArgs e)
        {
            cursoMatriculadoC controlador = new cursoMatriculadoC();
            controlador.select(dgvCursosMatriculados);
            controlador.select(cbBuscarColumna);
        }
        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["id_estudiante"] != DBNull.Value)
            {
                txtBuscar.Text = row["id_estudiante"].ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmNuevoCursoM frmNuevoCursoM = new FrmNuevoCursoM();
            frmNuevoCursoM.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarCursoM frmModificarCursoM = new FrmModificarCursoM();
            frmModificarCursoM.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCursoM frmEliminarCursoM = new FrmEliminarCursoM();
            frmEliminarCursoM.Show();
        }
    }
}
