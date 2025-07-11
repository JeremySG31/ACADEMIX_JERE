using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class profesorN
    {
        profesorC x;
        public profesorN()
        {
            x = new profesorC();
        }
        public void insertar(string Id, string IdUsuario)
        {
            x.insert(new profesorM(Id, IdUsuario));
        }
        public void modificar(string Id, string IdUsuario)
        {
            x.update(new profesorM(Id, IdUsuario));
        }
        public void eliminar(string Id, string IdUsuario)
        {
            x.delete(new profesorM(Id, IdUsuario));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}
