using System.ComponentModel.DataAnnotations;

namespace CrudAspNetMVC.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        public string Rol { get; set; } = "Usuario";
    }
}