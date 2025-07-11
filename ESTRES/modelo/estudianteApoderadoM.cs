namespace Academix.modelo
{
    internal class estudianteApoderadoM
    {
        public estudianteApoderadoM(string id, string id_apoderado, string id_estudiante, string parentesco, int prioridad, string estado)
        {
            Id = id;
            this.IdEstudiante = id_estudiante;
            this.IdApoderado = id_apoderado;
            this.Parentesco = parentesco;
            this.Prioridad = prioridad;
            this.Estado = estado;
        }

        public string Id { get; set; }
        public string IdEstudiante { get; set; }
        public string IdApoderado { get; set; }
        public string Parentesco { get; set; }
        public int Prioridad { get; set; }
        public string Estado { get; set; }



    }
}