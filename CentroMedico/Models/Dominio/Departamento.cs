namespace CentroMedico.Models.Dominio
{
    public class Departamento
    {
        public int Id { get; set; } // Primary Key
        [Requered(ErrorMensage = "El {0} del Departamento son requeridos para el siguiente paso")]
        [StringLength(maximumLength: 15, MinimumLength = 13, ErrorMessage = " El {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Nombre { get; set; } = null!; 

        // Relación uno a muchos con Municipio
        public List<Cuidad>? Cuidadades { get; set; }
    }

}
