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
            this.btLimpiarCampos.Click += btLimpiarCampos_Click_1; 
        }

        private void FrmSeccion_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            seccionC controlador = new seccionC();
            dgvUsuarios.DataSource = null; 
            cbBuscarColumna.DataSource = null;
            cbEstudiantes.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;
            controlador.select(dgvUsuarios);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectEstudiantes(cbEstudiantes);
            controlador.selectSeccionesABC(cbSeccion); 
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);
            LimpiarCampos(); 
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            txtIdSeccion.Text = "";
            cbEstudiantes.SelectedIndex = -1;
            cbEstudiantes.Text = "";
            cbSeccion.SelectedIndex = -1;
            cbSeccion.Text = ""; 
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
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdSeccion.Text = fila["id"].ToString();
                if (cbEstudiantes.DataSource is DataTable dtEstudiantes)
                {
                    DataRow[] foundRows = dtEstudiantes.Select($"id = '{fila["id_estudiante"]}'");
                    if (foundRows.Length > 0)
                    {
                        cbEstudiantes.SelectedValue = fila["id_estudiante"].ToString();
                    }
                    else
                    {
                        cbEstudiantes.SelectedIndex = -1; 
                        cbEstudiantes.Text = "";
                    }
                }
                string nombreSeccionDesdeDB = fila["nombre"].ToString();
                int index = cbSeccion.FindStringExact(nombreSeccionDesdeDB);
                if (index != ListBox.NoMatches)
                {
                    cbSeccion.SelectedIndex = index;
                }
                else
                {
                    cbSeccion.Text = nombreSeccionDesdeDB;
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdSeccion.Text = row.Cells["id"].Value?.ToString() ?? "";
                if (row.Cells["id_estudiante"].Value != null)
                {
                    cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value.ToString();
                }
                else
                {
                    cbEstudiantes.SelectedIndex = -1;
                    cbEstudiantes.Text = "";
                }
                string nombreSeccionDesdeDGV = row.Cells["nombre_seccion"].Value?.ToString() ?? "";
                int index = cbSeccion.FindStringExact(nombreSeccionDesdeDGV);
                if (index != ListBox.NoMatches)
                {
                    cbSeccion.SelectedIndex = index;
                }
                else
                {
                    cbSeccion.Text = nombreSeccionDesdeDGV; 
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
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de sección a modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                seccionN x = new seccionN();
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
                x.eliminar(cbIdEliminar.SelectedValue.ToString()); 
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