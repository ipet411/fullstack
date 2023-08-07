using System.ComponentModel.DataAnnotations;

namespace Trabajofinal2.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? Nacimiento { get; set; }
    }
}
