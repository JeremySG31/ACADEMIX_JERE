using ESTRES.controlador;
using ESTRES.modelo;
using System.Windows.Forms;

namespace ESTRES.negocio
{
    internal class usuarioN
    {
        usuarioC x;

        public usuarioN()
        {
            x = new usuarioC();
        }

        public void insertar(string id, string nombreUsuario, string nombres, string apePaterno, string apeMaterno, string dni, string correo, string contrasena, string rol, string estado, string telefono)
        {
            x.insert(new usuarioM(id, nombreUsuario, nombres, apePaterno, apeMaterno, dni, correo, contrasena, rol, estado, telefono));
        }

        public void modificar(string id, string nombreUsuario, string nombres, string apePaterno, string apeMaterno, string dni, string correo, string contrasena, string rol, string estado, string telefono)
        {
            x.update(new usuarioM(id, nombreUsuario, nombres, apePaterno, apeMaterno, dni, correo, contrasena, rol, estado, telefono));
        }

        public void eliminar(string id)
        {
            x.delete(id);
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}