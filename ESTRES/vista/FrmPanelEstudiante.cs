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
    public partial class FrmPanelEstudiante : Form
    {
        public FrmPanelEstudiante()
        {
            InitializeComponent();
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
