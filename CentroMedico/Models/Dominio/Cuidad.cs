namespace CentroMedico.Models.Dominio
{
    public class Cuidad
    {
        public int MunicipioID { get; set; } // Primary Key
        public string Nombre { get; set; }

        // Relación muchos a uno con Departamento
        public int DepartamentoID { get; set; } // Foreign Key
        public Departamento Departamento { get; set; }

        // Relación uno a muchos con Paciente
        public List<Paciente> Pacientes { get; set; }
    }
}
