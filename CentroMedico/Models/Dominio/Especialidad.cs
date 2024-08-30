namespace CentroMedico.Models.Dominio
{
    public class Especialidad
    {
        public int EspecialidadID { get; set; } // Clave primaria
        public string Nombre { get; set; } // Nombre de la especialidad

        // Relación
        public ICollection<Doctor> Doctores { get; set; } // Relación muchos a muchos con doctores
    }

}
