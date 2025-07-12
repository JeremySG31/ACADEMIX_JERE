using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class aniosLectivosN
    {
        aniosLectivosC x;

        public aniosLectivosN()
        {
            x = new aniosLectivosC();
        }

        public void insertar(string id, string nombre, string descripcion, string estado) // Usando 'nombre'
        {
            x.insert(new aniosLectivosM(id, nombre, descripcion, estado));
        }

        public void modificar(string id, string nombre, string descripcion, string estado) // Usando 'nombre'
        {
            x.update(new aniosLectivosM(id, nombre, descripcion, estado));
        }

        public void eliminar(string id)
        {
            x.delete(id); // Pasar solo el ID
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}