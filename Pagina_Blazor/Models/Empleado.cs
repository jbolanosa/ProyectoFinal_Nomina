namespace Pagina_Blazor.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public long DPI { get; set; }
        public int NIT { get; set; }
        public int Telefono { get; set; }
        public string DireccionFiscal { get; set; }
        public string Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public double SalarioBase { get; set; }

        public int? PuestoId { get; set; }
        public Puesto? Puesto { get; set; }
        public ICollection<Nomina>? Nominas { get; set; }
        public Usuario? Usuario { get; set; }
    }
}