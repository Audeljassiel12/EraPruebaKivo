using System.ComponentModel.DataAnnotations;

namespace CentroMedico.Models.Dominio
{
    public class Paciente
    {
        public int Id { get; set; }
        [StringLength(maximumLength:60,MinimumLength =3,ErrorMessage ="El {0}  tiene que tener como maximo {1} y como mino {2}  ")]
        public string Nombre { get; set; } = null!;
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "El {0}  tiene que tener como maximo {1} y como mino {2}  ")] 
        public string Apellido { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }  = null !;
        public string Dirección { get; set; }
        public string? Teléfono { get; set; }
        public string Email { get; set; }
        public string TipoSangre { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupación { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con Cuidad y Departamento
        public int CuidadID { get; set; } // Foreign Key a Cuidad
        public Cuidad? Cuidad { get; set; } // Relación con Cuidad

        public int DepartamentoID { get; set; } // Foreign Key a Departamento
        public Departamento Departamento { get; set; } // Relación con Departamento
    }

}
