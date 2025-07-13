using Academix.negocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmAsistenciaMatriculados : Form
    {
        private AsistenciaMatriculadosN _asistenciaNegocio;
        private DataTable _originalDataSource;

        public FrmAsistenciaMatriculados()
        {
            InitializeComponent();
            _asistenciaNegocio = new AsistenciaMatriculadosN();
            ConfigurarEventos();
        }

        private void FrmAsistenciaMatriculados_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            dtpFecha.Value = DateTime.Today;
            CargarTodosMatriculadosYAsistenciasInicialmente();
            CargarCombosFiltrado();
        }

        private void ConfigurarEventos()
        {
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            cbNivel.SelectedIndexChanged += cbNivel_SelectedIndexChanged;
            cbGrado.SelectedIndexChanged += cbGrado_SelectedIndexChanged;
            cbSeccion.SelectedIndexChanged += cbSeccion_SelectedIndexChanged;
            dgvAsistencia.CurrentCellDirtyStateChanged += dgvAsistencia_CurrentCellDirtyStateChanged;
            dgvAsistencia.CellValueChanged += dgvAsistencia_CellValueChanged;
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

            dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nivel_nombre",
                HeaderText = "Nivel",
                DataPropertyName = "nivel_nombre",
                ReadOnly = true,
                Visible = true
            });
            dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "grado_nombre",
                HeaderText = "Grado",
                DataPropertyName = "grado_nombre",
                ReadOnly = true,
                Visible = true
            });
            dgvAsistencia.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "seccion_nombre",
                HeaderText = "Sección",
                DataPropertyName = "seccion_nombre",
                ReadOnly = true,
                Visible = true
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

        private void CargarTodosMatriculadosYAsistenciasInicialmente()
        {
            try
            {
                _originalDataSource = _asistenciaNegocio.cargarTodosMatriculadosConAsistencia(dtpFecha.Value.Date);
                dgvAsistencia.DataSource = _originalDataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos iniciales de estudiantes: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _originalDataSource = new DataTable();
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarTodosMatriculadosYAsistenciasInicialmente();
            CargarCombosFiltrado();
        }

        private void CargarCombosFiltrado()
        {
            var niveles = _originalDataSource.AsEnumerable().Select(row => row.Field<string>("nivel_nombre")).Distinct().ToList();
            niveles.Insert(0, "Todos");
            cbNivel.DataSource = niveles;
            cbNivel.SelectedIndex = 0;

            var grados = _originalDataSource.AsEnumerable().Select(row => row.Field<string>("grado_nombre")).Distinct().ToList();
            grados.Insert(0, "Todos");
            cbGrado.DataSource = grados;
            cbGrado.SelectedIndex = 0;

            var secciones = _originalDataSource.AsEnumerable().Select(row => row.Field<string>("seccion_nombre")).Distinct().ToList();
            secciones.Insert(0, "Todos");
            cbSeccion.DataSource = secciones;
            cbSeccion.SelectedIndex = 0;
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
                var row = dgvAsistencia.Rows[e.RowIndex];
                var drv = row.DataBoundItem as DataRowView;

                string idMatricula = row.Cells["id_matricula"].Value?.ToString();
                string nuevoEstado = row.Cells["estado_asistencia"].Value?.ToString();
                string idAsistencia = drv?["id_asistencia_existente"]?.ToString();
                DateTime fecha = dtpFecha.Value.Date;

                try
                {
                    if (!string.IsNullOrEmpty(idMatricula))
                    {
                        if (string.IsNullOrEmpty(nuevoEstado))
                        {
                            if (!string.IsNullOrEmpty(idAsistencia))
                            {
                                _asistenciaNegocio.eliminar(idAsistencia);
                                drv["id_asistencia_existente"] = DBNull.Value;
                                drv["estado_asistencia"] = ""; 
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(idAsistencia))
                            {
                                string nuevoId = _asistenciaNegocio.insertar(idMatricula, fecha, nuevoEstado);
                                drv["id_asistencia_existente"] = nuevoId;
                                drv["estado_asistencia"] = nuevoEstado;
                            }
                            else
                            {
                                _asistenciaNegocio.modificar(idAsistencia, idMatricula, fecha, nuevoEstado);
                                drv["estado_asistencia"] = nuevoEstado;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            string nivel = cbNivel.SelectedItem?.ToString();
            string grado = cbGrado.SelectedItem?.ToString();
            string seccion = cbSeccion.SelectedItem?.ToString();

            string filtro = "";

            if (!string.IsNullOrEmpty(nivel) && nivel != "Todos")
                filtro += $"nivel_nombre = '{nivel}'";

            if (!string.IsNullOrEmpty(grado) && grado != "Todos")
                filtro += (filtro != "" ? " AND " : "") + $"grado_nombre = '{grado}'";

            if (!string.IsNullOrEmpty(seccion) && seccion != "Todos")
                filtro += (filtro != "" ? " AND " : "") + $"seccion_nombre = '{seccion}'";

            try
            {
                _originalDataSource.DefaultView.RowFilter = filtro;
                dgvAsistencia.DataSource = _originalDataSource.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtro: " + ex.Message);
            }
        }
    }
}
