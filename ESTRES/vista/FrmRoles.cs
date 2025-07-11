using Academix.controlador;
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
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
            this.Load += FrmRoles_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            rolesC controlador = new rolesC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["id"] != DBNull.Value)
            {
                txtBuscar.Text = row["id"].ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmNuevoRol frmNuevoRol = new FrmNuevoRol();
            frmNuevoRol.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarRol frmModificarRol = new FrmModificarRol();
            frmModificarRol.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarRol frmEliminarRol = new FrmEliminarRol();
            frmEliminarRol.Show();
        }
    }
}
