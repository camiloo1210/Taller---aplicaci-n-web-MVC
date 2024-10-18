using System.ComponentModel.DataAnnotations;

namespace Taller1.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Ciudad {  get; set; }
        [Required]
        public int Titulos { get; set; }
        [Required]
        public bool AceptaExtranjeros {  get; set; }
        [Required]
        public string Estadio {  get; set; }

    }
}
