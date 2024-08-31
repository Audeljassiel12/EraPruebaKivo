namespace CentroMedico.Models.Dominio
{
    public class Suscripcion
    {
        public int id { get; set; }
        public int CentroMedicoId { get; set; } // FK de CentroMedico
        public int PlanSuscripcionId { get; set; } // FK a PlanSuscripcion
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; } // Puede ser nulo si está activa
        public bool Activa { get; set; } // Determina si la suscripción está activa

        // Navegación a CentroMedico
        public CentroMedico CentroMedico { get; set; }

        // Navegación a PlanSuscripcion
        public PlanSuscripcion PlanSuscripcion { get; set; }
    }

}
