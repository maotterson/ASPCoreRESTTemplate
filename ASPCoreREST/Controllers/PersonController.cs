﻿using ASPCoreREST.Models;
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
        public async Task<IEnumerable<PersonDto>> GetPersonsAsync()
        {
            var persons = (await personRepository.GetPersonsAsync())
                .Select(person => person.AsDto());

            return persons;
        }
    }
}
