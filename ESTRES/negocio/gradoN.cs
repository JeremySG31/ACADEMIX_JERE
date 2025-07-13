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

        public void insertar(string id, string nombresGrado, string idEstudiante, string nivelGrado)
        {
            x.insert(new gradoM(id, nombresGrado, idEstudiante, nivelGrado));
        }

        public void modificar(string id, string nombresGrado, string idEstudiante, string nivelGrado)
        {
            x.update(new gradoM(id, nombresGrado, idEstudiante, nivelGrado));
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