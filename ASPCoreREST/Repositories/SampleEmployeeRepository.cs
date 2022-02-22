using ASPCoreREST.Models;

namespace ASPCoreREST.Repositories
{
    public class SampleEmployeeRepository : IRepository<Employee>
    {
        private List<Employee> sampleEmployees = new()
        {
            new() { Id = Guid.NewGuid(), Name = "Robert" },
            new() { Id = Guid.NewGuid(), Name = "Wilma" }
        };

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await Task.FromResult(sampleEmployees);
        }
    }
}
