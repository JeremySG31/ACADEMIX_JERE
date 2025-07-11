namespace Academix.modelo
{
    internal class gradoM
    {
        private string id_estudiante;

        public gradoM(string id, string nombres, string id_estudiante)
        {
            Id = id;
            this.nombres = nombres;
            this.id_estudiante = id_estudiante;
        }

        public string Id { get; set; }
        public string IdEstudiante { get; set; }
        public string nombres { get; set; }
        public string nivel { get; set; }

    }
}