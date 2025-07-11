namespace Academix.modelo
{
    internal class profesorM
    {
        public profesorM(string idProfesor, string nombres, string nombreUsuario, string apePaterno, string apeMaterno, string estado)
        {
            IdProfesor = idProfesor;
            Nombres = nombres;
            NombreUsuario = nombreUsuario;
            ApePaterno = apePaterno;
            ApeMaterno = apeMaterno;
            Estado = estado;
        }

        public string IdProfesor { get; set; } 
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Estado { get; set; }
    }
}