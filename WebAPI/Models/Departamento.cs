using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }

        public int? EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
        public ICollection<Puesto>? Puestos { get; set; }

    }
}
