using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreREST.Dto
{
    public record PersonDto
    {
        [Required]
        public string Name { get; init; }
    }
}
