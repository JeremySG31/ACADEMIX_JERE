using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class seccionN
    {
        seccionC x;
        public seccionN()
        {
            x = new seccionC();
        }

        public void insertar(string id, string nombre, string id_estudiante)
        {
            x.insert(new seccionM(id, nombre, id_estudiante));
        }

        public void modificar(string id, string nombre, string id_estudiante)
        {
            x.update(new seccionM(id, nombre, id_estudiante));
        }

        // --- CORRECCIÓN: Modificado para eliminar solo por ID ---
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