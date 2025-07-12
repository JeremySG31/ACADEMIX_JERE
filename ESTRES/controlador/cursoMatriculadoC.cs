using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class cursoMatriculadoC
    {
        conexion x;

        public cursoMatriculadoC()
        {
            x = new conexion();
        }

        public void insert(cursoMatriculadoM dato)
        {
            x.manipular("INSERT INTO cursos_matriculados (id, id_matricula, id_cursos, id_estudiante) VALUES('" + dato.Id + "','" + dato.Id_matricula + "','" + dato.Id_cursos + "','" + dato.Id_estudiante + "')");
        }

        public void update(cursoMatriculadoM dato)
        {
            x.manipular("UPDATE cursos_matriculados SET id_matricula='" + dato.Id_matricula + "', id_cursos='" + dato.Id_cursos + "', id_estudiante='" + dato.Id_estudiante + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(cursoMatriculadoM dato)
        {
            x.manipular("DELETE FROM cursos_matriculados WHERE id ='" + dato.Id + "'");
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id,id_estudiante FROM cursos_matriculados");
            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "id_estudiante";
            cb.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            string consulta = "SELECT cm.id, cm.id_matricula, " +
                              "cm.id_cursos, c.nombre AS nombre_curso, " +
                              "cm.id_estudiante " +
                              "FROM cursos_matriculados cm " +
                              "LEFT JOIN matriculas m ON cm.id_matricula = m.id " +
                              "LEFT JOIN cursos c ON cm.id_cursos = c.id " +
                              "LEFT JOIN estudiantes e ON cm.id_estudiante = e.id";

            DataTable dt = x.manipular(consulta);

            L.DataSource = dt;
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM cursos_matriculados");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, id_matricula, id_cursos, id_estudiante FROM cursos_matriculados");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectEstudiantes(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id FROM estudiantes");
            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void selectCursos(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombre FROM cursos");
            cb.DataSource = dt;
            cb.DisplayMember = "nombre";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void selectMatriculas(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id FROM matriculas");
            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }
    }
}