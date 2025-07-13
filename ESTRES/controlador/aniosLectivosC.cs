using Academix.modelo;
using ESTRES.dao; 
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
            x.manipular("INSERT INTO aniosLectivos (id, nombre, descripcion, estado) VALUES('" + dato.Id + "','" + dato.Nombre + "','" + dato.Descripcion + "','" + dato.Estado + "')");
        }

        public void update(aniosLectivosM dato)
        {
            x.manipular("UPDATE aniosLectivos SET nombre='" + dato.Nombre + "', descripcion='" + dato.Descripcion + "', estado='" + dato.Estado + "' WHERE id='" + dato.Id + "'");
        }

        public void delete(string idAnioLectivo) 
        {
            x.manipular("DELETE FROM aniosLectivos WHERE id ='" + idAnioLectivo + "'");
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            DataTable dt = x.manipular("SELECT id, nombre FROM aniosLectivos");
            cb.DataSource = dt;
            cb.DisplayMember = "id"; 
            cb.ValueMember = "nombre"; 
            cb.SelectedIndex = -1; 
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular("SELECT id, nombre, descripcion, estado FROM aniosLectivos");
            L.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id, nombre, descripcion, estado FROM aniosLectivos");
            combo.DataSource = dt;
            combo.DisplayMember = "id"; 
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM aniosLectivos");
            combo.DataSource = dt;
            combo.DisplayMember = "id"; 
            combo.ValueMember = "id"; 
            combo.SelectedIndex = -1;
        }

        public void selectEstados(ComboBox cb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Estado");
            dt.Rows.Add("Activo");
            dt.Rows.Add("Inactivo");

            cb.DataSource = dt;
            cb.DisplayMember = "Estado";
            cb.ValueMember = "Estado";
            cb.SelectedIndex = -1;
        }
    }
}