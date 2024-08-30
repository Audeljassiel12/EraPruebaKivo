namespace CentroMedico.Models.Dominio
{
    public class ConfiguracionOpcion
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; } // FK a ConfiguracionCategoria
        public string Clave { get; set; } // Ejemplo: "Peso", "Glucosa"
        public string Descripcion { get; set; } // Ejemplo: "Peso", "Glucosa en ayunas"
        public bool EstaVisible { get; set; } // Determina si la opción está activa

        // Navegación a la categoría de configuración
        public ConfiguracionCategoria Categoria { get; set; }
    }


}
