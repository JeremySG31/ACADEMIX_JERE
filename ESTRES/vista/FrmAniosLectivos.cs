using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmAniosLectivos : Form
    {
        public FrmAniosLectivos()
        {
            InitializeComponent();
            this.Load += FrmAniosLectivos_Load;
        }

        private void FrmAniosLectivos_Load(object sender, EventArgs e)
        {
            controlador.aniosLectivosC controlador = new controlador.aniosLectivosC();
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
            FrmNuevoAnioLectivo frmNuevoAnioLectivo = new FrmNuevoAnioLectivo();
            frmNuevoAnioLectivo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarAnioLectivo frmModificarAnioLectivo = new FrmModificarAnioLectivo();
            frmModificarAnioLectivo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarAnioLectivo frmEliminarAnioLectivo = new FrmEliminarAnioLectivo();
            frmEliminarAnioLectivo.Show();
        }
    }
}
