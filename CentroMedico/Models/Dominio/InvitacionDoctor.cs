namespace CentroMedico.Models.Dominio
{
    public class InvitacionDoctor
    {
        public int InvitacionDoctorID { get; set; } // Clave primaria
        public string Email { get; set; } // Email del doctor al que se envía la invitación
        public string Token { get; set; } // Token único para la invitación
        public DateTime FechaInvitacion { get; set; } // Fecha en la que se envió la invitación
        public bool EstaAceptada { get; set; } // Estado de la invitación (si ha sido aceptada)
        public bool EstaExpirada { get; set; } // Indica si la invitación ha expirado

        // Información adicional del doctor para completar el registro
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Especialidad { get; set; }
    }

}
