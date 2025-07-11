namespace Academix.modelo
{
    internal class aniosLectivosM
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public aniosLectivosM(string id, string nombre, string descripcion, string estado)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }

    }

}