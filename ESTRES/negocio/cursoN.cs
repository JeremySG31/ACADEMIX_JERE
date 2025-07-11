using ESTRES.controlador;
using ESTRES.modelo;
using System.Windows.Forms;

namespace ESTRES.negocio
{
    internal class cursoN
    {
        cursoC x;
        public cursoN()
        {
            x = new cursoC();
        }
        public void insertar(string id, string nombre, string descripcion)
        {
            x.insert(new cursoM(id, nombre, descripcion));
        }
        public void modificar(string id, string nombre, string descripcion)
        {
            x.update(new cursoM(id, nombre, descripcion));
        }
        public void eliminar(string id, string descripcion)
        {
            x.delete(new cursoM(id, "", descripcion));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}