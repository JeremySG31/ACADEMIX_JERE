using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class apoderadoN
    {
        apoderadoC x;
        public apoderadoN()
        {
            x = new apoderadoC();
        }
        public void insertar(string Id, string IdUsuario)
        {
            x.insert(new apoderadoM(Id, IdUsuario));
        }
        public void modificar(string Id, string IdUsuario)
        {
            x.update(new apoderadoM(Id, IdUsuario));
        }
        public void eliminar(string Id, string IdUsuario)
        {
            x.delete(new apoderadoM(Id, IdUsuario));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}