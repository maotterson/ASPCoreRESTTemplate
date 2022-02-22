using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreREST.Dto
{
    public record PersonDto
    {
        public Guid Id { get; set; }
        public string Name { get; init; }
    }

    public record CreatePersonDto
    {
        [Required]
        public string Name { get; init; }
    }

    public record ModifyPersonDto
    {
        [Required]
        public string Name { get; init; }
    }
}
