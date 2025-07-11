using ESTRES.controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
            this.Load += FrmCurso_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            cursoC controlador = new cursoC();
            controlador.select(dgvCursos);
            controlador.select(cbBuscarColumna);
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
