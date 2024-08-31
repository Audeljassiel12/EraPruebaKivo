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
        public string Nombre { get; set; } // Nombre del centro médico
        public string Direccion { get; set; } // Dirección física
        public string Ciudad { get; set; } // Ciudad
        public Departamento Departamento { get; set; } // Departamento 
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
