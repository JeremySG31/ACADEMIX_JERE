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

        public void insertar(string id, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            x.insert(new apoderadoM(id, nombres, nombreUsuario, apePaterno, apeMaterno, estado));
        }

        public void modificar(string id, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            x.update(new apoderadoM(id, nombres, nombreUsuario, apePaterno, apeMaterno, estado));
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