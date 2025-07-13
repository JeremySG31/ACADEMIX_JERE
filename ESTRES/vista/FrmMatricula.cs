using ESTRES.controlador;
using ESTRES.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmMatricula : Form
    {
        private matriculaN _matriculaNegocio;

        public FrmMatricula()
        {
            InitializeComponent();
            _matriculaNegocio = new matriculaN();

            this.Load += FrmMatricula_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;

            this.btnInsertar.Click += btnInsertar_Click;
            this.btnModificar.Click += btnModificar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btLimpiarCampos.Click += btLimpiarCampos_Click;
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbEstudiantes.DataSource = null;
            cbGrados.DataSource = null;
            cbIdApoderado.DataSource = null;
            cbSeccion.DataSource = null;
            cbTurno.DataSource = null;
            cbAñoLectivo.DataSource = null;
            cbEstado.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;

            _matriculaNegocio.seleccionar(dgvUsuarios);
            _matriculaNegocio.selectBuscarColumna(cbBuscarColumna);
            _matriculaNegocio.selectIDsEstudiantes(cbEstudiantes);
            _matriculaNegocio.selectIDsGrados(cbGrados);
            _matriculaNegocio.selectIDsApoderados(cbIdApoderado);
            _matriculaNegocio.selectIDsSecciones(cbSeccion);
            _matriculaNegocio.selectIDsTurnos(cbTurno);
            _matriculaNegocio.selectIDsAniosLectivos(cbAñoLectivo);
            _matriculaNegocio.selectIDsEstados(cbEstado);
            _matriculaNegocio.selectIDModificar(cbIdModificar);
            _matriculaNegocio.selectIDEliminar(cbIdEliminar);

            LimpiarCampos();

            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            txtIdMatricula.Text = "";
            cbEstudiantes.SelectedIndex = -1;
            cbGrados.SelectedIndex = -1;
            cbIdApoderado.SelectedIndex = -1;
            cbSeccion.SelectedIndex = -1;
            cbTurno.SelectedIndex = -1;
            cbAñoLectivo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            fechaMatricula.Value = DateTime.Now;
            txtBuscar.Text = "";
            textBuscar2.Text = "";

            if (cbBuscarColumna.Items.Count > 0) cbBuscarColumna.SelectedIndex = -1;
            if (cbIdModificar.Items.Count > 0) cbIdModificar.SelectedIndex = -1;
            if (cbIdEliminar.Items.Count > 0) cbIdEliminar.SelectedIndex = -1;

            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdMatricula.Text = row.Cells["id"].Value?.ToString() ?? "";
                cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value;
                cbGrados.SelectedValue = row.Cells["id_grado"].Value;
                fechaMatricula.Value = Convert.ToDateTime(row.Cells["fecha_matricula"].Value);
                cbIdApoderado.SelectedValue = row.Cells["id_apoderado"].Value;
                cbSeccion.SelectedValue = row.Cells["id_seccion"].Value;
                cbTurno.SelectedValue = row.Cells["id_turno"].Value;
                cbAñoLectivo.SelectedValue = row.Cells["id_aniolectivo"].Value;
                cbEstado.SelectedValue = row.Cells["estado"].Value;
            }
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView rowView)
            {
                txtBuscar.Text = rowView["id"]?.ToString() ?? "";
                textBuscar2.Text = rowView["fecha_matricula"]?.ToString() ?? "";
            }
            else
            {
                txtBuscar.Clear();
                textBuscar2.Clear();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdMatricula.Text = fila["id"]?.ToString() ?? "";
                cbEstudiantes.SelectedValue = fila["id_estudiante"];
                cbGrados.SelectedValue = fila["id_grado"];
                fechaMatricula.Value = Convert.ToDateTime(fila["fecha_matricula"]);
                cbIdApoderado.SelectedValue = fila["id_apoderado"];
                cbSeccion.SelectedValue = fila["id_seccion"];
                cbTurno.SelectedValue = fila["id_turno"];
                cbAñoLectivo.SelectedValue = fila["id_aniolectivo"];
                cbEstado.SelectedValue = fila["estado"];
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMatricula.Text) ||
                cbEstudiantes.SelectedValue == null || cbGrados.SelectedValue == null ||
                cbIdApoderado.SelectedValue == null || cbSeccion.SelectedValue == null ||
                cbTurno.SelectedValue == null || cbAñoLectivo.SelectedValue == null ||
                cbEstado.SelectedValue == null)
            {
                return;
            }

            try
            {
                _matriculaNegocio.insertar(
                    txtIdMatricula.Text,
                    cbEstudiantes.SelectedValue.ToString(),
                    cbGrados.SelectedValue.ToString(),
                    fechaMatricula.Value,
                    cbIdApoderado.SelectedValue.ToString(),
                    cbSeccion.SelectedValue.ToString(),
                    cbTurno.SelectedValue.ToString(),
                    cbAñoLectivo.SelectedValue.ToString(),
                    cbEstado.SelectedValue.ToString()
                );
                ActualizarCampos();
                MessageBox.Show("Matrícula insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar matrícula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMatricula.Text) ||
                cbEstudiantes.SelectedValue == null || cbGrados.SelectedValue == null ||
                cbIdApoderado.SelectedValue == null || cbSeccion.SelectedValue == null ||
                cbTurno.SelectedValue == null || cbAñoLectivo.SelectedValue == null ||
                cbEstado.SelectedValue == null || cbIdModificar.SelectedValue == null)
            {
                return;
            }

            try
            {
                _matriculaNegocio.modificar(
                    txtIdMatricula.Text,
                    cbEstudiantes.SelectedValue.ToString(),
                    cbGrados.SelectedValue.ToString(),
                    fechaMatricula.Value,
                    cbIdApoderado.SelectedValue.ToString(),
                    cbSeccion.SelectedValue.ToString(),
                    cbTurno.SelectedValue.ToString(),
                    cbAñoLectivo.SelectedValue.ToString(),
                    cbEstado.SelectedValue.ToString()
                );
                ActualizarCampos();
                MessageBox.Show("Matrícula modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar matrícula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                return;
            }

            try
            {
                _matriculaNegocio.eliminar(cbIdEliminar.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Matrícula eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar matrícula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}