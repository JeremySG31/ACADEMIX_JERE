using Academix.modelo;
using ESTRES.dao;
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

        public void delete(seccionM dato)
        {
            x.manipular("DELETE FROM secciones WHERE id ='" + dato.Id + "'");
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
    }
}