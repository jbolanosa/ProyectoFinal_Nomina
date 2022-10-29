using Pagina_Blazor.Models;

namespace Pagina_Blazor.Services
{
    public interface IDepartamentoService
    {
        //Ingresar datos
        Task<HttpResponseMessage> PostDepartamento(Departamento departamento);
        //Obtiene lista de departamentos
        Task<List<Departamento>> GetDepartamento();
        //Obtiene un departamento segun el id enviado
        Task<Departamento> GetDepartamento(int id);
        //Modificar
        Task<HttpResponseMessage> PutDepartamento(int id, Departamento departamento);
    }
}
