using Academix.controlador;
using System;
using System.Data;
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

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
