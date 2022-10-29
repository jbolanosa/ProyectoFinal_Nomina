namespace Pagina_Blazor.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public int NIT { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public ICollection<Departamento>? Departamentos { get; set; }

    }
}
