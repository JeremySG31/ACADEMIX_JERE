using Academix.modelo;
using ESTRES.dao;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class apoderadoC
    {
        conexion x;
        public apoderadoC()
        {
            x = new conexion();
        }
        public void insert(apoderadoM dato)
        {
            x.manipular("insert into apoderados values('" + dato.Id + "','" + dato.IdUsuario + "')");
        }
        public void update(apoderadoM dato)
        {
            x.manipular("update apoderados set id_usuario='" + dato.IdUsuario + "' where id='" + dato.Id + "'");
        }
        public void delete(apoderadoM dato)
        {
            x.manipular("delete from apoderados where id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT a.id, u.nombres FROM apoderados a JOIN usuarios u ON a.id_usuario = u.id;");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombres";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = 0;
        }




        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT  a.id,  u.nombres,   u.ape_paterno,   u.ape_materno, " +
                "u.estado, u.nombre_usuario  FROM apoderados a JOIN usuarios u ON a.id_usuario = u.id;");

        }
    }
}