using ASPCoreREST.Models;
using ASPCoreREST.Repositories;

namespace ASPCoreREST.Controllers
{
    public class EmployeeController : GenericController<Employee>
    {
        public EmployeeController(IRepository<Employee> repository) : base(repository)
        {
        }
    }
}
