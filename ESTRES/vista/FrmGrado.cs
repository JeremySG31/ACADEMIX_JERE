using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmGrado : Form
    {
        public FrmGrado()
        {
            InitializeComponent();
            this.Load += FrmGrado_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmGrado_Load(object sender, System.EventArgs e)
        {
            controlador.gradoC controlador = new controlador.gradoC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["nombres"] != DBNull.Value)
            {
                txtBuscar.Text = row["nombres"].ToString();
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