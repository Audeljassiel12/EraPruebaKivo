namespace CentroMedico.Models.Dominio
{
    public class ConfiguracionCategoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } // Ejemplo: "Signos Vitales", "Resultados de Laboratorio"
        public string Descripcion { get; set; } // Descripción opcional de la categoría

        // Colección de opciones asociadas a esta categoría
        public ICollection<ConfiguracionOpcion> Opciones { get; set; }
    }


}
