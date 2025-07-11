using ESTRES.controlador;
using ESTRES.modelo;
using System.Windows.Forms;

namespace ESTRES.negocio
{
    internal class matriculaN
    {
        matriculaC x;
        public matriculaN()
        {
            x = new matriculaC();
        }
        public void insertar(string id, string nombre, string id_estudiante)
        {
            x.insert(new matriculaM(id, nombre, id_estudiante));
        }
        public void modificar(string id, string nombre, string id_estudiante)
        {
            x.update(new matriculaM(id, nombre, id_estudiante));
        }
        public void eliminar(string id, string id_estudiante)
        {
            x.delete(new matriculaM(id, "", id_estudiante));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}