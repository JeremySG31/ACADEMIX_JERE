using Academix.modelo;
using ESTRES.dao; // Asumo que esta es la conexión a la base de datos
using System.Data;
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
            // Ajustar la consulta INSERT para usar 'nombre'
            x.manipular("INSERT INTO aniosLectivos (id, nombre, descripcion, estado) VALUES('" + dato.Id + "','" + dato.Nombre + "','" + dato.Descripcion + "','" + dato.Estado + "')");
        }

        public void update(aniosLectivosM dato)
        {
            // Ajustar la consulta UPDATE para usar 'nombre'
            x.manipular("UPDATE aniosLectivos SET nombre='" + dato.Nombre + "', descripcion='" + dato.Descripcion + "', estado='" + dato.Estado + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(string idAnioLectivo) // Recibe solo el ID para eliminar
        {
            x.manipular("DELETE FROM aniosLectivos WHERE id ='" + idAnioLectivo + "'");
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            // Cargar ID y 'nombre' para la búsqueda
            DataTable dt = x.manipular("SELECT id, nombre FROM aniosLectivos");
            cb.DataSource = dt;
            cb.DisplayMember = "id"; // Muestra el ID en el ComboBox
            cb.ValueMember = "nombre"; // Cuando se selecciona el ID, obtendremos el 'nombre'
            cb.SelectedIndex = -1; // Deseleccionar por defecto
        }

        public void select(DataGridView L)
        {
            // Seleccionar todos los campos para mostrar en el DataGridView
            L.DataSource = x.manipular("SELECT id, nombre, descripcion, estado FROM aniosLectivos");
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Ajustar columnas
        }

        public void selectIDModificar(ComboBox combo)
        {
            // Cargar IDs, 'nombre', Descripcion y Estado para la modificación
            DataTable dt = x.manipular("SELECT id, nombre, descripcion, estado FROM aniosLectivos");
            combo.DataSource = dt;
            combo.DisplayMember = "id"; // Muestra el ID
            combo.ValueMember = "id"; // El valor será el ID
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            // Cargar IDs para la eliminación
            DataTable dt = x.manipular("SELECT id FROM aniosLectivos");
            combo.DataSource = dt;
            combo.DisplayMember = "id"; // Muestra el ID
            combo.ValueMember = "id"; // El valor será el ID
            combo.SelectedIndex = -1;
        }

        public void selectEstados(ComboBox cb)
        {
            // Cargar posibles estados para el ComboBox cbEstado (si hay una tabla de estados)
            // Si los estados son fijos (ej. "Activo", "Inactivo"), se pueden agregar directamente
            DataTable dt = new DataTable();
            dt.Columns.Add("Estado");
            dt.Rows.Add("Activo");
            dt.Rows.Add("Inactivo");
            // Agrega más estados si es necesario

            cb.DataSource = dt;
            cb.DisplayMember = "Estado";
            cb.ValueMember = "Estado";
            cb.SelectedIndex = -1;
        }
    }
}