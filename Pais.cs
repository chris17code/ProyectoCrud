using System.ComponentModel.DataAnnotations;

namespace CrudAspNetMVC.Models
{
    public class Pais
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
    }
}