using System.ComponentModel.DataAnnotations;

namespace Taller1.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Ciudad  { get; set; }
        [Required]
        public int Cpacidad { get; set; }
    }
}
