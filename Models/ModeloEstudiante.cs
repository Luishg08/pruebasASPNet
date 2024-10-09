using System.ComponentModel.DataAnnotations;

namespace MiPrimeraWeb.Models{
    public class ModeloEstudiante{
        [Key ]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
    }
}
