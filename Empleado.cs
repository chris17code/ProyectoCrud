using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAspNetMVC.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Puesto { get; set; }

        [Required]
        public int PaisId { get; set; }

        [ForeignKey("PaisId")]
        public Pais Pais { get; set; }
    }
}