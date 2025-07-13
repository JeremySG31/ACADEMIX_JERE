using ESTRES.controlador;
using ESTRES.negocio;
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
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
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
                txtIdCurso.Text = fila["id"].ToString();
                txtCurso.Text = fila["nombre"].ToString();
                txtDescripcion.Text = fila["descripcion"].ToString();
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCursos.Rows[e.RowIndex];
                txtIdCurso.Text = row.Cells["id"].Value?.ToString() ?? "";
                txtCurso.Text = row.Cells["nombre"].Value?.ToString() ?? "";
                txtDescripcion.Text = row.Cells["descripcion"].Value?.ToString() ?? "";
            }
        }

        private void ActualizarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cursoC controlador = new cursoC();
            dgvCursos.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;
            controlador.select(dgvCursos);
            controlador.select(cbBuscarColumna);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);
            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            txtIdCurso.Clear();
            txtCurso.Clear();
            txtDescripcion.Clear();
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
        private bool ValidarLlenarCampos()
        {
            if (string.IsNullOrEmpty(txtIdCurso.Text) ||
                string.IsNullOrEmpty(txtCurso.Text) ||
                string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos (ID, Nombre y Descripción).", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!ValidarLlenarCampos()) return; 

            try
            {
                cursoN x = new cursoN();
                x.insertar(txtIdCurso.Text, txtCurso.Text, txtDescripcion.Text);
                ActualizarCampos();
                MessageBox.Show("Curso insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarLlenarCampos()) return; 
            if (cbIdModificar.SelectedValue == null || string.IsNullOrEmpty(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un ID de curso para modificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cursoN x = new cursoN();
                x.modificar(txtIdCurso.Text, txtCurso.Text, txtDescripcion.Text);
                ActualizarCampos();
                MessageBox.Show("Curso modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrEmpty(cbIdEliminar.SelectedValue.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cursoN x = new cursoN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString()); 
                ActualizarCampos();
                MessageBox.Show("Curso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btActualizarCampos_Click(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void btLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}