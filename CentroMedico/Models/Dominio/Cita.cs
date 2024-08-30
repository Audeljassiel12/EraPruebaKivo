namespace CentroMedico.Models.Dominio
{
    //"Programada", "En Proceso", "Finalizada", "Cancelada"
  public  enum EstadoDeCita
    {
       
        Programada=1,
        Proceso=2,
        Finalizada = 3,
        Cancelada = 4


    }
  
    public class Cita
    {
        public int Id { get; set; }
        public int PacienteID { get; set; }
        public int DoctorID { get; set; }
        public int CentroMedicoID { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; } = null!;
        public EstadoDeCita EstadoDeCita  { get; set; } // FK a EstadoCita
       
        // Relaciones
        public Paciente? Paciente { get; set; }
      
        public Doctor? Doctor { get; set; }
        //public CentroMedico CentroMedico { get; set; }
        //public EstadoCita EstadoCita { get; set; }
        //public ICollection<SignosVitales> SignosVitales { get; set; }
        //public ICollection<ResultadosLaboratorio> ResultadosLaboratorio { get; set; }
        //public ICollection<PlanTratamiento> PlanesTratamiento { get; set; }
        //public ICollection<SeguimientoNutriologico> SeguimientosNutriologicos { get; set; }
        //public ICollection<ExploracionTopografica> ExploracionesTopograficas { get; set; }
        //public ICollection<Odontograma> Odontogramas { get; set; }
        //public ICollection<ExamenFisico> ExamenesFisicos { get; set; }
        public ICollection<SignosVitales> SignosVitales { get; set; }
    }

}
