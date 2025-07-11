using Academix.vista;
using ESTRES.controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
            this.Load += FrmMatricula_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            matriculaC controlador = new matriculaC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);

        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem != null)
            {
                DataRowView fila = cbBuscarColumna.SelectedItem as DataRowView;
                if (fila != null)
                {
                    txtBuscar.Text = fila["id_estudiante"].ToString();
                    textBuscar2.Text = fila["fecha_matricula"].ToString();
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmNuevaMatricula frmNuevaMatricula = new FrmNuevaMatricula();
            frmNuevaMatricula.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarMatricula frmModificarMatricula = new FrmModificarMatricula();
            frmModificarMatricula.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarMatricula frmEliminarMatricula = new FrmEliminarMatricula();
            frmEliminarMatricula.Show();
        }
    }
}
