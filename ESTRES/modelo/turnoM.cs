namespace ESTRES.modelo
{
    internal class turnoM
    {
        public turnoM(string id, string nombre, string id_estudiante)
        {
            Id = id;
            Nombre = nombre;
            Id_estudiante = id_estudiante;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Id_estudiante { get; set; }
    }
}