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
        Task<Person> PostPersonAsync(PersonDto personDto);
        Task<Person> ModifyPersonAsync(Guid id, PersonDto personDto);
        Task<bool> DeletePersonAsync(Guid id);
    }
}
