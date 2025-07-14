namespace Academix.modelo
{
    internal class loginM
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public string Rol { get; set; }

        public loginM(string nombreUsuario, string contrasena, string estado, string rol)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Estado = estado;
            Rol = rol;
        }
    }
}
