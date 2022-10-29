using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; } 
        [StringLength(100)]
        public string Nombres { get; set; }
        [StringLength(100)]
        public string Apellidos { get; set; }
        [Column(TypeName = "numeric(13)")]
        public long DPI { get; set; }
        [Column(TypeName = "numeric(9)")]
        public int NIT { get; set; }
        [Column(TypeName = "numeric(8)")]
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
