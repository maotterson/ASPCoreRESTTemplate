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

        public async Task<bool> TryDeletePersonAsync(Guid id)
        {
            try
            {
                int personIndex = samplePersons.FindIndex(person => person.id == id);
                samplePersons.RemoveAt(personIndex);
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<Person> GetPersonAsync(Guid id)
        {
            Person foundPerson = samplePersons.Find(person => person.id == id);
            return await Task.FromResult(foundPerson);
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            return await Task.FromResult(samplePersons);
        }

        public async Task<Person> ModifyPersonAsync(Person newPerson)
        {
            int personIndex = samplePersons.FindIndex(oldPerson => oldPerson.id == newPerson.id);
            samplePersons[personIndex] = newPerson;

            return await Task.FromResult(newPerson);
        }

        public async Task<bool> TryAddPersonAsync(Person person)
        {
            try
            {
                samplePersons.Add(person);
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
    }
}
