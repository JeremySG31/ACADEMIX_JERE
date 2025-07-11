using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academix.modelo
{
    internal class asistenciaMatriculadosM
    {
        public asistenciaMatriculadosM(string id, string id_matricula, DateTime fecha_matricula, string estado )
        {
            Id = id;
            this.IdMatricula = id_matricula;
            this.FechaMatricula = fecha_matricula;
            this.Estado = estado;
        }

        public string Id { get; set; }
        public string IdMatricula { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string Estado { get; set; }



        }
}
