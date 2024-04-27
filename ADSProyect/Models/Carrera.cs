using Microsoft.EntityFrameworkCore;
using ADSProyect.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{
    [PrimaryKey(nameof(IdCarrera))]
    public class Carrera
    {
        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombreCarrera { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser mayor a 12 caracteres.")]
        public string CodigoCarrera { get; set; }
    }
}
