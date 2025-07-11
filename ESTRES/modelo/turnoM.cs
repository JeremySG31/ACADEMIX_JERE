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

        public string Id { get => id; set => id = value; }
        public string Id_estudiante { get => id_estudiante; set => id_estudiante = value; }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
