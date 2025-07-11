using Academix.controlador;
using Academix.modelo;
using System;
using System.Windows.Forms;

namespace Academix.negocio
{
    internal class asistenciaMatriculadosN
    {
        asistenciaMatriculadosC x;
        public asistenciaMatriculadosN()
        {
            x = new asistenciaMatriculadosC();
        }
        public void insertar(string Id, string IdMatricula, DateTime fecha_matricula, string estado)
        {
            x.insert(new asistenciaMatriculadosM(Id, IdMatricula, fecha_matricula, estado));
        }
        public void modificar(string Id, string IdMatricula, DateTime fecha_matricula, string estado)
        {
            x.update(new asistenciaMatriculadosM(Id, IdMatricula, fecha_matricula, estado));
        }
        public void eliminar(string Id, string IdMatricula, DateTime fecha_matricula, string estado)
        {
            x.delete(new asistenciaMatriculadosM(Id, IdMatricula, fecha_matricula, estado));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}