namespace Academix.modelo
{
    internal class cursoMatriculadoM
    {
        public cursoMatriculadoM(string id, string id_estudiante, string id_cursos, string id_matricula)
        {
            Id = id;
            Id_estudiante = id_estudiante;
            Id_cursos = id_cursos;
            Id_matricula = id_matricula;
        }
        public string Id { get; set; }
        public string Id_cursos { get; set; }
        public string Id_estudiante { get; set; }
        public string Id_matricula { get; set; }
    }
}