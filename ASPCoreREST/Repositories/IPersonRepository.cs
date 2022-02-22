using ASPCoreREST.Dto;
using ASPCoreREST.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreREST.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPersonsAsync();
        Task<Person> GetPersonAsync(Guid id);
        Task<Person> PostPersonAsync(Person person);
        Task<Person> ModifyPersonAsync(Person updatedPerson);
        Task<bool> DeletePersonAsync(Guid id);
    }
}
