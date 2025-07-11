using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class profesorC
    {
        conexion x;
        public profesorC()
        {
            x = new conexion();
        }
        public void insert(profesorM dato)
        {
            x.manipular("insert into profesores values('" + dato.Id + "','" + dato.IdUsuario + "')");
        }
        public void update(profesorM dato)
        {
            x.manipular("update profesores set id_usuario='" + dato.IdUsuario + "' where id='" + dato.Id + "'");
        }
        public void delete(profesorM dato)
        {
            x.manipular("delete from profesores where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT p.id, u.nombres FROM profesores p JOIN usuarios u ON p.id_usuario = u.id;");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombres";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = 0;
        }




        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT  p.id,  u.nombres,   u.ape_paterno,   u.ape_materno, " +
                "u.estado, u.nombre_usuario  FROM profesores p JOIN usuarios u ON p.id_usuario = u.id;");

        }
    }
}
