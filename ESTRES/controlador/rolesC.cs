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
            x.manipular("insert into roles values('" + dato.Id + "','" + dato.NombreRol + "')");
        }
        public void update(rolesM dato)
        {
            x.manipular("update roles set nombre_rol ='" + dato.NombreRol + "' where id='" + dato.Id + "'");
        }
        public void delete(rolesM dato)
        {
            x.manipular("delete from roles where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id, nombre_rol FROM roles");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombre_rol";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = 0;


        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from roles");

        }
    }
}