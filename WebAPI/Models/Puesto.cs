using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Puesto
    {
        public int PuestoId { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }

        public int? DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
        public ICollection<Empleado>? Empleados { get; set; }

    }
}
