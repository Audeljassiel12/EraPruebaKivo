namespace CentroMedico.Models.Dominio
{
    public class Departamento
    {
        public int Id { get; set; } // Primary Key
        public string Nombre { get; set; } = null!; 

        // Relación uno a muchos con Municipio
        public List<Cuidad>? Cuidadades { get; set; }
    }

}
