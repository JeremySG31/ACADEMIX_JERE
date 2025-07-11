using ESTRES.controlador;
using ESTRES.modelo;
using System.Windows.Forms;

namespace ESTRES.negocio
{
    internal class turnoN
    {
        turnoC x;
        public turnoN()
        {
            x = new turnoC();
        }
        public void insertar(string id, string nombre, string id_estudiante)
        {
            x.insert(new turnoM(id, nombre, id_estudiante));
        }
        public void modificar(string id, string nombre, string id_estudiante)
        {
            x.update(new turnoM(id, nombre, id_estudiante));
        }
        public void eliminar(string id, string id_estudiante)
        {
            x.delete(new turnoM(id, "", id_estudiante));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}