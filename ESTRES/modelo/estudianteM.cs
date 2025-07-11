namespace ESTRES.modelo
{
    internal class estudianteM
    {
        public estudianteM(string id, string id_usuario)
        {
            Id = id;
            IdUsuario = id_usuario;
        }


        public string Id { get; set; }
        public string IdUsuario { get; set; }
    }
}