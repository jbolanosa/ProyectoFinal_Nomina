namespace Pagina_Blazor.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }

        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }


    }
}
