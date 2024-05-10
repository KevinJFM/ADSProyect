﻿using ADSProyect.Interfaces;
using ADSProyect.Validations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProyect.Models
{
    [PrimaryKey(nameof(IdGrupo))]
    public class Grupo
    {

        public int IdGrupo { get; set; }
        [CustomRequired(ErrorMessage = "Este es un campo requerido")]
        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        public int Anio { get; set; }

    }
}
