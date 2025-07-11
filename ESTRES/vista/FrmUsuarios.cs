using Academix.vista;
using ESTRES.controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            this.Load += FrmUsuarios_Load;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            usuarioC controlador = new usuarioC();
            controlador.select(dgvUsuarios);
            controlador.select(cbBuscarColumna);
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
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            frmNuevoUsuario.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarUsuario frmModificarUsuario= new FrmModificarUsuario(); 
            frmModificarUsuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEliminarUsuario frmEliminarUsuario = new FrmEliminarUsuario();
            frmEliminarUsuario.Show();
        }
    }
}
