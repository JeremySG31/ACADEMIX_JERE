using Academix.controlador;
using Academix.negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmRoles : Form
    {
        private rolesN _rolesNegocio;

        public FrmRoles()
        {
            InitializeComponent();
            _rolesNegocio = new rolesN();

            this.Load += FrmRoles_Load;
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;

            this.btnInsertar.Click += btnInsertar_Click;
            this.btnModificar.Click += btnModificar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btLimpiarCampos.Click += btLimpiarCampos_Click;
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;

            _rolesNegocio.seleccionar(dgvUsuarios);
            _rolesNegocio.selectBuscarColumna(cbBuscarColumna);
            _rolesNegocio.selectIDModificar(cbIdModificar);
            _rolesNegocio.selectIDEliminar(cbIdEliminar);

            LimpiarCampos();

            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;

            textBox1.Text = "";
            txtNombreRol.Text = "";
            txtBuscar.Text = "";

            if (cbBuscarColumna.Items.Count > 0) cbBuscarColumna.SelectedIndex = -1;
            if (cbIdModificar.Items.Count > 0) cbIdModificar.SelectedIndex = -1;
            if (cbIdEliminar.Items.Count > 0) cbIdEliminar.SelectedIndex = -1;

            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id"].Value?.ToString() ?? "";
                txtNombreRol.Text = row.Cells["nombre_rol"].Value?.ToString() ?? "";
            }
        }

        private void cbBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarColumna.SelectedItem is DataRowView rowView && rowView["id"] != DBNull.Value)
            {
                txtBuscar.Text = rowView["id"].ToString();
            }
            else
            {
                txtBuscar.Clear();
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdModificar.SelectedItem is DataRowView fila && fila["id"] != DBNull.Value)
            {
                textBox1.Text = fila["id"]?.ToString() ?? "";
                txtNombreRol.Text = fila["nombre_rol"]?.ToString() ?? "";
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                return;
            }

            try
            {
                _rolesNegocio.insertar(textBox1.Text, txtNombreRol.Text);
                ActualizarCampos();
                MessageBox.Show("Rol insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                return;
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                return;
            }

            try
            {
                _rolesNegocio.modificar(textBox1.Text, txtNombreRol.Text);
                ActualizarCampos();
                MessageBox.Show("Rol modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                return;
            }

            try
            {
                _rolesNegocio.eliminar(cbIdEliminar.SelectedValue.ToString());
                ActualizarCampos();
                MessageBox.Show("Rol eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}