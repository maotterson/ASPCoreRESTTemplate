using ASPCoreREST.Dto;

namespace ASPCoreREST.Models
{
    public interface IEntity
    {
        public Guid Id { get; init; }
        public IDto GetDto();
        public interface IDto
        {
            public Guid Id { get; init; }
        }
    }
}
