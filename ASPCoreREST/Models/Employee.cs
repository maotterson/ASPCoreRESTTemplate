namespace ASPCoreREST.Models
{
    public class Employee : IEntity
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public IEntity.IDto GetDto()
        {
            EmployeeDto dto = new()
            {
                Id = this.Id,
                Name = this.Name
            };
            return dto;
        }
        public class EmployeeDto : IEntity.IDto
        {
            public Guid Id { get; init; }
            public string Name { get; init; }

        }
    }
}