using System.ComponentModel.DataAnnotations;

namespace Trabajofinal2.Models
{
    public class Especialidad
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }        
    }
}
