using ASPCoreREST.Models;
using ASPCoreREST.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T> : ControllerBase where T : IEntity
    {
        private IRepository<T> repository;

        public GenericController(IRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var items = (await repository.GetAllAsync()).
                Select(item => item.GetDto());

            return Ok(items);
        }
    }
}
