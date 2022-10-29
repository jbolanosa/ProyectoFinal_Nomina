using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(15)]
        public string Contrasenia { get; set; }

        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }


    }
}
