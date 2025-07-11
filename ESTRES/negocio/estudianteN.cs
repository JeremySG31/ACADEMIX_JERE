using Academix.controlador;
using Academix.modelo;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class estudianteN
    {
        estudianteC x;

        public estudianteN()
        {
            x = new estudianteC();
        }

        public void insertar(string idEstudiante, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            x.insert(new estudianteM(idEstudiante, nombres, nombreUsuario, apePaterno, apeMaterno, estado));
        }

        public void modificar(string idEstudiante, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            x.update(new estudianteM(idEstudiante, nombres, nombreUsuario, apePaterno, apeMaterno, estado));
        }

        public void eliminar(string idEstudiante)
        {
            x.delete(idEstudiante);
        }

        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}