using Academix.modelo;
using ESTRES.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            x.manipular("insert into cursos_matriculados values('" + dato.Id + "','" + "')");
        }
        public void update(cursoMatriculadoM dato)
        {
            x.manipular("update cursos_matriculados set id_estudiante='" + "' where id='" + dato.Id + "'");
        }
        public void delete(cursoMatriculadoM dato)
        {
            x.manipular("delete from cursos_matriculados where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id, id_estudiante FROM cursos_matriculados");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "id";
            cbBuscarColumna.ValueMember = "id_estudiante";
            cbBuscarColumna.SelectedIndex = 0;

        }



        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from cursos_matriculados");

        }
    }
}