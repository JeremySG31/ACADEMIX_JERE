using Academix.modelo;
using ESTRES.dao; 
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class profesorC
    {
        conexion x;

        public profesorC()
        {
            x = new conexion();
        }

        public void insert(profesorM dato)
        {
  
            x.manipular(
                "INSERT INTO usuarios (id, nombres, nombre_usuario, ape_paterno, ape_materno, estado) VALUES ('" +
                dato.IdProfesor + "', '" + dato.Nombres + "', '" + dato.NombreUsuario + "', '" + dato.ApePaterno + "', '" + dato.ApeMaterno + "', '" + dato.Estado + "')"
            );


            x.manipular(
                "INSERT INTO profesores (id, id_usuario) VALUES ('" + dato.IdProfesor + "', '" + dato.IdProfesor + "')"
            );
        }

        public void update(profesorM dato)
        {

            x.manipular(
                "UPDATE usuarios SET nombres = '" + dato.Nombres + "', " +
                "nombre_usuario = '" + dato.NombreUsuario + "', " +
                "ape_paterno = '" + dato.ApePaterno + "', " +
                "ape_materno = '" + dato.ApeMaterno + "', " +
                "estado = '" + dato.Estado + "' " +
                "WHERE id = '" + dato.IdProfesor + "'" 
            );
               }

        public void delete(string idProfesor)
        {

            x.manipular("DELETE FROM profesores WHERE id = '" + idProfesor + "'");
            x.manipular("DELETE FROM usuarios WHERE id = '" + idProfesor + "'");
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular(
                "SELECT p.id, u.nombres, u.ape_paterno, u.ape_materno, u.nombre_usuario, u.estado " +
                "FROM profesores p JOIN usuarios u ON p.id_usuario = u.id"
            );
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT p.id, u.nombres FROM profesores p JOIN usuarios u ON p.id_usuario = u.id;");
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
            DataTable dt = x.manipular("SELECT id FROM profesores");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular(
                "SELECT p.id, u.nombres, u.nombre_usuario, u.ape_paterno, u.ape_materno, u.estado " +
                "FROM profesores p JOIN usuarios u ON p.id_usuario = u.id"
            );
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }
    }
}