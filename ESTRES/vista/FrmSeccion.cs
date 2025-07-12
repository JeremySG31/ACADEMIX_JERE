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
            controlador.select(dgvUsuarios);
            cbBuscarColumna.DataSource = null;
            controlador.selectBuscarColumna(cbBuscarColumna);
            cbEstudiantes.DataSource = null;
            controlador.selectEstudiantes(cbEstudiantes);
            cbIdModificar.DataSource = null;
            controlador.selectIDModificar(cbIdModificar);
            cbIdEliminar.DataSource = null;
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
                cbEstudiantes.SelectedValue = fila["id_estudiante"].ToString();

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
                cbEstudiantes.SelectedValue = row.Cells["id_estudiante"].Value?.ToString() ?? "";
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
            if (string.IsNullOrWhiteSpace(txtIdSeccion.Text) || cbEstudiantes.SelectedValue == null || cbSeccion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese un ID de Sección, seleccione un Estudiante y una Sección (A, B, C...).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                seccionN negocio = new seccionN();
                string idSeccion = txtIdSeccion.Text; 
                string idEstudiante = cbEstudiantes.SelectedValue.ToString();
                string nombreSeccion = cbSeccion.SelectedItem.ToString();

                negocio.insertar(idSeccion, nombreSeccion, idEstudiante);
                ActualizarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar sección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdSeccion.Text) || cbEstudiantes.SelectedValue == null || cbSeccion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese un ID de Sección, seleccione un Estudiante y una Sección (A, B, C...) para modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                seccionN negocio = new seccionN();
                string idSeccion = txtIdSeccion.Text; 
                string idEstudiante = cbEstudiantes.SelectedValue.ToString();
                string nombreSeccion = cbSeccion.SelectedItem.ToString();

                negocio.modificar(idSeccion, nombreSeccion, idEstudiante);
                ActualizarCampos();
   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                seccionN negocio = new seccionN();
                negocio.eliminar(cbIdEliminar.SelectedValue.ToString());
                ActualizarCampos();
            }


        private void btLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}