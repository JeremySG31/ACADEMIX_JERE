using System;

namespace ESTRES.modelo
{
    internal class matriculaM
    {
        public matriculaM(string id, string idEstudiante, string idGrado, DateTime fechaMatricula, string idApoderado, string idSeccion, string idTurno, string idAniolectivo, string estado)
        {
            Id = id;
            IdEstudiante = idEstudiante;
            IdGrado = idGrado;
            FechaMatricula = fechaMatricula;
            IdApoderado = idApoderado;
            IdSeccion = idSeccion;
            IdTurno = idTurno;
            IdAniolectivo = idAniolectivo;
            Estado = estado;
        }

        public string Id { get; set; }
        public string IdEstudiante { get; set; }
        public string IdGrado { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string IdApoderado { get; set; }
        public string IdSeccion { get; set; }
        public string IdTurno { get; set; }
        public string IdAniolectivo { get; set; }
        public string Estado { get; set; }
    }
}