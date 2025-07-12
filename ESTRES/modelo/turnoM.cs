namespace ESTRES.modelo
{
    internal class turnoM
    {
        private string id, nombre, id_estudiante;


        public turnoM(string id, string nombre, string id_estudiante)
        {
            this.id = id;
            this.id_estudiante = id_estudiante;
            this.nombre = nombre;

        }

        public string Id { get ; set ; }
        public string Id_estudiante { get ; set ; }
        public string Nombre { get; set; }
    }
}
