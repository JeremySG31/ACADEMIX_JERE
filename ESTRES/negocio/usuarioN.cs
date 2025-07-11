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
        public void insertar(string id, string nombres)
        {
            x.insert(new usuarioM(id, nombres));
        }
        public void modificar(string id, string nombres)
        {
            x.update(new usuarioM(id, nombres));
        }
        public void eliminar(string id)
        {
            x.delete(new usuarioM(id, ""));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}
