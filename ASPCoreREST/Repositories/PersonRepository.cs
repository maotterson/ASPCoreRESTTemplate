using ASPCoreREST.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreREST.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> samplePersons = new()
        {
            new() { id = Guid.NewGuid(), Name = "Bob"},
            new() { id = Guid.NewGuid(), Name = "Sarah"},
            new() { id = Guid.NewGuid(), Name = "Thomas"}
        };

        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            return await Task.FromResult(samplePersons);
        }
    }
}
