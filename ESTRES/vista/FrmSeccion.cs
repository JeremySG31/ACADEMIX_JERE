using Academix.controlador;
using Academix.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmSeccion : Form
    {
        public FrmSeccion()
        {
            InitializeComponent();
            this.Load += FrmSeccion_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.btLimpiarCampos.Click += btLimpiarCampos_Click_1; // Asegura que este evento esté suscrito
        }

        private void FrmSeccion_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            // Desuscribe eventos para evitar disparadores múltiples durante la actualización de DataSource
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            seccionC controlador = new seccionC();

            // Limpia DataSources antes de asignar nuevos datos
            dgvUsuarios.DataSource = null; // Asumo que dgvUsuarios es el DataGridView para Secciones
            cbBuscarColumna.DataSource = null;
            cbEstudiantes.DataSource = null;
            // cbSeccion necesita su DataSource cargado
            // if (cbSeccion.DataSource != null) cbSeccion.DataSource = null; // No es necesario si se carga estáticamente
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;

            // Carga los datos
            controlador.select(dgvUsuarios);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectEstudiantes(cbEstudiantes);
            controlador.selectSeccionesABC(cbSeccion); // <-- NUEVO: Carga las secciones A, B, C...
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

            txtIdSeccion.Text = "";
            cbEstudiantes.SelectedIndex = -1;
            cbEstudiantes.Text = "";
            cbSeccion.SelectedIndex = -1;
            cbSeccion.Text = ""; // Asegura que el texto también se borre
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
                txtIdSeccion.Text = fila["id"].ToString();

                // Intenta seleccionar el estudiante por su ID
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

                // Intenta seleccionar la sección por su nombre
                string nombreSeccionDesdeDB = fila["nombre"].ToString();
                int index = cbSeccion.FindStringExact(nombreSeccionDesdeDB);
                if (index != ListBox.NoMatches)
                {
                    cbSeccion.SelectedIndex = index;
                }
                else
                {
                    cbSeccion.Text = nombreSeccionDesdeDB; // Si no se encuentra, solo establece el texto
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdSeccion.Text = row.Cells["id"].Value?.ToString() ?? "";

                // Establece el SelectedValue para el ComboBox de Estudiantes
                if (row.Cells["id_estudiante"].Value != null)
                {
                    cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value.ToString();
                }
                else
                {
                    cbEstudiantes.SelectedIndex = -1;
                    cbEstudiantes.Text = "";
                }

                // Intenta seleccionar la sección por su nombre desde el DGV
                string nombreSeccionDesdeDGV = row.Cells["nombre_seccion"].Value?.ToString() ?? "";
                int index = cbSeccion.FindStringExact(nombreSeccionDesdeDGV);
                if (index != ListBox.NoMatches)
                {
                    cbSeccion.SelectedIndex = index;
                }
                else
                {
                    cbSeccion.Text = nombreSeccionDesdeDGV; // Si no se encuentra, solo establece el texto
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdSeccion.Text) || cbEstudiantes.SelectedValue == null || cbSeccion.SelectedValue == null) // Usar SelectedValue para cbSeccion
            {
                MessageBox.Show("Por favor, ingrese un ID de Sección, seleccione un Estudiante y una Sección (A, B, C...).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                seccionN x = new seccionN();
                // --- CORRECCIÓN: Orden y tipo de parámetros ---
                x.insertar(txtIdSeccion.Text, cbSeccion.SelectedValue.ToString(), cbEstudiantes.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Sección insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar sección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdSeccion.Text) || cbEstudiantes.SelectedValue == null || cbSeccion.SelectedValue == null) // Usar SelectedValue para cbSeccion
            {
                MessageBox.Show("Por favor, ingrese un ID de Sección, seleccione un Estudiante y una Sección (A, B, C...) para modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Además, verificar si se ha seleccionado un elemento para modificar
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de sección a modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                seccionN x = new seccionN();
                // --- CORRECCIÓN: Orden y tipo de parámetros ---
                x.modificar(txtIdSeccion.Text, cbSeccion.SelectedValue.ToString(), cbEstudiantes.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Sección modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar sección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de sección para eliminar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                seccionN x = new seccionN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString()); // Usar SelectedValue para el ID
                ActualizarCampos();
                MessageBox.Show("Sección eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar sección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}