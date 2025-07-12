namespace Academix.modelo
{
    internal class gradoM
    {
        public gradoM(string id, string nombres, string id_estudiante, string nivel = null)
        {
            Id = id;
            this.Nombres = nombres;
            this.IdEstudiante = id_estudiante;
            this.Nivel = nivel;
        }

        public string Id { get; set; }
        public string Nombres { get; set; }
        public string IdEstudiante { get; set; }
        public string Nivel { get; set; }
    }
}