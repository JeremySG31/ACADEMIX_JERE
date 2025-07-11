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
    public partial class FrmEliminarVinculo : Form
    {
        public FrmEliminarVinculo()
        {
            InitializeComponent();
            this.Load += FrmEliminarVinculo_Load;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btCancelar.Click += btCancelar_Click;
        }

        private void FrmEliminarVinculo_Load(object sender, EventArgs e)
        {
            estudianteApoderadoC controlador = new estudianteApoderadoC();
            controlador.select(cbId); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                string id = cbId.Text;

                estudianteApoderadoN negocio = new estudianteApoderadoN();
                negocio.eliminar(id, "", "", "", 0, "");

                MessageBox.Show("Registro eliminado correctamente.");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
