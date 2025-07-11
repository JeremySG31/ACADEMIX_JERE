using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class asistenciaMatriculadosC
    {
        conexion x;
        public asistenciaMatriculadosC()
        {
            x = new conexion();
        }
        public void insert(asistenciaMatriculadosM dato)
        {
            x.manipular("insert into asistencias_matriculados values('" + dato.Id + "','" + dato.IdMatricula + "')");
        }
        public void update(asistenciaMatriculadosM dato)
        {
            x.manipular("update asistencias_matriculados set id_matricula='" + dato.IdMatricula + "' where id='" + dato.Id + "'");
        }
        public void delete(asistenciaMatriculadosM dato)
        {
            x.manipular("delete from asistencias_matriculados where id ='" + dato.Id + "'");
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