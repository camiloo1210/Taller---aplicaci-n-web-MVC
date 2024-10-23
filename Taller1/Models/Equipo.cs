using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Estadio? Estadio { get; set; }
        [Required]
        [ForeignKey("Estadio")]
        public int IdEstadio {  get; set; }

    }
}
