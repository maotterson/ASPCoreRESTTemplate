using ASPCoreREST.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreREST.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPersonsAsync();
        Task<Person> GetPersonAsync();
        Task<Person> PostPersonAsync();
        Task<Person> ModifyPersonAsync();
        Task<bool> DeletePersonAsync();
    }
}
