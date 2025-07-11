using Academix.modelo;
using ESTRES.dao; 
using System.Data;
using System.Windows.Forms;

namespace Academix.controlador
{
    internal class apoderadoC
    {
        conexion x;

        public apoderadoC()
        {
            x = new conexion();
        }

        public void insert(apoderadoM dato)
        {
            x.manipular(
                "INSERT INTO usuarios (id, nombres, nombre_usuario, ape_paterno, ape_materno, estado) VALUES ('" +
                dato.Id + "', '" + dato.Nombres + "', '" + dato.NombreUsuario + "', '" + dato.ApePaterno + "', '" + dato.ApeMaterno + "', '" + dato.Estado + "')"
            );

            x.manipular(
                "INSERT INTO apoderados (id, id_usuario) VALUES ('" + dato.Id + "', '" + dato.Id + "')"
            );
        }

        public void update(apoderadoM dato)
        {
            x.manipular(
                "UPDATE usuarios SET nombres = '" + dato.Nombres + "', " +
                "nombre_usuario = '" + dato.NombreUsuario + "', " +
                "ape_paterno = '" + dato.ApePaterno + "', " +
                "ape_materno = '" + dato.ApeMaterno + "', " +
                "estado = '" + dato.Estado + "' " +
                "WHERE id = '" + dato.Id + "'"
            );

        }

        public void delete(string idApoderado) 
        {
            x.manipular("DELETE FROM estudiante_apoderados WHERE id_apoderado = '" + idApoderado + "'"); 
            x.manipular("DELETE FROM apoderados WHERE id = '" + idApoderado + "'");
            x.manipular("DELETE FROM usuarios WHERE id = '" + idApoderado + "'");
        }

        public void select(DataGridView L)
        {
            L.DataSource = x.manipular(
                "SELECT a.id, u.nombres, u.ape_paterno, u.ape_materno, u.nombre_usuario, u.estado " +
                "FROM apoderados a JOIN usuarios u ON a.id_usuario = u.id"
            );
        }

        public void select(ComboBox cbBuscarColumna)
        {
            DataTable dt = x.manipular("SELECT a.id, u.nombres FROM apoderados a JOIN usuarios u ON a.id_usuario = u.id;");
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
            DataTable dt = x.manipular("SELECT id FROM apoderados");
            combo.DataSource = dt;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
        }

        public void selectIDModificar(ComboBox combo)
        {
            DataTable dt = x.manipular(
                "SELECT a.id, u.nombres, u.nombre_usuario, u.ape_paterno, u.ape_materno, u.estado " +
                "FROM apoderados a JOIN usuarios u ON a.id_usuario = u.id"
            );
            combo.DataSource = dt;
            combo.DisplayMember = "id"; 
            combo.ValueMember = "id"; 
            combo.SelectedIndex = -1;
        }
    }
}