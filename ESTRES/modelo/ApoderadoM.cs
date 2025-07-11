namespace Academix.modelo
{
    internal class apoderadoM
    {
        public apoderadoM(string id, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            Id = id;
            Nombres = nombres;
            NombreUsuario = nombreUsuario;
            ApePaterno = apePaterno;
            ApeMaterno = apeMaterno;
            Estado = estado;
        }

        public string Id { get; set; }
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Estado { get; set; }
    }
}