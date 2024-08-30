namespace CentroMedico.Models.Dominio
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        //public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        // Otros campos relevantes

        public ICollection<Cita> Citas { get; set; }
    }

}
