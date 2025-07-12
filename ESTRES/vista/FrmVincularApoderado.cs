using Academix.controlador;
using Academix.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmVincularApoderado : Form
    {
        public FrmVincularApoderado()
        {
            InitializeComponent();
            this.Load += FrmVincularApoderado_Load;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmVincularApoderado_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem != null)
            {
                DataRowView fila = cbBuscarColumna.SelectedItem as DataRowView;
                if (fila != null)
                {
                    txtBuscar.Text = fila["id_estudiante"].ToString();
                    txtBuscar2.Text = fila["parentesco"].ToString();
                }
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtVinculo.Text = fila["id"].ToString();
                cbApoderado.SelectedValue = fila["id_apoderado"].ToString();
                cbEstudiante.SelectedValue = fila["id_estudiante"].ToString();
                txtParentesco.Text = fila["parentesco"].ToString();
                cbPrioridad.SelectedValue = Convert.ToInt32(fila["prioridad"]);
                cbEstado.SelectedValue = fila["estado"].ToString();
            }
        }
        private void btActualizarCampos_Click(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            cbIdModificar.DataSource = null;
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
            controlador.selectIDapoderado(cbApoderado);
            controlador.selectIDestudiante(cbEstudiante);
            controlador.selectPrioridad(cbPrioridad);
            controlador.selectEstado(cbEstado);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            txtParentesco.Clear();
            txtVinculo.Clear();
            cbApoderado.SelectedIndex = -1;
            cbApoderado.Text = "";
            cbEstudiante.SelectedIndex = -1;
            cbEstudiante.Text = "";
            cbPrioridad.SelectedIndex = -1;
            cbPrioridad.Text = "";
            cbEstado.SelectedIndex = -1;
            cbEstado.Text = "";
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }


        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarLlenarCampos()) return;

            estudianteApoderadoN x = new estudianteApoderadoN();
            int prioridad = 0;
            int.TryParse(cbPrioridad.SelectedValue?.ToString(), out prioridad);

            x.insertar(txtVinculo.Text,cbApoderado.SelectedValue?.ToString() ?? "",cbEstudiante.SelectedValue?.ToString() ?? "", txtParentesco.Text,prioridad, cbEstado.SelectedValue?.ToString() ?? "");
            MessageBox.Show("Registro insertado correctamente.");
            ActualizarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarLlenarCampos()) return;

            try
            {
                estudianteApoderadoN x = new estudianteApoderadoN();
                int prioridad = Convert.ToInt32(cbPrioridad.SelectedValue);

                x.modificar(txtVinculo.Text, cbApoderado.SelectedValue.ToString(),cbEstudiante.SelectedValue.ToString(),txtParentesco.Text,prioridad,cbEstado.SelectedValue.ToString()
                );

                MessageBox.Show("Registro modificado correctamente.",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                ActualizarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.",
                              "Selección requerida",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            estudianteApoderadoN x = new estudianteApoderadoN();
            x.eliminar(cbIdEliminar.Text, "", "", "", 0, "");
            MessageBox.Show("Registro eliminado correctamente.");
            ActualizarCampos();
        }

        private bool ValidarLlenarCampos()
        {
            if (cbPrioridad.SelectedValue == null ||
                cbApoderado.SelectedValue == null ||
                cbEstudiante.SelectedValue == null ||
                cbEstado.SelectedValue == null ||
                string.IsNullOrEmpty(txtVinculo.Text) ||
                string.IsNullOrEmpty(txtParentesco.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.",
                              "Campos Incompletos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
