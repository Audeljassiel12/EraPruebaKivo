namespace CentroMedico.Models.Dominio
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        [Requered(ErrorMensage = "Los {0} son requeridos para el siguiente paso")]
        [StringLength(maximumLength: 16, MinimumLength = 13, ErrorMessage = " Los {0} no cumplen con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Nombres { get; set; }
        [Requered(ErrorMensage = "Los {0} son requeridos para el siguiente paso")]
        [StringLength(maximumLength: 40, MinimumLength = 30, ErrorMessage = " Los {0} no cumplen con los requisitos de longitud. asegúrese de que tenga entre  {1} y {2} caracteres.")]
        public string Apellidos { get; set; }
        //public string Especialidad { get; set; }
        [Requered(ErrorMensage = "El numero de {0} es  requerido para el siguiente paso")]
        [StringLength(maximumLength: 10, MinimumLength = 8, ErrorMessage = " El numero de {0} es demasiado largo. Por favor, use un máximo de {1} caracteres.")]
        public string Telefono { get; set; }
        public string Email { get; set; }
        // Otros campos relevantes

        public ICollection<Cita> Citas { get; set; }
    }

}
