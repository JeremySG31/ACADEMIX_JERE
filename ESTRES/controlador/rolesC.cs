using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class rolesC
    {
        conexion x;

        public rolesC()
        {
            x = new conexion();
        }

        public void insert(rolesM dato)
        {
            x.manipular("INSERT INTO roles VALUES('" + dato.Id + "','" + dato.NombreRol + "')");
        }

        public void update(rolesM dato)
        {
            x.manipular("UPDATE roles SET nombre_rol ='" + dato.NombreRol + "' WHERE id='" + dato.Id + "' AND id LIKE 'R%'");
        }

        public void delete(rolesM dato)
        {
            x.manipular("DELETE FROM roles WHERE id ='" + dato.Id + "' AND id LIKE 'R%'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id, nombre_rol FROM roles WHERE id LIKE 'R%'");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombre_rol";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT id, nombre_rol FROM roles WHERE id LIKE 'R%'");
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, nombre_rol FROM roles WHERE id LIKE 'R%'");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM roles WHERE id LIKE 'R%'");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }
    }
}