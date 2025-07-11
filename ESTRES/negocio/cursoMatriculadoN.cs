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
    internal class cursoMatriculadoN
    {
        cursoMatriculadoC x;
        public cursoMatriculadoN()
        {
            x = new cursoMatriculadoC();
        }
        public void insertar(string id, string id_estudiante, string id_curso, string id_matricula)
        {
            x.insert(new cursoMatriculadoM(id, id_estudiante, id_curso, id_matricula));
        }
        public void modificar(string id, string id_estudiante, string id_curso, string id_matricula)
        {
            x.update(new cursoMatriculadoM(id, id_estudiante, id_curso, id_matricula));
        }
        public void eliminar(string id, string id_estudiante, string id_curso, string id_matricula)
        {
            x.delete(new cursoMatriculadoM(id, "", "", ""));
        }
        public void seleccionar(DataGridView L)
        {
            x.select(L);
        }
    }
}