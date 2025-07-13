using ESTRES.dao;
using ESTRES.modelo;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class usuarioC
    {
        conexion x;

        public usuarioC()
        {
            x = new conexion();
        }

        public void insert(usuarioM dato)
        {
            x.manipular("INSERT INTO usuarios (id, nombre_usuario, nombres, ape_paterno, ape_materno, dni, correo, contrasena, rol, estado, telefono) VALUES('"
                + dato.Id + "','"
                + dato.NombreUsuario + "','"
                + dato.Nombres + "','"
                + dato.ApePaterno + "','"
                + dato.ApeMaterno + "','"
                + dato.Dni + "','"
                + dato.Correo + "','"
                + dato.Contrasena + "','"
                + dato.Rol + "','" // Aquí se espera el ID del rol
                + dato.Estado + "','"
                + dato.Telefono + "')");
        }

        public void update(usuarioM dato)
        {
            x.manipular("UPDATE usuarios SET nombre_usuario='" + dato.NombreUsuario + "', nombres='" + dato.Nombres + "', ape_paterno='" + dato.ApePaterno + "', ape_materno='" + dato.ApeMaterno + "', dni='" + dato.Dni + "', correo='" + dato.Correo + "', contrasena='" + dato.Contrasena + "', rol='" + dato.Rol + "', estado='" + dato.Estado + "', telefono='" + dato.Telefono + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(string idUsuario)
        {
            x.manipular("DELETE FROM usuarios WHERE id ='" + idUsuario + "'");
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT id, nombre_usuario, nombres, ape_paterno, ape_materno, contrasena, dni, correo, rol, estado, telefono FROM usuarios");
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombres FROM usuarios");
            cb.DataSource = dt;
            cb.DisplayMember = "nombres";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, nombre_usuario, nombres, ape_paterno, ape_materno, contrasena, dni, correo, contrasena, rol, estado, telefono FROM usuarios");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM usuarios");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        // --- MÉTODO REINCLUIDO PARA ROLES ---
        public void selectRoles(ComboBox cb)
        {
            // Asume una tabla 'roles' con columnas 'id' y 'nombre_rol'
            DataTable dt = x.manipular("SELECT id, nombre_rol FROM roles ORDER BY nombre_rol");
            cb.DataSource = dt;
            cb.DisplayMember = "nombre_rol"; // Columna a mostrar en el ComboBox
            cb.ValueMember = "id";           // Columna cuyo valor se usará (el ID del rol)
            cb.SelectedIndex = -1; // Ningún elemento seleccionado por defecto
        }
    }
}