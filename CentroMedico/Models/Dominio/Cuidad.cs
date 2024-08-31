namespace CentroMedico.Models.Dominio
{
    public class Cuidad
    {
        public int MunicipioID { get; set; } // Primary Key
        [Requered(ErrorMensage = "El {0} de la ciudad es requeridos para el siguiente paso")]
        [StringLength(maximumLength: 10, MinimumLength = 5, ErrorMessage = " El {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Nombre { get; set; }

        // Relación muchos a uno con Departamento
        public int DepartamentoID { get; set; } // Foreign Key
        public Departamento Departamento { get; set; }

        // Relación uno a muchos con Paciente
        public List<Paciente> Pacientes { get; set; }
    }
}
