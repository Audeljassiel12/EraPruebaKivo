namespace CentroMedico.Models.Dominio
{
    public class Departamento
    {
        public int DepartamentoID { get; set; } // Primary Key
        public string Nombre { get; set; }

        // Relación uno a muchos con Municipio
        public List<Cuidad> Cuidad { get; set; }
    }

}
