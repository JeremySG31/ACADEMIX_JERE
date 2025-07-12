using ESTRES.dao; // Asumo que ESTRES.dao contiene la clase 'conexion'
using Academix.modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class seccionC
    {
        conexion x;

        public seccionC()
        {
            x = new conexion();
        }

        public void insert(seccionM dato)
        {
            x.manipular("INSERT INTO secciones (id, nombre, id_estudiante) VALUES('" + dato.Id + "','" + dato.Nombre + "','" + dato.IdEstudiante + "')");
        }

        public void update(seccionM dato)
        {
            x.manipular("UPDATE secciones SET nombre='" + dato.Nombre + "', id_estudiante='" + dato.IdEstudiante + "' WHERE id='" + dato.Id + "'");
        }

        // --- CORRECCIÓN: Modificado para aceptar solo el ID para la eliminación ---
        public void delete(string idSeccion)
        {
            x.manipular("DELETE FROM secciones WHERE id ='" + idSeccion + "'");
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombre FROM secciones");
            cb.DataSource = dt;
            cb.DisplayMember = "nombre";
            cb.ValueMember = "id";
            cb.SelectedIndex = -1;
        }

        public void select(DataGridView L)
        {
            string consulta = "SELECT s.id, s.nombre AS nombre_seccion, s.id_estudiante " +
                              "FROM secciones s " +
                              "LEFT JOIN estudiantes e ON s.id_estudiante = e.id";

            DataTable dt = x.manipular(consulta);

            L.DataSource = dt;
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM secciones");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, nombre, id_estudiante FROM secciones");
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

        // --- NUEVO MÉTODO: Para cargar las secciones (A, B, C, etc.) ---
        public void selectSeccionesABC(ComboBox cb)
        {
            string[] secciones = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}; 
            DataTable dt = new DataTable();
            dt.Columns.Add("nombre_seccion", typeof(string));

            foreach (string seccion in secciones)
            {
                dt.Rows.Add(seccion);
            }

            cb.DataSource = dt;
            cb.DisplayMember = "nombre_seccion";
            cb.ValueMember = "nombre_seccion"; 
            cb.SelectedIndex = -1;
        }
    }
}