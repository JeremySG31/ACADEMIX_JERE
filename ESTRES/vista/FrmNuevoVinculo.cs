using Academix.controlador;
using Academix.negocio;
using ESTRES.controlador;
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
    public partial class FrmNuevoVinculo : Form
    {
        public FrmNuevoVinculo()
        {
            InitializeComponent();
            this.Load += FrmNuevoVinculo_Load;
        }

        private void FrmNuevoVinculo_Load(object sender, EventArgs e)
        {
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.selectIDapoderado(cbApoderado);
            controlador.selectIDestudiante(cbEstudiante);
            controlador.selectPrioridad(cbPrioridad);
            controlador.selectEstado(cbEstado);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
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
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
