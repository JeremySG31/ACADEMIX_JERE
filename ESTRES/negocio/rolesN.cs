using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class rolesN
    {
        rolesC x;

        public rolesN()
        {
            x = new rolesC();
        }

        public void insertar(string id, string nombreRol)
        {
            x.insert(new rolesM(id, nombreRol));
        }

        public void modificar(string id, string nombreRol)
        {
            x.update(new rolesM(id, nombreRol));
        }

        public void eliminar(string id)
        {
            x.delete(new rolesM(id, ""));
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }

        public void selectBuscarColumna(ComboBox cb)
        {
            x.select(cb);
        }

        public void selectIDModificar(ComboBox combo)
        {
            x.selectIDModificar(combo);
        }

        public void selectIDEliminar(ComboBox combo)
        {
            x.selectIDEliminar(combo);
        }
    }
}