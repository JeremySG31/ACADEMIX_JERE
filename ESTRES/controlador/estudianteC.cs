using Academix.modelo;
using ESTRES.dao; 
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class estudianteC
    {
        conexion x;

        public estudianteC()
        {
            x = new conexion();
        }

        public void insert(estudianteM dato)
        {
            x.manipular(
                "INSERT INTO usuarios (id, nombres, nombre_usuario, ape_paterno, ape_materno, estado) VALUES ('" +
                dato.IdEstudiante + "', '" + dato.Nombres + "', '" + dato.NombreUsuario + "', '" + dato.ApePaterno + "', '" + dato.ApeMaterno + "', '" + dato.Estado + "')"
            );


            x.manipular(
                "INSERT INTO estudiantes (id, id_usuario) VALUES ('" + dato.IdEstudiante + "', '" + dato.IdEstudiante + "')"
            );
        }

        public void update(estudianteM dato)
        {
            x.manipular(
                "UPDATE usuarios SET nombres = '" + dato.Nombres + "', " +
                "nombre_usuario = '" + dato.NombreUsuario + "', " +
                "ape_paterno = '" + dato.ApePaterno + "', " +
                "ape_materno = '" + dato.ApeMaterno + "', " +
                "estado = '" + dato.Estado + "' " +
                "WHERE id = '" + dato.IdEstudiante + "'" 
            );


        }

        public void delete(string idEstudiante) 
        {
            x.manipular("DELETE FROM estudiantes WHERE id = '" + idEstudiante + "'");
            x.manipular("DELETE FROM usuarios WHERE id = '" + idEstudiante + "'");
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular(
                "SELECT e.id, u.nombres, u.ape_paterno, u.ape_materno, u.nombre_usuario, u.estado " +
                "FROM estudiantes e JOIN usuarios u ON e.id_usuario = u.id"
            );
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT e.id, u.nombres FROM estudiantes e JOIN usuarios u ON e.id_usuario = u.id;");
            cbBuscarColumna.DataSource = dt;
            cbBuscarColumna.DisplayMember = "nombres";
            cbBuscarColumna.ValueMember = "id";
            cbBuscarColumna.SelectedIndex = -1;
        }

        public void selectEstado(ComboBox combo)
        {
            var estados = new[]
            {
                new { Valor = "Activo", Texto = "Activo" },
                new { Valor = "Inactivo", Texto = "Inactivo" }
            };
            combo.DataSource = estados;
            combo.DisplayMember = "Texto";
            combo.ValueMember = "Valor";
            combo.SelectedIndex = -1;
        }

        public void selectIDEliminar(ComboBox combo)
        {
            DataTable dt = x.manipular("SELECT id FROM estudiantes");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular(
                "SELECT e.id, u.nombres, u.nombre_usuario, u.ape_paterno, u.ape_materno, u.estado " +
                "FROM estudiantes e JOIN usuarios u ON e.id_usuario = u.id"
            );
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }
    }
}