using Academix.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmAsistenciaMatriculados : Form
    {
        private AsistenciaMatriculadosN _asistenciaNegocio;

        public FrmAsistenciaMatriculados()
        {
            InitializeComponent();
            _asistenciaNegocio = new AsistenciaMatriculadosN();

            this.Load += FrmAsistenciaMatriculados_Load;

            this.cbNivel.SelectedIndexChanged += cbNivel_SelectedIndexChanged;
            this.cbGrado.SelectedIndexChanged += cbGrado_SelectedIndexChanged;
            this.cbSeccion.SelectedIndexChanged += cbSeccion_SelectedIndexChanged;
            this.dtpFecha.ValueChanged += dtpFecha_ValueChanged;

            this.chkA.Click += chkA_Click;
            this.chkT.Click += chkT_Click;
            this.chkF.Click += chkF_Click;

            this.dgvAsistencia.CellValueChanged += dgvAsistencia_CellValueChanged;
            this.dgvAsistencia.CurrentCellDirtyStateChanged += dgvAsistencia_CurrentCellDirtyStateChanged;
        }

        private void FrmAsistenciaMatriculados_Load(object sender, EventArgs e)
        {
            CargarCombosIniciales();
            ConfigurarDataGridView();
            // La carga del DGV ahora depende de que Grado y Sección estén seleccionados, y la fecha
        }

        private void CargarCombosIniciales()
        {
            // Solo se carga el ComboBox de Nivel desde la DB
            _asistenciaNegocio.seleccionarNiveles(cbNivel);

            // Los ComboBox de Grado y Sección DEBEN ser llenados manualmente en el Diseñador
            // Opcional: podrías limpiar la selección inicial si no hay elementos por defecto en el diseño
            cbGrado.SelectedIndex = -1;
            cbSeccion.SelectedIndex = -1;
        }

        private void ConfigurarDataGridView()
        {
            dgvAsistencia.Columns.Clear();
            dgvAsistencia.AutoGenerateColumns = false;

            dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id_matricula",
                HeaderText = "ID Matrícula",
                DataPropertyName = "id_matricula",
                ReadOnly = true,
                Visible = false
            });

            dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nombre_completo_estudiante",
                HeaderText = "Estudiante",
                DataPropertyName = "nombre_completo_estudiante",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            DataGridViewComboBoxColumn cmbEstado = new DataGridViewComboBoxColumn();
            cmbEstado.HeaderText = "Estado";
            cmbEstado.Name = "estado_asistencia";
            cmbEstado.DataPropertyName = "estado_asistencia";

            DataTable dtEstados = _asistenciaNegocio.obtenerEstadosAsistenciaParaDGV();
            cmbEstado.DataSource = dtEstados;
            cmbEstado.DisplayMember = "estado";
            cmbEstado.ValueMember = "id";

            cmbEstado.DisplayStyleForCurrentCellOnly = true;

            dgvAsistencia.Columns.Add(cmbEstado);

            dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id_asistencia_existente",
                HeaderText = "ID Asistencia (existente)",
                DataPropertyName = "id_asistencia_existente",
                Visible = false
            });
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando cambia el nivel, solo se limpia la selección de Grado y Sección
            // y se espera que el usuario seleccione manualmente los nuevos valores
            cbGrado.SelectedIndex = -1;
            cbSeccion.SelectedIndex = -1;
            dgvAsistencia.DataSource = null;
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo cargar si Grado y Sección están seleccionados (y fecha)
            if (cbGrado.SelectedItem != null && cbSeccion.SelectedItem != null)
            {
                CargarMatriculadosYAsistenciasEnDGV();
            }
            else
            {
                dgvAsistencia.DataSource = null;
            }
        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo cargar si Grado y Sección están seleccionados (y fecha)
            if (cbGrado.SelectedItem != null && cbSeccion.SelectedItem != null)
            {
                CargarMatriculadosYAsistenciasEnDGV();
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            // Solo cargar si Grado y Sección están seleccionados (y fecha)
            if (cbGrado.SelectedItem != null && cbSeccion.SelectedItem != null)
            {
                CargarMatriculadosYAsistenciasEnDGV();
            }
        }

        private void CargarMatriculadosYAsistenciasEnDGV()
        {
            // Asegurarse de que todos los filtros necesarios estén seleccionados
            if (cbNivel.SelectedValue == null || cbGrado.SelectedItem == null || cbSeccion.SelectedItem == null)
            {
                dgvAsistencia.DataSource = null;
                return;
            }

            string nivelSeleccionado = cbNivel.SelectedValue.ToString();
            string nombreGradoSeleccionado = cbGrado.SelectedItem.ToString();
            string nombreSeccionSeleccionada = cbSeccion.SelectedItem.ToString();
            DateTime fechaSeleccionada = dtpFecha.Value.Date;

            // Obtener los IDs reales de la base de datos para el grado y la sección seleccionados manualmente
            string idGrado = _asistenciaNegocio.obtenerIdGrado(nombreGradoSeleccionado, nivelSeleccionado);
            string idSeccion = _asistenciaNegocio.obtenerIdSeccion(nombreSeccionSeleccionada);

            if (string.IsNullOrEmpty(idGrado))
            {
                MessageBox.Show($"No se encontró el ID para el grado '{nombreGradoSeleccionado}' en el nivel '{nivelSeleccionado}'. Asegúrate de que existe en la DB y el nombre coincide.", "Error de Grado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvAsistencia.DataSource = null;
                return;
            }
            if (string.IsNullOrEmpty(idSeccion))
            {
                MessageBox.Show($"No se encontró el ID para la sección '{nombreSeccionSeleccionada}'. Asegúrate de que existe en la DB y el nombre coincide.", "Error de Sección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvAsistencia.DataSource = null;
                return;

            }

            _asistenciaNegocio.cargarMatriculadosConAsistencia(dgvAsistencia, idGrado, idSeccion, fechaSeleccionada);
        }

        private void chkA_Click(object sender, EventArgs e)
        {
            AplicarEstadoMasivo("A");
            DesmarcarOtrosCheckboxes(chkA);
        }

        private void chkT_Click(object sender, EventArgs e)
        {
            AplicarEstadoMasivo("T");
            DesmarcarOtrosCheckboxes(chkT);
        }

        private void chkF_Click(object sender, EventArgs e)
        {
            AplicarEstadoMasivo("F");
            DesmarcarOtrosCheckboxes(chkF);
        }

        private void DesmarcarOtrosCheckboxes(CheckBox currentCheckbox)
        {
            if (currentCheckbox != chkA) chkA.Checked = false;
            if (currentCheckbox != chkT) chkT.Checked = false;
            if (currentCheckbox != chkF) chkF.Checked = false;
        }

        private void AplicarEstadoMasivo(string estado)
        {
            if (dgvAsistencia.DataSource == null) return;
            dgvAsistencia.EndEdit();

            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                if (row.Cells["estado_asistencia"] is DataGridViewComboBoxCell cell)
                {
                    cell.Value = estado;
                }
            }
        }

        private void dgvAsistencia_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAsistencia.IsCurrentCellDirty)
            {
                dgvAsistencia.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvAsistencia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAsistencia.Columns["estado_asistencia"].Index)
            {
                DataGridViewRow row = dgvAsistencia.Rows[e.RowIndex];

                string idMatricula = row.Cells["id_matricula"].Value?.ToString();
                string estado = row.Cells["estado_asistencia"].Value?.ToString();
                string idAsistenciaExistente = row.Cells["id_asistencia_existente"].Value?.ToString();
                DateTime fechaAsistencia = dtpFecha.Value.Date;

                try
                {
                    if (string.IsNullOrEmpty(idMatricula) || string.IsNullOrEmpty(estado))
                    {
                        return;
                    }

                    if (string.IsNullOrEmpty(idAsistenciaExistente) || idAsistenciaExistente == DBNull.Value.ToString())
                    {
                        string newId = _asistenciaNegocio.insertar(idMatricula, fechaAsistencia, estado);
                        row.Cells["id_asistencia_existente"].Value = newId;
                    }
                    else
                    {
                        _asistenciaNegocio.modificar(idAsistenciaExistente, idMatricula, fechaAsistencia, estado);
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Error de validación: {ex.Message}", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar asistencia para el estudiante {row.Cells["nombre_completo_estudiante"].Value?.ToString()}: {ex.Message}", "Error en Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}