using Academix.controlador;
using Academix.negocio;
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
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
    
        }

        private void FrmGrado_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            gradoC controlador = new gradoC();
            dgvUsuarios.DataSource = null;
            controlador.select(dgvUsuarios);
            cbEstudiantes.DataSource = null;
            controlador.selectEstudiantes(cbEstudiantes);
            cbGrados.DataSource = null;
            controlador.selectGrados(cbGrados);
            cbNiveles.DataSource = null;
            controlador.selectNiveles(cbNiveles);
            cbBuscarColumna.DataSource = null;
            controlador.selectBuscarColumna(cbBuscarColumna);
            cbIdModificar.DataSource = null;
            controlador.selectIDModificar(cbIdModificar);
            cbIdEliminar.DataSource = null;
            controlador.selectIDEliminar(cbIdEliminar);
            LimpiarCampos();
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            txtIdGrado.Clear();
            cbEstudiantes.SelectedIndex = -1;
            cbEstudiantes.Text = "";
            cbGrados.SelectedIndex = -1;
            cbGrados.Text = "";
            cbNiveles.SelectedIndex = -1;
            cbNiveles.Text = "";
            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["id"] != DBNull.Value)
            {
                txtBuscar.Text = row["id"].ToString();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdGrado.Text = fila["id"].ToString();
                cbEstudiantes.SelectedValue = fila["id_estudiante"].ToString();
                cbGrados.SelectedValue = fila["nombres"].ToString();
                cbNiveles.SelectedValue = fila["nivel"].ToString();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdGrado.Text = row.Cells["id"].Value?.ToString() ?? "";
                cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value?.ToString() ?? "";
                cbGrados.SelectedValue = row.Cells["nombres"].Value?.ToString() ?? "";
                cbNiveles.SelectedValue = row.Cells["nivel"].Value?.ToString() ?? "";
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdGrado.Text) || cbEstudiantes.SelectedValue == null ||
                cbGrados.SelectedValue == null || cbNiveles.SelectedValue == null)
            {
                return;
            }

            try
            {
                gradoN x = new gradoN();

                x.insertar(txtIdGrado.Text,cbEstudiantes.Text,cbGrados.Text,cbNiveles.Text);
                ActualizarCampos();
            }
            catch (Exception)
            {
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdGrado.Text) || cbEstudiantes.SelectedValue == null ||
                cbGrados.SelectedValue == null || cbNiveles.SelectedValue == null)
            {
                return;
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrEmpty(cbIdModificar.SelectedValue.ToString()))
            {
                return;
            }

            try
            {
                gradoN x = new gradoN();
                x.modificar(txtIdGrado.Text, cbEstudiantes.Text,cbGrados.Text,cbNiveles.Text);
                ActualizarCampos();
            }
            catch (Exception)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbIdEliminar.SelectedValue?.ToString() ?? ""))
            {
                return;
            }

            gradoN x = new gradoN();
            x.eliminar(cbIdEliminar.Text);
            ActualizarCampos();
        }
        private void btLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
    }
}