using Academix.controlador;
using Academix.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmCursosMatriculados : Form
    {
        public FrmCursosMatriculados()
        {
            InitializeComponent();
            this.Load += FrmCursosMatriculados_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.dgvCursosMatriculados.CellClick += dgvCursosMatriculados_CellClick;
            this.btLimpiarCampos.Click += btLimpiarCampos_Click;
        }

        private void FrmCursosMatriculados_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            cursoMatriculadoC controlador = new cursoMatriculadoC();

            dgvCursosMatriculados.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbEstudiantes.DataSource = null;
            cbCursos.DataSource = null;
            cbIdMatricula.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;
            controlador.select(dgvCursosMatriculados);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectEstudiantes(cbEstudiantes);
            controlador.selectCursos(cbCursos);
            controlador.selectMatriculas(cbIdMatricula);
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
            txtCursoMatriculado.Text = "";
            cbEstudiantes.SelectedIndex = -1;
            cbEstudiantes.Text = "";
            cbCursos.SelectedIndex = -1;
            cbCursos.Text = "";
            cbIdMatricula.SelectedIndex = -1;
            cbIdMatricula.Text = "";
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
            else
            {
                txtBuscar.Clear();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtCursoMatriculado.Text = fila["id"].ToString();

                cbIdMatricula.SelectedValue = fila["id_matricula"] != DBNull.Value ? fila["id_matricula"].ToString() : null;
                cbCursos.SelectedValue = fila["id_cursos"] != DBNull.Value ? fila["id_cursos"].ToString() : null;

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
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void dgvCursosMatriculados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCursosMatriculados.Rows[e.RowIndex];
                txtCursoMatriculado.Text = row.Cells["id"].Value?.ToString() ?? "";

                cbIdMatricula.SelectedValue = row.Cells["id_matricula"].Value != DBNull.Value ? row.Cells["id_matricula"].Value.ToString() : null;
                cbCursos.SelectedValue = row.Cells["id_cursos"].Value != DBNull.Value ? row.Cells["id_cursos"].Value.ToString() : null;

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
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCursoMatriculado.Text) ||
                cbIdMatricula.SelectedValue == null ||
                cbCursos.SelectedValue == null ||
                cbEstudiantes.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos (ID, Matrícula, Curso y Estudiante) para insertar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cursoMatriculadoN x = new cursoMatriculadoN();
                x.insertar(txtCursoMatriculado.Text,
                           cbIdMatricula.SelectedValue.ToString(),
                           cbCursos.SelectedValue.ToString(),
                           cbEstudiantes.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Curso matriculado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar curso matriculado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCursoMatriculado.Text) ||
                cbIdMatricula.SelectedValue == null ||
                cbCursos.SelectedValue == null ||
                cbEstudiantes.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos (ID, Matrícula, Curso y Estudiante) para modificar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de curso matriculado a modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cursoMatriculadoN x = new cursoMatriculadoN();
                x.modificar(txtCursoMatriculado.Text,
                            cbIdMatricula.SelectedValue.ToString(),
                            cbCursos.SelectedValue.ToString(),
                            cbEstudiantes.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Curso matriculado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar curso matriculado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de curso matriculado para eliminar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cursoMatriculadoN x = new cursoMatriculadoN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Curso matriculado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar curso matriculado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}