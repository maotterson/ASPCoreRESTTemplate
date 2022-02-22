using ASPCoreREST.Models;

namespace ASPCoreREST.Repositories
{
    public class MongoPersonRepository : IPersonRepository
    {
        public Task<Person> GetPersonAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetPersonsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> ModifyPersonAsync(Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TryAddPersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TryDeletePersonAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
