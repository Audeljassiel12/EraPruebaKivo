namespace CentroMedico.Models.Dominio
{
    public enum TiposCentroMedico
    {
        Consultorio = 0,
        Clinica = 1
    }
    public enum DiasDeLaSemanaAtencion
    {
        Domingo = 0,
        Lunes = 1,
        Martes = 2,
        Miercoles = 3,
        Jueves = 4,
        Viernes = 5,
        Sabado = 6
    }

    public class CentroMedico
    {
        public int Id { get; set; } // Clave primaria
        [Requered(ErrorMensage = "El {0} del  Centro Medico  es requeridos para el siguiente paso")]
        [StringLength(maximumLength: 20, MinimumLength = 10, ErrorMessage = " El {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Nombre { get; set; } // Nombre del centro médico
        [Requered(ErrorMensage = "La {0} de el Centro Medico  es requeridos para el siguiente paso")]
        [StringLength(maximumLength: 30, MinimumLength = 20, ErrorMessage = " La {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Direccion { get; set; } // Dirección física
        [Requered(ErrorMensage = "La {0} de del Centro Medico es requeridos para el siguiente paso")]
        [StringLength(maximumLength: 15, MinimumLength = 10, ErrorMessage = " La nombre {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Ciudad { get; set; } // Ciudad
        [Requered(ErrorMensage = "El {0} del Centro Medico  es requeridos para el siguiente paso")]
        [StringLength(maximumLength: 15, MinimumLength = 13, ErrorMessage = " El nombre del  {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public Departamento Departamento { get; set; } // Departamento 
        [Requered(ErrorMensage = "El {0} del Centro Medico es requeridos para el siguiente paso")]
        [StringLength(maximumLength: 10, MinimumLength = 8, ErrorMessage = " El {0} no cumple con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Telefono { get; set; } // Número de teléfono
        public string SitioWeb { get; set; } // Sitio web del centro médico
        public string Tipo { get; set; } // Tipo de centro (por ejemplo , consultorio , clinica)
        public string HorarioAtencion { get; set; } // Horario de atención como cadena de texto (ej. "Lunes a Viernes 9:00 - 17:00")
        public string Descripcion { get; set; } // Descripción del centro médico
        public DateTime FechaRegistro { get; set; } // Fecha en que se registró el centro
        public TiposCentroMedico TipoCentroMedico { get; set; }
        

        // Relaciones
        public ICollection<Doctor> Doctores { get; set; } // Lista de doctores asociados al centro
        public ICollection<Paciente> Pacientes { get; set; } // Lista de pacientes asociados al centro
        public ICollection<Cita> Citas { get; set; } // Lista de citas asociadas al centro
        public ICollection<HorarioAtencion> HorarioAtencions { get; set; }
        public ICollection<Suscripcion> Suscripciones { get; set; }
     
    }

}
