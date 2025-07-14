using ESTRES.vista;
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
    public partial class FrmPanelApoderado : Form
    {
        public FrmPanelApoderado()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil();
            frmPerfil.Show();
        }

        private void historialAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarHistorialA frmConsultarHistorialA = new FrmConsultarHistorialA();
            frmConsultarHistorialA.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            this.Close();
        }
    }
}
