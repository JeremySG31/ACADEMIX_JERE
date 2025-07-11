using ESTRES.dao;
using ESTRES.modelo;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class estudianteC
    {
        conexion x;
        public estudianteC()
        {
            x = new conexion();
        }
        public void insert(estudianteM dato)
        {
            x.manipular("insert into estudiantes values('" + dato.Id + "','" + dato.IdUsuario + "')");
        }
        public void update(estudianteM dato)
        {
            x.manipular("update estudiantes set id_usuario='" + dato.IdUsuario + "' where id='" + dato.Id + "'");
        }
        public void delete(estudianteM dato)
        {
            x.manipular("delete from estudiantes where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT e.id, u.nombres FROM estudiantes e JOIN usuarios u ON e.id_usuario = u.id;");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombres";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = 0;
        }




        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT  e.id,  u.nombres,   u.ape_paterno,   u.ape_materno, " +
                "u.estado, u.nombre_usuario  FROM estudiantes e JOIN usuarios u ON e.id_usuario = u.id;");

        }
    }
}
