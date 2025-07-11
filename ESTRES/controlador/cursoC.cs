using ESTRES.dao;
using ESTRES.modelo;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class cursoC
    {
        conexion x;
        public cursoC()
        {
            x = new conexion();
        }
        public void insert(cursoM dato)
        {
            x.manipular("insert into cursos values('" + dato.Id + "','" + dato.Nombre + "')");
        }
        public void update(cursoM dato)
        {
            x.manipular("update cursos set nombre='" + dato.Nombre + "' where id='" + dato.Id + "'");
        }
        public void delete(cursoM dato)
        {
            x.manipular("delete from cursos where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id,nombre FROM cursos");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombre";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = 0;
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT * from cursos");

        }
    }
}
