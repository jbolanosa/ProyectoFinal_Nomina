namespace Pagina_Blazor.Models
{
    public class Puesto
    {
        public int PuestoId { get; set; }
        public string Nombre { get; set; }

        public int? DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
        public ICollection<Empleado>? Empleados { get; set; }

    }
}
