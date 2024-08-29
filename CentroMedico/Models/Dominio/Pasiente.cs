using System.ComponentModel.DataAnnotations;

namespace CentroMedico.Models.Dominio
{
    public class Paciente
    {
        public int Id { get; set; }
        [StringLength(maximumLength:16,MinimumLength =13,ErrorMessage ="El {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Nombres { get; set; } = null!;
        [StringLength(maximumLength: 30, MinimumLength = 40, ErrorMessage = "El {0} no cumple con los requisitos de longitud. asegurese de que tenga entre  {1} y {2} caracteres. ")] 
        public string Apellidos { get; set; } = null!;
        [StringLength(maximumLength: 12, MinimumLength = 10, ErrorMessage = " Fecha invalida. Asegurese de usar el formato correcto dia, mes y año separados por /.")]
        public DateTime FechaNacimiento { get; set; }
        [StringLength(maximumLength: 1, MinimumLength = 1, ErrorMessage = "Valor no válido. Ingrese 'M' para Masculino, 'F' para Femenino. ")]
        public string Sexo { get; set; }  = null !;
        [StringLength(maximumLength: 200, MinimumLength = 100, ErrorMessage = "La {0} es demasiado corta. Por favor, ingrese una dirección más detallada.")]
        public string Dirección { get; set; }
        [StringLength(maximumLength: 10, MinimumLength = 8, ErrorMessage = " El número de teléfono es demasiado largo. Por favor, use un máximo de {1} caracteres. ")]
        public string? Teléfono { get; set; }
        [StringLength(maximumLength: 70, MinimumLength = 20, ErrorMessage = " Formato de correo electrónico inválido. Asegúrese de incluir '@' y un dominio válido. ")]
        public string Email { get; set; }
        [StringLength(maximumLength: 3, MinimumLength = 2, ErrorMessage = " El tipo de sangre es demasiado largo. Por favor, use un máximo de {1} caracteres. ")]
        public string TipoSangre { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 10, ErrorMessage = " El estado civil ingresado es demasiado largo. Por favor, use un máximo de {1} caracteres, como 'Casado/a' o 'Viudo/a'.")]
        public string EstadoCivil { get; set; }
        [StringLength(maximumLength: 8, MinimumLength = 5, ErrorMessage = " La {0} es demasiado larga. Por favor, reduzca la longitud a {1} caracteres o menos.")]
        public string Ocupación { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 10, ErrorMessage = " La fecha de registro es demasiado larga. Por favor, use un máximo de {1} caracteres.")]
        public DateTime FechaRegistro { get; set; }

        // Relación con Cuidad y Departamento
        public int CuidadID { get; set; } // Foreign Key a Cuidad
        public Cuidad? Cuidad { get; set; } // Relación con Cuidad

        public int DepartamentoID { get; set; } // Foreign Key a Departamento
        public Departamento Departamento { get; set; } // Relación con Departamento
    }

}
