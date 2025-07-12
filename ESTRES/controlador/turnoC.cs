using ESTRES.modelo;
using ESTRES.dao;
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
            x.manipular("INSERT INTO turnos (id, nombre, id_estudiante) VALUES('" + dato.Id + "','" + dato.Nombre + "','" + dato.Id_estudiante + "')");
        }

        public void update(turnoM dato)
        {
            x.manipular("UPDATE turnos SET nombre='" + dato.Nombre + "', id_estudiante='" + dato.Id_estudiante + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(string idTurno)
        {
            x.manipular("DELETE FROM turnos WHERE id ='" + idTurno + "'");
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombre FROM turnos");
            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "nombre"; // Ahora el ValueMember es 'nombre'
            cb.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            string consulta = "SELECT t.id, t.nombre, t.id_estudiante " + // Eliminado 'e.id AS id_estudiante_nombre'
                              "FROM turnos t " +
                              "LEFT JOIN estudiantes e ON t.id_estudiante = e.id";

            DataTable dt = x.manipular(consulta);
            L.DataSource = dt;
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM turnos");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, nombre, id_estudiante FROM turnos");
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

        public void selectNombresTurno(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT DISTINCT nombre FROM turnos");
            cb.DataSource = dt;
            cb.DisplayMember = "nombre";
            cb.ValueMember = "nombre";
            cb.SelectedIndex = -1;
        }
    }
}