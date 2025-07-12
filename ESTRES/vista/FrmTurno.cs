using ESTRES.controlador;
using ESTRES.negocio;
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
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            this.btLimpiarCampos.Click += btLimpiarCampos_Click;
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            turnoC controlador = new turnoC();

            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbEstudiantes.DataSource = null;
            cbTurno.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;

            controlador.select(dgvUsuarios);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectEstudiantes(cbEstudiantes);
            controlador.selectNombresTurno(cbTurno);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);

            LimpiarCampos();

            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            txtIdTurno.Text = "";
            cbEstudiantes.SelectedIndex = -1;
            cbEstudiantes.Text = "";
            cbTurno.SelectedIndex = -1;
            cbTurno.Text = "";
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
                txtIdTurno.Text = row.Cells["id"].Value?.ToString() ?? "";

                if (row.Cells["id_estudiante"].Value != DBNull.Value)
                {
                    string studentId = row.Cells["id_estudiante"].Value.ToString();
                    if (cbEstudiantes.Items.Count > 0 && (cbEstudiantes.DataSource as DataTable).Select($"id = '{studentId}'").Length > 0)
                    {
                        cbEstudiantes.SelectedValue = studentId;
                    }
                    else
                    {
                        cbEstudiantes.SelectedIndex = -1;
                        cbEstudiantes.Text = studentId;
                    }
                }
                else
                {
                    cbEstudiantes.SelectedIndex = -1;
                    cbEstudiantes.Text = "";
                }

                if (row.Cells["nombre"].Value != DBNull.Value)
                {
                    string turnoNombre = row.Cells["nombre"].Value.ToString();
                    if (cbTurno.Items.Count > 0 && (cbTurno.DataSource as DataTable).Select($"nombre = '{turnoNombre}'").Length > 0)
                    {
                        cbTurno.SelectedValue = turnoNombre;
                    }
                    else
                    {
                        cbTurno.SelectedIndex = -1;
                        cbTurno.Text = turnoNombre;
                    }
                }
                else
                {
                    cbTurno.SelectedIndex = -1;
                    cbTurno.Text = "";
                }
            }
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["nombre"] != DBNull.Value)
            {
                txtBuscar.Text = row["nombre"].ToString(); // Muestra el 'nombre'
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
                txtIdTurno.Text = fila["id"].ToString();

                if (fila["id_estudiante"] != DBNull.Value)
                {
                    string studentId = fila["id_estudiante"].ToString();
                    if (cbEstudiantes.Items.Count > 0 && (cbEstudiantes.DataSource as DataTable).Select($"id = '{studentId}'").Length > 0)
                    {
                        cbEstudiantes.SelectedValue = studentId;
                    }
                    else
                    {
                        cbEstudiantes.SelectedIndex = -1;
                        cbEstudiantes.Text = studentId;
                    }
                }
                else
                {
                    cbEstudiantes.SelectedIndex = -1;
                    cbEstudiantes.Text = "";
                }

                if (fila["nombre"] != DBNull.Value)
                {
                    string turnoNombre = fila["nombre"].ToString();
                    if (cbTurno.Items.Count > 0 && (cbTurno.DataSource as DataTable).Select($"nombre = '{turnoNombre}'").Length > 0)
                    {
                        cbTurno.SelectedValue = turnoNombre;
                    }
                    else
                    {
                        cbTurno.SelectedIndex = -1;
                        cbTurno.Text = turnoNombre;
                    }
                }
                else
                {
                    cbTurno.SelectedIndex = -1;
                    cbTurno.Text = "";
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTurno.Text) ||
                cbEstudiantes.SelectedValue == null ||
                cbTurno.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos (ID Turno, ID Estudiante y Turno) para insertar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                turnoN x = new turnoN();
                x.insertar(txtIdTurno.Text,
                           cbTurno.SelectedValue.ToString(),
                           cbEstudiantes.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Turno insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTurno.Text) ||
                cbEstudiantes.SelectedValue == null ||
                cbTurno.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos (ID Turno, ID Estudiante y Turno) para modificar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de turno a modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                turnoN x = new turnoN();
                x.modificar(txtIdTurno.Text,
                            cbTurno.SelectedValue.ToString(),
                            cbEstudiantes.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Turno modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de turno para eliminar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                turnoN x = new turnoN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Turno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}