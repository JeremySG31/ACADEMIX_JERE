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
            x.manipular("insert into usuarios values('"
                + dato.Id + "','"
                + dato.NombreUsuario + "','"
                + dato.Nombres + "','"
                + dato.ApePaterno + "','"
                + dato.ApeMaterno + "','"
                + dato.Dni + "','"
                + dato.Correo + "','"
                + dato.Contrasena + "','"
                + dato.Rol + "','"
                + dato.Estado + "','"
                + dato.Telefono + "','");

        }
        public void update(usuarioM dato)
        {
            x.manipular("update usuarios set nombre_usuario='" + dato.NombreUsuario + "' where id='" + dato.Id + "'");
        }
        public void delete(usuarioM dato)
        {
            x.manipular("delete from usuarios where id='" + dato.Id + "'");
        }


        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id, nombres FROM usuarios");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombres";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = 0;
        }







        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT * from usuarios");

        }
    }


}