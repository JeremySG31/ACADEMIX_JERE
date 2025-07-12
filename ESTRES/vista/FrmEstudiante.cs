using Academix.controlador;
using Academix.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
            this.Load += FrmEstudiante_Load;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView fila && fila["id"] != DBNull.Value)
            {
                txtBuscar.Text = fila["id"].ToString();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdEstudiante.Text = fila["id"].ToString();
                txtNombres.Text = fila["nombres"].ToString();
                txtNombreUsuario.Text = fila["nombre_usuario"].ToString();
                txtApePater.Text = fila["ape_paterno"].ToString();
                txtApeMater.Text = fila["ape_materno"].ToString();
                string estado = fila["estado"].ToString();
                cbEstado.SelectedValue = estado;
            }
        }

        private void ActualizarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            estudianteC controlador = new estudianteC();

            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbEstado.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;

            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
            controlador.selectEstado(cbEstado);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);

            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
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


            txtIdEstudiante.Clear();
            txtNombres.Clear();
            txtNombreUsuario.Clear();
            txtApePater.Clear();
            txtApeMater.Clear();
            cbEstado.SelectedIndex = -1;
            cbEstado.Text = "";
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";
            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();

            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!ValidarLlenarCampos()) return;

            try
            {
                estudianteN x = new estudianteN();
                x.insertar(txtIdEstudiante.Text, txtNombres.Text, txtNombreUsuario.Text, txtApePater.Text, txtApeMater.Text, cbEstado.SelectedValue?.ToString() ?? "");
                ActualizarCampos();
                MessageBox.Show("Estudiante insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, seleccione un ID de estudiante para modificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                estudianteN x = new estudianteN();
                x.modificar(txtIdEstudiante.Text, txtNombres.Text, txtNombreUsuario.Text, txtApePater.Text, txtApeMater.Text, cbEstado.SelectedValue?.ToString() ?? "");
                ActualizarCampos();
                MessageBox.Show("Estudiante modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                estudianteN x = new estudianteN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString()); 
                ActualizarCampos();
                MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarLlenarCampos()
        {
            if (string.IsNullOrEmpty(txtIdEstudiante.Text) ||
                string.IsNullOrEmpty(txtNombres.Text) ||
                string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtApePater.Text) ||
                string.IsNullOrEmpty(txtApeMater.Text) ||
                cbEstado.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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