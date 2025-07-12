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
            this.btnInsertar.Click += btnInsertar_Click;
            this.btnModificar.Click += btnModificar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
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
            controlador.select(dgvCursosMatriculados);
            cbBuscarColumna.DataSource = null;
            controlador.selectBuscarColumna(cbBuscarColumna);
            cbEstudiantes.DataSource = null;
            controlador.selectEstudiantes(cbEstudiantes);
            cbCursos.DataSource = null;
            controlador.selectCursos(cbCursos);
            cbIdMatricula.DataSource = null;
            controlador.selectMatriculas(cbIdMatricula);
            cbIdModificar.DataSource = null;
            controlador.selectIDModificar(cbIdModificar);
            cbIdEliminar.DataSource = null;
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
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["id_estudiante"] != DBNull.Value)
            {
                txtBuscar.Text = row["id_estudiante"].ToString();
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
                cbIdMatricula.SelectedValue = fila["id_matricula"]?.ToString();
                cbCursos.SelectedValue = fila["id_cursos"]?.ToString();
                cbEstudiantes.SelectedValue = fila["id_estudiante"]?.ToString();
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
                cbIdMatricula.SelectedValue = row.Cells["id_matricula"].Value?.ToString();
                cbCursos.SelectedValue = row.Cells["id_cursos"].Value?.ToString();
                cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value?.ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cursoMatriculadoN x = new cursoMatriculadoN();

            x.insertar(txtCursoMatriculado.Text,cbIdMatricula.Text,cbCursos.Text,cbEstudiantes.Text);
            ActualizarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            cursoMatriculadoN x = new cursoMatriculadoN();

            x.modificar(txtCursoMatriculado.Text,cbIdMatricula.Text,cbCursos.Text,cbEstudiantes.Text);
            ActualizarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cursoMatriculadoN x = new cursoMatriculadoN();
            x.eliminar(cbIdEliminar.Text);
            ActualizarCampos();
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}