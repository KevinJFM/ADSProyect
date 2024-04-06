using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace ADSProyect.Models
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombresEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string ApellidosEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser mayor a 12 caracteres.")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 12 caracteres.")]
        public string CodigoEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un camporequerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor a 254 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato del correo electronico es incorrecto")]
        public string CorreoEstudiante { get; set; }
  
    }
}
