using ESTRES.controlador;
using ESTRES.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.vista
{
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
            this.Load += FrmCurso_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView row && row["id"] != DBNull.Value)
            {
                txtBuscar.Text = row["id"].ToString();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdCurso.Text = fila["id"].ToString();
                txtCurso.Text = fila["nombre"].ToString();
                txtDescripcion.Text = fila["descripcion"].ToString();
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCursos.Rows[e.RowIndex];
                txtIdCurso.Text = row.Cells["id"].Value?.ToString() ?? "";
                txtCurso.Text = row.Cells["nombre"].Value?.ToString() ?? "";
                txtDescripcion.Text = row.Cells["descripcion"].Value?.ToString() ?? "";
            }
        }

        private void ActualizarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            cursoC controlador = new cursoC();

            dgvCursos.DataSource = null;
            controlador.select(dgvCursos);

            cbBuscarColumna.DataSource = null;
            controlador.select(cbBuscarColumna);

            cbIdModificar.DataSource = null;
            controlador.selectIDModificar(cbIdModificar);

            cbIdEliminar.DataSource = null;
            controlador.selectIDEliminar(cbIdEliminar);

            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";

            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            txtIdCurso.Clear();
            txtCurso.Clear();
            txtDescripcion.Clear();

            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";

            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
                cursoN negocio = new cursoN();
                negocio.insertar(txtIdCurso.Text, txtCurso.Text, txtDescripcion.Text);
                ActualizarCampos();
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
                cursoN negocio = new cursoN();
                negocio.modificar(txtIdCurso.Text, txtCurso.Text, txtDescripcion.Text);
                ActualizarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null)
            {
                return;
            }

            try
            {
                cursoN negocio = new cursoN();
                negocio.eliminar(cbIdEliminar.SelectedValue.ToString(), "");
                ActualizarCampos();
            }
            catch (Exception)
            {
            }
        }
        private void btActualizarCampos_Click(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void btLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
    }
}