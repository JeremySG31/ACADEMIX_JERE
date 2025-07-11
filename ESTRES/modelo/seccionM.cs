namespace Academix.modelo
{
    internal class seccionM
    {
        public seccionM(string id, string nombre, string id_estudiante)
        {
            Id = id;
            this.Nombre = nombre;
            this.IdEstudiante = id_estudiante;
        }

        public string Id { get; set; }
        public string IdEstudiante { get; set; }
        public string Nombre { get; set; }



    }
}