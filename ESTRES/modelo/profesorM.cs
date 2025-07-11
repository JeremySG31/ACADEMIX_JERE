namespace Academix.modelo
{
    internal class profesorM
    {
        public profesorM(string id, string id_usuario)
        {
            Id = id;
            IdUsuario = id_usuario;
        }


        public string Id { get; set; }
        public string IdUsuario { get; set; }
    }
}
