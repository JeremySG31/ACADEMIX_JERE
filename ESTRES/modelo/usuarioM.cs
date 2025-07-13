namespace ESTRES.modelo
{
    internal class usuarioM
    {
        public usuarioM(string id, string nombreUsuario, string nombres, string apePaterno, string apeMaterno, string dni, string correo, string contrasena, string rol, string estado, string telefono)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Nombres = nombres;
            ApePaterno = apePaterno;
            ApeMaterno = apeMaterno;
            Dni = dni;
            Correo = correo;
            Contrasena = contrasena;
            Rol = rol;
            Estado = estado;
            Telefono = telefono;
        }

        public usuarioM(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public string Telefono { get; set; }
    }
}