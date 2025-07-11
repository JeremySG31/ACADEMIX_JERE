using ESTRES.dao;
using ESTRES.modelo;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class matriculaC
    {
        conexion x;
        public matriculaC()
        {
            x = new conexion();
        }
        public void insert(matriculaM dato)
        {
            x.manipular("insert into matriculas values('" + dato.Id + "','" + dato.IdEstudiante + "')");
        }
        public void update(matriculaM dato)
        {
            x.manipular("update matriculas set id_estudiante='" + dato.IdEstudiante + "' where id='" + dato.Id + "'");
        }
        public void delete(matriculaM dato)
        {
            x.manipular("delete from matriculas where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            cbBuscarColumna.DataSource = x.manipular("select id,id_estudiante,fecha_matricula from matriculas");
            cbBuscarColumna.DisplayMember = "id";
            cbBuscarColumna.ValueMember = "id_estudiante";
            cbBuscarColumna.SelectedIndex = 0;
        }


        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from matriculas");

        }
    }
}

