using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmSeccion : Form
    {
        public FrmSeccion()
        {
            InitializeComponent();
            this.Load += FrmSeccion_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmSeccion_Load(object sender, EventArgs e)
        {
            controlador.seccionC controlador = new controlador.seccionC();
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
 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
