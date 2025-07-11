using Academix.vista;
using ESTRES.controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmTurno : Form
    {
        public FrmTurno()
        {
            InitializeComponent();
            this.Load += FrmTurno_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            turnoC controlador = new turnoC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["nombre"] != DBNull.Value)
            {
                txtBuscar.Text = row["nombre"].ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmNuevoTurno frmNuevoTurno = new FrmNuevoTurno();
            frmNuevoTurno.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarTurno frmModificarTurno = new FrmModificarTurno();
            frmModificarTurno.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarTurno frmEliminarTurno = new FrmEliminarTurno();
            frmEliminarTurno.Show();
        }
    }
}