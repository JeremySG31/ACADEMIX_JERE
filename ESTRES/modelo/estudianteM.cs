namespace Academix.modelo
{
    internal class estudianteM
    {
        public estudianteM(string idEstudiante, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            IdEstudiante = idEstudiante;
            Nombres = nombres;
            NombreUsuario = nombreUsuario;
            ApePaterno = apePaterno;
            ApeMaterno = apeMaterno;
            Estado = estado;
        }

        public string IdEstudiante { get; set; } 
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Estado { get; set; }
    }
}