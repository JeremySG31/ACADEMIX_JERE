using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class estudianteApoderadoN
    {
        estudianteApoderadoC x;
        public estudianteApoderadoN()
        {
            x = new estudianteApoderadoC();
        }
        public void insertar(string id, string id_apoderado, string id_estudiante, string parentesco, int prioridad, string estado)
        {
            x.insert(new estudianteApoderadoM(id, id_apoderado, id_estudiante, parentesco, prioridad, estado));
        }
        public void modificar(string id, string id_apoderado, string id_estudiante, string parentesco, int prioridad, string estado)
        {
            x.update(new estudianteApoderadoM(id, id_apoderado, id_estudiante, parentesco, prioridad, estado));
        }
        public void eliminar(string id, string id_apoderado, string id_estudiante, string parentesco, int prioridad, string estado)
        {
            x.delete(new estudianteApoderadoM(id, id_apoderado, id_estudiante, parentesco, prioridad, estado));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}