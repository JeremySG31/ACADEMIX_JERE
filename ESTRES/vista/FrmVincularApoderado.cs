using Academix.controlador;
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
    public partial class FrmVincularApoderado : Form
    {
        public FrmVincularApoderado()
        {
            InitializeComponent();
            this.Load += FrmVincularApoderado_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmVincularApoderado_Load(object sender, EventArgs e)
        {
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
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

        public void ActualizarTabla()
        {
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.select(dgvUsuarios);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmNuevoVinculo frmNuevoVinculo = new FrmNuevoVinculo();
            frmNuevoVinculo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarVinculo frmModificarVinculo = new FrmModificarVinculo();
            frmModificarVinculo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarVinculo frmEliminarVinculo = new FrmEliminarVinculo();
            frmEliminarVinculo.Show();
        }

        private void btActualizarTabla_Click(object sender, EventArgs e)
        {
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.select(dgvUsuarios);
        }
    }
}
