namespace Pagina_Blazor.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

        public int? EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
        public ICollection<Puesto>? Puestos { get; set; }

    }
}
