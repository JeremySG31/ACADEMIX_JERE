using Academix.controlador;
using Academix.negocio;
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
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.dgvUsuarios.CellClick += dgvUsuarios_CellClick; 
            this.btLimpiarCampos.Click += btLimpiarCampos_Click;
        }

        private void FrmAniosLectivos_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            aniosLectivosC controlador = new aniosLectivosC();

            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;
            cbEstado.DataSource = null;


            controlador.select(dgvUsuarios);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);
            controlador.selectEstados(cbEstado);

            LimpiarCampos();

            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            txtIdAnioLectivo.Text = "";
            txtAnioLectivo.Text = ""; 
            txtDescripcion.Text = "";
            cbEstado.SelectedIndex = -1;
            cbEstado.Text = ""; 
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdAnioLectivo.Text = row.Cells["id"].Value?.ToString() ?? "";
                txtAnioLectivo.Text = row.Cells["nombre"].Value?.ToString() ?? ""; 
                txtDescripcion.Text = row.Cells["descripcion"].Value?.ToString() ?? "";

                string estado = row.Cells["estado"].Value?.ToString() ?? "";
                if (cbEstado.Items.Count > 0 && (cbEstado.DataSource as DataTable).Select($"Estado = '{estado}'").Length > 0)
                {
                    cbEstado.SelectedValue = estado;
                }
                else
                {
                    cbEstado.SelectedIndex = -1;
                    cbEstado.Text = estado;
                }
            }
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["nombre"] != DBNull.Value)
            {
                txtBuscar.Text = row["nombre"].ToString(); 
            }
            else
            {
                txtBuscar.Clear();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdAnioLectivo.Text = fila["id"].ToString();
                txtAnioLectivo.Text = fila["nombre"].ToString();
                txtDescripcion.Text = fila["descripcion"].ToString();
                string estado = fila["estado"].ToString();
                if (cbEstado.Items.Count > 0 && (cbEstado.DataSource as DataTable).Select($"Estado = '{estado}'").Length > 0)
                {
                    cbEstado.SelectedValue = estado;
                }
                else
                {
                    cbEstado.SelectedIndex = -1;
                    cbEstado.Text = estado;
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdAnioLectivo.Text) ||
                string.IsNullOrWhiteSpace(txtAnioLectivo.Text) || 
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cbEstado.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos (ID, Año, Descripción y Estado) para insertar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                aniosLectivosN negocio = new aniosLectivosN();
                negocio.insertar(txtIdAnioLectivo.Text,
                                 txtAnioLectivo.Text, 
                                 txtDescripcion.Text,
                                 cbEstado.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Año lectivo insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar año lectivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdAnioLectivo.Text) ||
                string.IsNullOrWhiteSpace(txtAnioLectivo.Text) || 
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cbEstado.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos (ID, Año, Descripción y Estado) para modificar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de año lectivo a modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                aniosLectivosN negocio = new aniosLectivosN();
                negocio.modificar(txtIdAnioLectivo.Text,
                                  txtAnioLectivo.Text, 
                                  txtDescripcion.Text,
                                  cbEstado.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Año lectivo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar año lectivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de año lectivo para eliminar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                aniosLectivosN negocio = new aniosLectivosN();
                negocio.eliminar(cbIdEliminar.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Año lectivo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar año lectivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }
}