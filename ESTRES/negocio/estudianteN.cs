using ESTRES.controlador;
using ESTRES.modelo;
using System.Windows.Forms;

namespace ESTRES.negocio
{
    internal class estudianteN
    {
        estudianteC x;
        public estudianteN()
        {
            x = new estudianteC();
        }
        public void insertar(string Id, string IdUsuario)
        {
            x.insert(new estudianteM(Id, IdUsuario));
        }
        public void modificar(string Id, string IdUsuario)
        {
            x.update(new estudianteM(Id, IdUsuario));
        }
        public void eliminar(string Id, string IdUsuario)
        {
            x.delete(new estudianteM(Id, IdUsuario));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}