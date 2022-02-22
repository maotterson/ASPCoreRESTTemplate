using ASPCoreREST.Models;
using ASPCoreREST.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASPCoreREST.Helpers;
using ASPCoreREST.Dto;

namespace ASPCoreREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepository personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetPersonsAsync()
        {
            var persons = (await personRepository.GetPersonsAsync())
                .Select(person => person.AsDto());

            return Ok(persons);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonAsync(Guid id)
        {
            var isDeleted = await personRepository.TryDeletePersonAsync(id);

            if (!isDeleted)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPersonAsync(Guid id)
        {
            var foundPerson = await personRepository.GetPersonAsync(id);

            if (foundPerson is null)
            {
                return NotFound();
            }

            return Ok(foundPerson);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ModifyPersonAsync(Guid id, ModifyPersonDto updatedPersonDto)
        {
            var foundPerson = await personRepository.GetPersonAsync(id);

            if (foundPerson is null)
            {
                return NotFound();
            }

            foundPerson = foundPerson with { Name = updatedPersonDto.Name };
            var updatedPerson = await personRepository.ModifyPersonAsync(foundPerson);

            return Ok(updatedPerson);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePersonAsync(CreatePersonDto updatedPersonDto)
        {
            Person createdPerson = new()
            {
                id = Guid.NewGuid(),
                Name = updatedPersonDto.Name
            };

            bool isCreated = await personRepository.TryAddPersonAsync(createdPerson);

            if (!isCreated)
            {
                return BadRequest();
            }

            return Ok(createdPerson);
        }
    }
}
