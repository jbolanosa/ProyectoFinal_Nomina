using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName = "numeric(9)")]
        public int NIT { get; set; }
        [Column(TypeName = "numeric(8)")]
        public int Telefono { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }

        public ICollection<Departamento>? Departamentos { get; set; }

    }
}
