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
        Task<bool> TryAddPersonAsync(Person person);
        Task<Person> ModifyPersonAsync(Person updatedPerson);
        Task<bool> TryDeletePersonAsync(Guid id);
    }
}
