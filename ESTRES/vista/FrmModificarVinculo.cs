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
    public partial class FrmModificarVinculo : Form
    {
        public FrmModificarVinculo()
        {
            InitializeComponent();
            this.Load += FrmModificarVinculo_Load;
            this.cbId.SelectedIndexChanged += cbId_SelectedIndexChanged;

        }

        private void FrmModificarVinculo_Load(object sender, EventArgs e)
        {
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.selectIDMatriculados(cbId); 
            controlador.selectIDapoderado(cbApoderado);
            controlador.selectIDestudiante(cbEstudiante);
            controlador.selectPrioridad(cbPrioridad);
            controlador.selectEstado(cbEstado);

            txtParentesco.Text = "";
        }


        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.SelectedItem != null)
            {
                estudianteApoderadoC controlador = new estudianteApoderadoC();
                var vinculo = controlador.obtenerPorId(cbId.Text);
                if (vinculo != null)
                {
                    cbId.Text = vinculo.Id;
                    cbApoderado.SelectedValue = vinculo.IdApoderado;
                    cbEstudiante.SelectedValue = vinculo.IdEstudiante;
                    txtParentesco.Text = vinculo.Parentesco;
                    cbPrioridad.SelectedValue = vinculo.Prioridad;
                    cbEstado.SelectedValue = vinculo.Estado;
                }
            }
        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            {
                estudianteApoderadoN negocio = new estudianteApoderadoN();
                int prioridad = 0;
                int.TryParse(cbPrioridad.SelectedValue?.ToString(), out prioridad);
                negocio.modificar(
                    cbId.Text,
                    cbApoderado.SelectedValue?.ToString() ?? "",
                    cbEstudiante.SelectedValue?.ToString() ?? "",
                    txtParentesco.Text,
                    prioridad,
                    cbEstado.SelectedValue?.ToString() ?? ""
                );
                MessageBox.Show("Registro modificado correctamente.");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
