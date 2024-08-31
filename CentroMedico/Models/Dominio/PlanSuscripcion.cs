namespace CentroMedico.Models.Dominio
{
    public class PlanSuscripcion
    {
        public int PlanSuscripcionID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public int DuracionEnMeses { get; set; } // Duración en meses

        // Relación con Suscripciones
        public ICollection<Suscripcion> Suscripciones { get; set; }
    }

}
