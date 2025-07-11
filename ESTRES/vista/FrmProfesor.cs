using Academix.controlador;
using Academix.vista;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
            this.Load += FrmProfesor_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            profesorC controlador = new profesorC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
        }
        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["id"] != DBNull.Value)
            {
                txtBuscar.Text = row["id"].ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmNuevoProfesor frmNuevoProfesor = new FrmNuevoProfesor();
            frmNuevoProfesor.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarProfesor frmModificarProfesor = new FrmModificarProfesor();
            frmModificarProfesor.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarProfesor frmEliminarProfesor = new FrmEliminarProfesor();
            frmEliminarProfesor.Show();
        }
    }
}
