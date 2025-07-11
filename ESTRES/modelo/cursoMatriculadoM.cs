using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academix.modelo
{
    internal class cursoMatriculadoM
    {
        public cursoMatriculadoM(string id, string id_estudiante, string id_curso, string id_matricula)
        {
            Id = id;
            Id_estudiante = id_estudiante;
            Id_curso = id_curso;
            Id_matricula = id_matricula;
        }
        public string Id { get; set; }
        public string Id_curso { get; set; }
        public string Id_estudiante { get; }
        public string Id_matricula { get; }
    }
}
