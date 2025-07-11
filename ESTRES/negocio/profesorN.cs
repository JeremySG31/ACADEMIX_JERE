using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class profesorN
    {
        profesorC x;

        public profesorN()
        {
            x = new profesorC();
        }

        public void insertar(string idProfesor, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            x.insert(new profesorM(idProfesor, nombres, nombreUsuario, apePaterno, apeMaterno, estado));
        }

        public void modificar(string idProfesor, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            x.update(new profesorM(idProfesor, nombres, nombreUsuario, apePaterno, apeMaterno, estado));
        }

        public void eliminar(string idProfesor)
        {
            x.delete(idProfesor);
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}