using System.ComponentModel.DataAnnotations;

namespace Trabajofinal2.Models
{
    public class Escuela
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidadalumnos { get; set; }

        public virtual ICollection<Especialidad> Especialidades { get; set; } = new HashSet<Especialidad>();
    }
}
