﻿using ESTRES.controlador;
using ESTRES.negocio;
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
            this.cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            this.cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            this.dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            this.btLimpiarCampos.Click += btLimpiarCampos_Click;
            this.btnInsertar.Click += btnInsertar_Click;
            this.btnModificar.Click += btnModificar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            usuarioC controlador = new usuarioC();
            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;
            cbRol.DataSource = null;
            controlador.select(dgvUsuarios);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);
            controlador.selectRoles(cbRol);

            LimpiarCampos();
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            txtIdUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtNombres.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            txtDni.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
            txtTelefono.Text = "";
            if (cbRol.Items.Count > 0) cbRol.SelectedIndex = -1;
            cbRol.Text = "";
            if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = -1;
            cbEstado.Text = "";
            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtIdUsuario.Text = row.Cells["id"].Value?.ToString() ?? "";
                txtNombreUsuario.Text = row.Cells["nombre_usuario"].Value?.ToString() ?? "";
                txtNombres.Text = row.Cells["nombres"].Value?.ToString() ?? "";
                txtApePaterno.Text = row.Cells["ape_paterno"].Value?.ToString() ?? "";
                txtApeMaterno.Text = row.Cells["ape_materno"].Value?.ToString() ?? "";
                txtDni.Text = row.Cells["dni"].Value?.ToString() ?? "";
                txtCorreo.Text = row.Cells["correo"].Value?.ToString() ?? "";
                txtContrasena.Text = row.Cells["contrasena"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["telefono"].Value?.ToString() ?? "";

                if (row.Cells["rol"].Value != DBNull.Value)
                {
                    string rolIdFromUser = row.Cells["rol"].Value?.ToString() ?? "";

                    if (cbRol.DataSource is DataTable dtRol)
                    {
                        DataRow[] foundRows = dtRol.Select($"id = '{rolIdFromUser}'");
                        if (foundRows.Length > 0)
                        {
                            cbRol.SelectedValue = rolIdFromUser;
                        }
                        else
                        {
                            cbRol.SelectedIndex = -1;
                            cbRol.Text = rolIdFromUser;
                        }
                    }
                    else
                    {
                        cbRol.SelectedIndex = -1;
                        cbRol.Text = rolIdFromUser;
                    }
                }
                else
                {
                    cbRol.SelectedIndex = -1;
                    cbRol.Text = "";
                }

                if (row.Cells["estado"].Value != DBNull.Value)
                {
                    string estadoValue = row.Cells["estado"].Value?.ToString() ?? "";
                    int index = cbEstado.FindStringExact(estadoValue);
                    if (index != -1)
                    {
                        cbEstado.SelectedIndex = index;
                    }
                    else
                    {
                        cbEstado.SelectedIndex = -1;
                        cbEstado.Text = estadoValue;
                    }
                }
                else
                {
                    cbEstado.SelectedIndex = -1;
                    cbEstado.Text = "";
                }
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
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdUsuario.Text = fila["id"]?.ToString() ?? "";
                txtNombreUsuario.Text = fila["nombre_usuario"]?.ToString() ?? "";
                txtNombres.Text = fila["nombres"]?.ToString() ?? "";
                txtApePaterno.Text = fila["ape_paterno"]?.ToString() ?? "";
                txtApeMaterno.Text = fila["ape_materno"]?.ToString() ?? "";
                txtDni.Text = fila["dni"]?.ToString() ?? "";
                txtCorreo.Text = fila["correo"]?.ToString() ?? "";
                txtContrasena.Text = fila["contrasena"]?.ToString() ?? "";
                txtTelefono.Text = fila["telefono"]?.ToString() ?? "";

                if (fila["rol"] != DBNull.Value)
                {
                    string rolIdFromUser = fila["rol"]?.ToString() ?? "";

                    if (cbRol.DataSource is DataTable dtRol)
                    {
                        DataRow[] foundRows = dtRol.Select($"id = '{rolIdFromUser}'");
                        if (foundRows.Length > 0)
                        {
                            cbRol.SelectedValue = rolIdFromUser;
                        }
                        else
                        {
                            cbRol.SelectedIndex = -1;
                            cbRol.Text = rolIdFromUser;
                        }
                    }
                    else
                    {
                        cbRol.SelectedIndex = -1;
                        cbRol.Text = rolIdFromUser;
                    }
                }
                else
                {
                    cbRol.SelectedIndex = -1;
                    cbRol.Text = "";
                }

                if (fila["estado"] != DBNull.Value)
                {
                    string estadoValue = fila["estado"]?.ToString() ?? "";
                    int index = cbEstado.FindStringExact(estadoValue);
                    if (index != -1)
                    {
                        cbEstado.SelectedIndex = index;
                    }
                    else
                    {
                        cbEstado.SelectedIndex = -1;
                        cbEstado.Text = estadoValue;
                    }
                }
                else
                {
                    cbEstado.SelectedIndex = -1;
                    cbEstado.Text = "";
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApePaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApeMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cbRol.SelectedValue == null ||
                cbEstado.SelectedItem == null)
            {
                return; 
            }

            try
            {
                usuarioN x = new usuarioN();
                x.insertar(txtIdUsuario.Text,txtNombreUsuario.Text, txtNombres.Text, txtApePaterno.Text,txtApeMaterno.Text,txtDni.Text,txtCorreo.Text,txtContrasena.Text, cbRol.SelectedValue.ToString(), cbEstado.SelectedItem.ToString(),txtTelefono.Text);

                ActualizarCampos();
                MessageBox.Show("Usuario insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApePaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApeMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cbRol.SelectedValue == null ||
                cbEstado.SelectedItem == null)
            {
                return; 
            }
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                return; 
            }

            try
            {
                usuarioN x = new usuarioN();
                x.modificar(txtIdUsuario.Text,txtNombreUsuario.Text,txtNombres.Text,  txtApePaterno.Text, txtApeMaterno.Text, txtDni.Text, txtCorreo.Text,txtContrasena.Text, cbRol.SelectedValue.ToString(), cbEstado.SelectedItem.ToString(), txtTelefono.Text);

                ActualizarCampos(); 
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                usuarioN x = new usuarioN();
                x.eliminar(cbIdEliminar.SelectedValue.ToString());

                ActualizarCampos(); 
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}