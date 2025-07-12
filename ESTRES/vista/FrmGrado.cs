using Academix.controlador;
using Academix.modelo;
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
            // Desuscribe eventos para evitar disparadores múltiples durante la actualización de DataSource
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            gradoC controlador = new gradoC();

            // Limpia DataSources antes de asignar nuevos datos
            dgvUsuarios.DataSource = null; // Asumo que dgvUsuarios es el DataGridView para Grados
            cbEstudiantes.DataSource = null;
            cbGrados.DataSource = null;
            cbNiveles.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;

            // Carga los datos
            controlador.select(dgvUsuarios);
            controlador.selectEstudiantes(cbEstudiantes);
            controlador.selectGrados(cbGrados);
            controlador.selectNiveles(cbNiveles);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);

            LimpiarCampos(); // Llama a limpiar campos después de cargar los datos de los ComboBox

            // Vuelve a suscribir eventos
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            // Desuscribe eventos temporalmente para evitar que se disparen al limpiar
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

            // Vuelve a suscribir eventos
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

                // Asegúrate de que SelectedValue se usa con el ValueMember correcto (ID del estudiante)
                if (cbEstudiantes.DataSource is DataTable dtEstudiantes)
                {
                    DataRow[] foundRows = dtEstudiantes.Select($"id = '{fila["id_estudiante"]}'");
                    if (foundRows.Length > 0)
                    {
                        cbEstudiantes.SelectedValue = fila["id_estudiante"].ToString();
                    }
                    else
                    {
                        cbEstudiantes.SelectedIndex = -1; // No se encontró el estudiante, deseleccionar
                        cbEstudiantes.Text = "";
                    }
                }

                // Para Grados y Niveles, si DisplayMember y ValueMember son el mismo (el nombre), usar SelectedValue = nombre es correcto
                if (cbGrados.DataSource is DataTable dtGrados)
                {
                    DataRow[] foundRows = dtGrados.Select($"nombre_grado = '{fila["nombres"]}'");
                    if (foundRows.Length > 0)
                    {
                        cbGrados.SelectedValue = fila["nombres"].ToString();
                    }
                    else
                    {
                        cbGrados.SelectedIndex = -1;
                        cbGrados.Text = "";
                    }
                }

                if (cbNiveles.DataSource is DataTable dtNiveles)
                {
                    DataRow[] foundRows = dtNiveles.Select($"nombre_nivel = '{fila["nivel"]}'");
                    if (foundRows.Length > 0)
                    {
                        cbNiveles.SelectedValue = fila["nivel"].ToString();
                    }
                    else
                    {
                        cbNiveles.SelectedIndex = -1;
                        cbNiveles.Text = "";
                    }
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdGrado.Text = row.Cells["id"].Value?.ToString() ?? "";

                // Establece el SelectedValue para los ComboBox según los datos de la fila
                if (row.Cells["id_estudiante"].Value != null)
                {
                    cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value.ToString();
                }
                else
                {
                    cbEstudiantes.SelectedIndex = -1;
                    cbEstudiantes.Text = "";
                }

                if (row.Cells["nombres"].Value != null)
                {
                    cbGrados.SelectedValue = row.Cells["nombres"].Value.ToString();
                }
                else
                {
                    cbGrados.SelectedIndex = -1;
                    cbGrados.Text = "";
                }

                if (row.Cells["nivel"].Value != null)
                {
                    cbNiveles.SelectedValue = row.Cells["nivel"].Value.ToString();
                }
                else
                {
                    cbNiveles.SelectedIndex = -1;
                    cbNiveles.Text = "";
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Valida que los ComboBox tengan un valor seleccionado
            if (string.IsNullOrEmpty(txtIdGrado.Text) || cbEstudiantes.SelectedValue == null ||
                cbGrados.SelectedValue == null || cbNiveles.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                gradoN x = new gradoN();
                // Usar SelectedValue para el ID del estudiante, y Text para los nombres/niveles (ya que DisplayMember y ValueMember son los mismos para esos CBs)
                x.insertar(txtIdGrado.Text, cbGrados.Text, cbEstudiantes.SelectedValue.ToString(), cbNiveles.Text);
                ActualizarCampos();
                MessageBox.Show("Grado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el grado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Valida que los ComboBox tengan un valor seleccionado
            if (string.IsNullOrEmpty(txtIdGrado.Text) || cbEstudiantes.SelectedValue == null ||
                cbGrados.SelectedValue == null || cbNiveles.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos para la modificación.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrEmpty(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de grado para modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                gradoN x = new gradoN();
                // Usar SelectedValue para el ID del estudiante, y Text para los nombres/niveles
                x.modificar(txtIdGrado.Text, cbGrados.Text, cbEstudiantes.SelectedValue.ToString(), cbNiveles.Text);
                ActualizarCampos();
                MessageBox.Show("Grado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el grado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbIdEliminar.SelectedValue?.ToString() ?? ""))
            {
                MessageBox.Show("Debe seleccionar un ID de grado para eliminar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                gradoN x = new gradoN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString()); // Usar SelectedValue para el ID
                ActualizarCampos();
                MessageBox.Show("Grado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el grado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}