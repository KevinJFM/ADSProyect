using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{
    public class Materia
    {
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombreMateria { get; set; }
    }
}
