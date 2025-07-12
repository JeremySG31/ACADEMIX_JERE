using ESTRES.dao;
using Academix.modelo; // Asegúrate de que este namespace es correcto si el modelo está en Academix.modelo
using System.Data;
using System.Windows.Forms;
using System.Linq; // No es estrictamente necesario si no usas LINQ en esta clase

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
            x.manipular("INSERT INTO grados (id, nombres, id_estudiante, nivel) VALUES('" + dato.Id + "','" + dato.Nombres + "','" + dato.IdEstudiante + "','" + dato.Nivel + "')");
        }

        public void update(gradoM dato)
        {
            x.manipular("UPDATE grados SET nombres='" + dato.Nombres + "', id_estudiante='" + dato.IdEstudiante + "', nivel='" + dato.Nivel + "' WHERE id='" + dato.Id + "'");
        }

        // --- CORRECCIÓN: Modificado para aceptar solo el ID para la eliminación ---
        public void delete(string idGrado)
        {
            x.manipular("DELETE FROM grados WHERE id ='" + idGrado + "'");
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT g.id, g.nombres, g.nivel, e.id AS id_estudiante " +
                                  "FROM grados g " +
                                  "LEFT JOIN estudiantes e ON g.id_estudiante = e.id");
        }

        public void selectEstudiantes(ComboBox cb)
        {
            // Se asume que la tabla estudiantes tiene una columna 'id'
            DataTable dt = x.manipular("SELECT id FROM estudiantes");

            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void selectGrados(ComboBox cb)
        {
            string[] grados = { "Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto" };

            DataTable dt = new DataTable();
            dt.Columns.Add("nombre_grado", typeof(string));

            foreach (string grado in grados)
            {
                dt.Rows.Add(grado);
            }

            cb.DataSource = dt;
            cb.DisplayMember = "nombre_grado";
            cb.ValueMember = "nombre_grado"; // El valor también es el nombre para este ComboBox
            cb.SelectedIndex = -1;
        }

        public void selectNiveles(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT DISTINCT nivel as nombre_nivel FROM grados");
            cb.DataSource = dt;
            cb.DisplayMember = "nombre_nivel";
            cb.ValueMember = "nombre_nivel"; // El valor también es el nombre del nivel
            cb.SelectedIndex = -1;
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombres FROM grados");
            cb.DataSource = dt;
            cb.DisplayMember = "nombres";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombres, id_estudiante, nivel FROM grados");
            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id FROM grados");
            cb.DataSource = dt;
            cb.DisplayMember = "id";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }
    }
}