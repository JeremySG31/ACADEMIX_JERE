using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class gradoC
    {
        conexion x;
        public gradoC()
        {
            x = new conexion();
        }
        public void insert(gradoM dato)
        {
            x.manipular("insert into grados values('" + dato.Id + "','" + dato.IdEstudiante + "')");
        }
        public void update(gradoM dato)
        {
            x.manipular("update grados set id_estudiante='" + dato.IdEstudiante + "' where id='" + dato.Id + "'");
        }
        public void delete(gradoM dato)
        {
            x.manipular("delete from grados where id ='" + dato.Id + "'");
        }



        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id_estudiante,nombres from grados");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "id_estudiante";
            cbBuscarColumna.ValueMember = "nombres";

        }


        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from grados");

        }
    }
}

