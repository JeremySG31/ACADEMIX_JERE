using System;

namespace Academix.modelo
{
    internal class AsistenciaMatriculadosM
    {
        public string Id { get; set; }
        public string IdMatricula { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public AsistenciaMatriculadosM()
        {

        }

        public AsistenciaMatriculadosM(string id, string idMatricula, DateTime fecha, string estado)
        {
            Id = id;
            IdMatricula = idMatricula;
            Fecha = fecha;
            Estado = estado;
        }
    }
}