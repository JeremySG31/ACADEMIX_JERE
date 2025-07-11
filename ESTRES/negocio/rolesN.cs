using Academix.controlador;
using Academix.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            x.update(new rolesM(id, nombreRol ));
        }
        public void eliminar(string id, string nombreRol)
        {
            x.delete(new rolesM(id, nombreRol));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}
