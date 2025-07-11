using Academix.controlador;
using Academix.negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
            controlador.selectIDapoderado(cbApoderado);
            controlador.selectIDestudiante(cbEstudiante);
            controlador.selectPrioridad(cbPrioridad);
            controlador.selectEstado(cbEstado);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);

            txtParentesco.Text = "";
            txtVinculo.Text = "";
            txtBuscar.Text = "";
            txtBuscar2.Text = "";

            cbApoderado.SelectedIndex = -1;
            cbEstudiante.SelectedIndex = -1;
            cbPrioridad.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            cbIdEliminar.SelectedIndex = -1;
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            estudianteApoderadoN negocio = new estudianteApoderadoN();

            int prioridad = 0;
            int.TryParse(cbPrioridad.SelectedValue?.ToString(), out prioridad);

            negocio.insertar(
                txtVinculo.Text,
                cbApoderado.SelectedValue?.ToString() ?? "",
                cbEstudiante.SelectedValue?.ToString() ?? "",
                txtParentesco.Text,
                prioridad,
                cbEstado.SelectedValue?.ToString() ?? ""
            );
            MessageBox.Show("Registro insertado correctamente.");
            ActualizarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {       if (cbPrioridad.SelectedValue == null || 
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
                    return;
                }

                estudianteApoderadoN negocio = new estudianteApoderadoN();
                int prioridad = Convert.ToInt32(cbPrioridad.SelectedValue);

                negocio.modificar(
                    txtVinculo.Text,
                    cbApoderado.SelectedValue.ToString(),
                    cbEstudiante.SelectedValue.ToString(),
                    txtParentesco.Text,
                    prioridad,
                    cbEstado.SelectedValue.ToString()
                );
                
                MessageBox.Show("Registro modificado correctamente.", 
                               "Éxito", 
                               MessageBoxButtons.OK, 
                               MessageBoxIcon.Information);
                ActualizarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: Asegúrese de seleccionar valores válidos en todos los campos.\nDetalles: " + ex.Message,
                               "Error de Operación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al modificar el registro.\nDetalles: " + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var idSeleccionado = cbIdEliminar.SelectedValue?.ToString() ?? "";
            estudianteApoderadoN negocio = new estudianteApoderadoN();
            negocio.eliminar(idSeleccionado, "", "", "", 0, "");
            MessageBox.Show("Registro eliminado correctamente.");
            ActualizarCampos();
        }
    }
}