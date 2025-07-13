using ESTRES.controlador;
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
            // Suscribir eventos para replicar la lógica de FrmTurno
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
            // Desuscribir eventos para evitar que se disparen al cargar los datos
            cbBuscarColumna.SelectedIndexChanged -= cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged -= cbIdModificar_SelectedIndexChanged;

            usuarioC controlador = new usuarioC();

            // Limpiar DataSources antes de asignar nuevos datos
            dgvUsuarios.DataSource = null;
            cbBuscarColumna.DataSource = null;
            cbIdModificar.DataSource = null;
            cbIdEliminar.DataSource = null;
            // Asegúrate de que cbRol y cbEstado existan y se llenen si es necesario.
            // Por ejemplo, si tienes una tabla 'Roles' y 'Estados' en tu BD:
            // controlador.selectRoles(cbRol); // Necesitarías crear este método en usuarioC
            // controlador.selectEstados(cbEstado); // Necesitarías crear este método en usuarioC

            controlador.select(dgvUsuarios);
            controlador.selectBuscarColumna(cbBuscarColumna);
            controlador.selectIDModificar(cbIdModificar);
            controlador.selectIDEliminar(cbIdEliminar);

            LimpiarCampos();

            // Volver a suscribir eventos
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
        }

        private void LimpiarCampos()
        {
            // Desuscribir para evitar disparos al limpiar
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
            cbRol.SelectedIndex = -1; // Asumiendo un ComboBox para el rol
            cbRol.Text = "";
            cbEstado.SelectedIndex = -1; // Asumiendo un ComboBox para el estado
            cbEstado.Text = "";

            cbBuscarColumna.SelectedIndex = -1;
            cbBuscarColumna.Text = "";
            txtBuscar.Clear();
            cbIdModificar.SelectedIndex = -1;
            cbIdModificar.Text = "";
            cbIdEliminar.SelectedIndex = -1;
            cbIdEliminar.Text = "";

            // Volver a suscribir
            cbIdModificar.SelectedIndexChanged += cbIdModificar_SelectedIndexChanged;
            cbBuscarColumna.SelectedIndexChanged += cbBuscarColumna_SelectedIndexChanged;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                // Acceso a los valores de las celdas del DataGridView
                txtIdUsuario.Text = row.Cells["id"].Value?.ToString() ?? "";
                txtNombreUsuario.Text = row.Cells["nombre_usuario"].Value?.ToString() ?? "";
                txtNombres.Text = row.Cells["nombres"].Value?.ToString() ?? "";
                txtApePaterno.Text = row.Cells["ape_paterno"].Value?.ToString() ?? ""; // Usar ape_paterno
                txtApeMaterno.Text = row.Cells["ape_materno"].Value?.ToString() ?? ""; // Usar ape_materno
                txtDni.Text = row.Cells["dni"].Value?.ToString() ?? "";
                txtCorreo.Text = row.Cells["correo"].Value?.ToString() ?? "";
                // La contraseña no debe cargarse directamente por seguridad
                // txtContrasena.Text = row.Cells["contrasena"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["telefono"].Value?.ToString() ?? "";

                // Cargar ComboBox para Rol (asegúrate de que cbRol tenga su DataSource asignado previamente)
                if (row.Cells["rol"].Value != DBNull.Value)
                {
                    string rolValue = row.Cells["rol"].Value.ToString();
                    // Verificar que cbRol.DataSource sea un DataTable antes de usar Select
                    if (cbRol.Items.Count > 0 && (cbRol.DataSource is DataTable dtRol) && dtRol.Select($"rol = '{rolValue}'").Length > 0)
                    {
                        cbRol.SelectedValue = rolValue;
                    }
                    else
                    {
                        cbRol.SelectedIndex = -1;
                        cbRol.Text = rolValue;
                    }
                }
                else
                {
                    cbRol.SelectedIndex = -1;
                    cbRol.Text = "";
                }

                // Cargar ComboBox para Estado (asegúrate de que cbEstado tenga su DataSource asignado previamente)
                if (row.Cells["estado"].Value != DBNull.Value)
                {
                    string estadoValue = row.Cells["estado"].Value.ToString();
                    // Verificar que cbEstado.DataSource sea un DataTable antes de usar Select
                    if (cbEstado.Items.Count > 0 && (cbEstado.DataSource is DataTable dtEstado) && dtEstado.Select($"estado = '{estadoValue}'").Length > 0)
                    {
                        cbEstado.SelectedValue = estadoValue;
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
            // Castear SelectedItem a DataRowView para acceder a las columnas
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
            // Castear SelectedItem a DataRowView para acceder a las columnas
            if (cbIdModificar.SelectedItem is DataRowView fila)
            {
                txtIdUsuario.Text = fila["id"]?.ToString() ?? "";
                txtNombreUsuario.Text = fila["nombre_usuario"]?.ToString() ?? "";
                txtNombres.Text = fila["nombres"]?.ToString() ?? "";
                txtApePaterno.Text = fila["ape_paterno"]?.ToString() ?? ""; // Usar ape_paterno
                txtApeMaterno.Text = fila["ape_materno"]?.ToString() ?? ""; // Usar ape_materno
                txtDni.Text = fila["dni"]?.ToString() ?? "";
                txtCorreo.Text = fila["correo"]?.ToString() ?? "";
                // La contraseña no debe cargarse directamente por seguridad
                // txtContrasena.Text = fila["contrasena"]?.ToString() ?? "";
                txtTelefono.Text = fila["telefono"]?.ToString() ?? "";

                // Cargar ComboBox para Rol
                if (fila["rol"] != DBNull.Value)
                {
                    string rolValue = fila["rol"].ToString();
                    if (cbRol.Items.Count > 0 && (cbRol.DataSource is DataTable dtRol) && dtRol.Select($"rol = '{rolValue}'").Length > 0)
                    {
                        cbRol.SelectedValue = rolValue;
                    }
                    else
                    {
                        cbRol.SelectedIndex = -1;
                        cbRol.Text = rolValue;
                    }
                }
                else
                {
                    cbRol.SelectedIndex = -1;
                    cbRol.Text = "";
                }

                // Cargar ComboBox para Estado
                if (fila["estado"] != DBNull.Value)
                {
                    string estadoValue = fila["estado"].ToString();
                    if (cbEstado.Items.Count > 0 && (cbEstado.DataSource is DataTable dtEstado) && dtEstado.Select($"estado = '{estadoValue}'").Length > 0)
                    {
                        cbEstado.SelectedValue = estadoValue;
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
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApePaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApeMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cbRol.SelectedValue == null || // Usar SelectedValue para ComboBox
                cbEstado.SelectedValue == null) // Usar SelectedValue para ComboBox
            {
                MessageBox.Show("Por favor, complete todos los campos (ID, Nombre de Usuario, Nombres, Apellidos, DNI, Correo, Contraseña, Rol, Estado) para insertar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                usuarioN negocio = new usuarioN();
                negocio.insertar(txtIdUsuario.Text,
                                 txtNombreUsuario.Text,
                                 txtNombres.Text,
                                 txtApePaterno.Text, // Envía el texto directo
                                 txtApeMaterno.Text, // Envía el texto directo
                                 txtDni.Text,
                                 txtCorreo.Text,
                                 txtContrasena.Text,
                                 cbRol.SelectedValue.ToString(), // Obtiene el valor del ComboBox
                                 cbEstado.SelectedValue.ToString(), // Obtiene el valor del ComboBox
                                 txtTelefono.Text);
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
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApePaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApeMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cbRol.SelectedValue == null || // Usar SelectedValue para ComboBox
                cbEstado.SelectedValue == null) // Usar SelectedValue para ComboBox
            {
                MessageBox.Show("Por favor, complete todos los campos (ID, Nombre de Usuario, Nombres, Apellidos, DNI, Correo, Contraseña, Rol, Estado) para modificar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Asegúrate de que un usuario para modificar esté seleccionado
            if (cbIdModificar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdModificar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de usuario a modificar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                usuarioN negocio = new usuarioN();
                negocio.modificar(txtIdUsuario.Text,
                                 txtNombreUsuario.Text,
                                 txtNombres.Text,
                                 txtApePaterno.Text, // Envía el texto directo
                                 txtApeMaterno.Text, // Envía el texto directo
                                 txtDni.Text,
                                 txtCorreo.Text,
                                 txtContrasena.Text,
                                 cbRol.SelectedValue.ToString(), // Obtiene el valor del ComboBox
                                 cbEstado.SelectedValue.ToString(), // Obtiene el valor del ComboBox
                                 txtTelefono.Text);
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
            // Asegúrate de que un usuario para eliminar esté seleccionado
            if (cbIdEliminar.SelectedValue == null || string.IsNullOrWhiteSpace(cbIdEliminar.SelectedValue.ToString()))
            {
                MessageBox.Show("Debe seleccionar un ID de usuario para eliminar.", "Selección Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                usuarioN negocio = new usuarioN();
                negocio.eliminar(cbIdEliminar.SelectedValue.ToString()); // Obtiene el valor del ComboBox
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