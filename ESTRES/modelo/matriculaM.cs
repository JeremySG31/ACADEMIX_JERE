namespace ESTRES.modelo
{
    internal class matriculaM
    {
        private string nombre;
        private string id_estudiante;

        public matriculaM(string id, string nombre, string id_estudiante)
        {
            Id = id;
            this.nombre = nombre;
            this.id_estudiante = id_estudiante;
        }

        public string Id { get; set; }
        public string IdEstudiante { get; set; }
        public string IdGrado { get; set; }
        public string FechaMatricula { get; set; }
        public string IdApoderado { get; set; }
        public string IdSeccion { get; set; }
        public string IdTurno { get; set; }
        public string IdAniolectivo { get; set; }
        public string Estado { get; set; }


    }
}
