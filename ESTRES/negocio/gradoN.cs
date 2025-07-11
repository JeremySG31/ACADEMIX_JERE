using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class gradoN
    {
        gradoC x;
        public gradoN()
        {
            x = new gradoC();
        }
        public void insertar(string id, string nombres, string id_estudiante)
        {
            x.insert(new gradoM(id, nombres, id_estudiante));
        }
        public void modificar(string id, string nombres, string id_estudiante)
        {
            x.update(new gradoM(id, nombres, id_estudiante));
        }
        public void eliminar(string id, string id_estudiante)
        {
            x.delete(new gradoM(id, "", id_estudiante));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}
