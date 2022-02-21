using ASPCoreREST.Dto;
using ASPCoreREST.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreREST.Helpers
{
    public static class DtoHelpers
    {
        public static PersonDto AsDto(this Person person)
        {
            PersonDto personDto = new()
            {
                Name = person.Name
            };

            return personDto;
        }
    }
}
