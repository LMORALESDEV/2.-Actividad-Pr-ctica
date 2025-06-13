using System.ComponentModel.DataAnnotations;

namespace Actividad3LengPro3.Models
{
    public class EstudiantesViewModel
    {
        [Required(ErrorMessage ="El nombre del estudiante es obligatorio.")]
        [StringLength(100)]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "La matricula del estudiante es obligatoria.")]
        [StringLength(15, MinimumLength = 6)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "La carrera del estudiante es obligatoria.")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "El correo del estudiante es obligatorio.")]
        [EmailAddress]
        public string CorreoInstitucional { get; set; }

        [Phone(ErrorMessage = "El telefono del estudiante es obligatorio.")]
        [MinLength(10)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "la fecha del estudiante es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El genero del estudiante es obligatorio.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "El turno del estudiante es obligatorio.")]
        public string Turno { get; set; }

        [Required(ErrorMessage = "El tipo de ingreso del estudiante es obligatorio.")]
        public string TipoIngreso { get; set; }

        public bool EstaBecado { get; set; }

        [Range(0, 100, ErrorMessage = "Debe estar entre 0 y 100")]
        public int? PorcentajeBeca { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe aceptar los términos.")]
        public bool TerminosYCondiciones { get; set; }
    }
}
