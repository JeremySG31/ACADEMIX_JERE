namespace ESTRES.modelo
{
    internal class cursoM
    {
        public cursoM(string id, string nombre, string descripcion)
        {
            Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}