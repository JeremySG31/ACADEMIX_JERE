using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class seccionC
    {
        conexion x;
        public seccionC()
        {
            x = new conexion();
        }
        public void insert(seccionM dato)
        {
            x.manipular("insert into secciones values('" + dato.Id + "','" + dato.IdEstudiante + "')");
        }
        public void update(seccionM dato)
        {
            x.manipular("update secciones set id_estudiante='" + dato.IdEstudiante + "' where id='" + dato.Id + "'");
        }
        public void delete(seccionM dato)
        {
            x.manipular("delete from secciones where id ='" + dato.Id + "'");
        }


        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id_estudiante, nombre FROM secciones");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "id_estudiante";
            cbBuscarColumna.ValueMember = "nombre";
            cbBuscarColumna.SelectedIndex = 0;
        }
        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from secciones");

        }
    }
}