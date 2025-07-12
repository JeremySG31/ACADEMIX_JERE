using ESTRES.dao;
using ESTRES.modelo;
using System.Data;
using System.Windows.Forms;

namespace ESTRES.controlador
{
    internal class cursoC
    {
        conexion x;

        public cursoC()
        {
            x = new conexion();
        }

        public void insert(cursoM dato)
        {
            x.manipular("INSERT INTO cursos (id, nombre, descripcion) VALUES('" + dato.Id + "','" + dato.Nombre + "','" + dato.Descripcion + "')");
        }

        public void update(cursoM dato)
        {
            x.manipular("UPDATE cursos SET nombre='" + dato.Nombre + "', descripcion='" + dato.Descripcion + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(cursoM dato)
        {
            x.manipular("DELETE FROM cursos WHERE id ='" + dato.Id + "'");
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT id, nombre FROM cursos");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombre";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT id, nombre, descripcion FROM cursos");
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM cursos");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, nombre, descripcion FROM cursos");
            combo.DataSource = dt;
            combo.DisplayMember = "id"; 
            combo.ValueMember = "id";   
            combo.SelectedIndex = -1;
        }
    }
}