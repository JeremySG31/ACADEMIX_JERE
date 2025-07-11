using ESTRES.dao;
using ESTRES.modelo;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class turnoC
    {
        conexion x;
        public turnoC()
        {
            x = new conexion();
        }
        public void insert(turnoM dato)
        {
            x.manipular("insert into turnos values('" + dato.Id + "','" + dato.Nombre + "')");
        }
        public void update(turnoM dato)
        {
            x.manipular("update turnos set nombre='" + dato.Nombre + "' where id='" + dato.Id + "'");
        }
        public void delete(turnoM dato)
        {
            x.manipular("delete from turnos where id ='" + dato.Id + "'");
        }


        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id,nombre FROM turnos");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "id";
            cbBuscarColumna.ValueMember = "nombre";
            cbBuscarColumna.SelectedIndex = 0;
        }
        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("select * from turnos");

        }
    }
}

