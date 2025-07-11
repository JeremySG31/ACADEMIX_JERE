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
    internal class aniosLectivosC
    {
        conexion x;
        public aniosLectivosC()
        {
            x = new conexion();
        }
        public void insert(aniosLectivosM dato)
        {
            x.manipular("insert into aniosLectivos values('" + dato.Id + "','"+ "')");
        }
        public void update(aniosLectivosM dato)
        {
            x.manipular("update aniosLectivos set id_estudiante='"  + "' where id='" + dato.Id + "'");
        }
        public void delete(aniosLectivosM dato)
        {
            x.manipular("delete from aniosLectivos where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
        DataTable dt = x.manipular("SELECT id, nombre FROM aniosLectivos");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "id";
            cbBuscarColumna.ValueMember = "nombre";
            cbBuscarColumna.SelectedIndex = 0;

        }



        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from aniosLectivos");

        }
    }
}